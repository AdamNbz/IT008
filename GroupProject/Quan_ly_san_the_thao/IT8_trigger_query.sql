-- Đảm bảo các thông nhập vào của một khách hàng không được phép NULL và nằm trong giới hạn ký tự
    CREATE TRIGGER TRIGGER_DAMBAO_THONGTIN_DUNG_DU
    ON KHACHHANG
    AFTER 
        INSERT,
        UPDATE
    AS 
    BEGIN 
        DECLARE 
            @PASSWRD VARCHAR(20),
            @TENKH VARCHAR(60),
            @EMAIL VARCHAR(60),
            @SDT VARCHAR(10),
            @GTINH BIT
        
        SELECT
            @PASSWRD = INSERTED.PASSWRD,
            @TENKH = INSERTED.TENKH,
            @EMAIL = INSERTED.EMAIL,
            @SDT = INSERTED.SDT,
            @GTINH = INSERTED.GTINH
        FROM INSERTED

        IF (
            @PASSWRD = NULL
            OR
            @TENKH = NULL
            OR
            @EMAIL = NULL
            OR
            @SDT = NULL
            OR
            @GTINH = NULL
        )
            BEGIN
                RAISERROR('Thong tin nhap vao khong duoc phep bo trong', 16, 1)
                ROLLBACK TRANSACTION
            END
        ELSE IF (
            LEN(@PASSWRD) > 20
            OR
            LEN(@TENKH) > 60
            OR
            LEN(@EMAIL) > 60
            OR
            LEN(@SDT) > 10
        )
            BEGIN
                RAISERROR('Thong tin nhap vao vuot qua ky tu cho phep', 16, 1)
                ROLLBACK TRANSACTION
            END
        ELSE IF (
            @GTINH NOT IN (1, 0)
        )
            BEGIN
                RAISERROR('Gioi tinh chi co the la 1 (Nam) va 0 (Nu)', 16, 1)
                ROLLBACK TRANSACTION
            END
        ELSE IF (
            LEN(@PASSWRD) < 10
            OR
            LEN(@TENKH) < 2
            OR
            LEN(@EMAIL) < 2
            OR
            LEN(@SDT) < 8
        )
            BEGIN
                RAISERROR('Thong tin nhap vao khong du do dai toi thieu cho phep', 16, 1)
                ROLLBACK TRANSACTION
            END
    END
    GO
-- Đảm bảo rằng mỗi sân thể thao chỉ sử dụng cho một môn thể thao duy nhất
    CREATE TRIGGER TRIGGER_DAMBAO_1SANTHETHAO_1MONTHETHAO
    ON SANTHETHAO
    AFTER 
        INSERT,
        UPDATE
    AS 
    BEGIN 
        DECLARE 
            @DEMTRUNGLAP INT
        
        SELECT @DEMTRUNGLAP = COUNT(*)
        FROM (
            SELECT SANTHETHAO.MASANTT
            FROM SANTHETHAO
            GROUP BY SANTHETHAO.MASANTT
            HAVING COUNT(DISTINCT SANTHETHAO.MONTHETHAO) > 1
        ) AS DEMTRUNGLAPTABLE;

        IF (
            @DEMTRUNGLAP > 0
        )
            BEGIN
                RAISERROR('Moi san the thao chi duoc gan lien voi 1 mon the thao duy nhat', 16, 1)
                ROLLBACK TRANSACTION
            END
    END
    GO
-- Đảm bảo rằng giá thuê sân vào buổi trưa là nhỏ nhất trong số 3 giá thuê sân, giá thuê sân sáng và tối chỉ có thể lệch nhau 30k
    CREATE TRIGGER TRIGGER_DAMBAO_CHENHLECH_GIATHUE
    ON SANTHETHAO
    AFTER 
        INSERT,
        UPDATE
    AS 
    BEGIN 
        IF EXISTS (
            SELECT *
            FROM INSERTED
            WHERE (
                INSERTED.GTTRUA >= INSERTED.GTSANG
                OR
                INSERTED.GTTRUA >= INSERTED.GTTOI
            )
        )
            BEGIN
                RAISERROR('Gia thue san vao buoi trua phai la gia thue nho nhat trong so 3 gia thue sang, trua, toi', 16, 1)
                ROLLBACK TRANSACTION
            END
        ELSE IF EXISTS (
            SELECT *
            FROM INSERTED
            WHERE ABS(INSERTED.GTSANG - INSERTED.GTTOI) > 30000
        )
            BEGIN
                RAISERROR('Gia thue san vao buoi sang va buoi toi chi duoc phep chenh lech nhau 30k', 16, 1)
                ROLLBACK TRANSACTION
            END
    END
    GO
-- Đảm bảo rằng ngày hóa đơn có hiệu lực chỉ nằm trong khoảng ngày thanh toán đến ngày thanh toán + 7
    CREATE TRIGGER TRIGGER_DAMBAO_HIEULUC_HOADON
    ON CTHD
    AFTER 
        INSERT,
        UPDATE
    AS 
    BEGIN 
        IF EXISTS (
            SELECT *
            FROM INSERTED
            JOIN HOADON
                ON INSERTED.MAHD = HOADON.MAHD
            WHERE (
                INSERTED.NGHDHLUC < HOADON.NGTTOAN
                OR
                INSERTED.NGHDHLUC > DATEADD(DAY, 7, HOADON.NGTTOAN)
            )
        )
            BEGIN
                RAISERROR('Hoa don chi co hieu luc trong vong 7 ngay tinh tu ngay thanh toan', 16, 1)
                ROLLBACK TRANSACTION
            END
    END
    GO
