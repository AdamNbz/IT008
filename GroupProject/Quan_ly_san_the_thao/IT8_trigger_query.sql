-- Các thông tin của một khách hàng không được phép trống, đúng định dạng (ví dụ email phải có @gmail.com, sdt luôn bắt đầu bằng số 0) và nằm trong giới hạn ký tự.
    CREATE TRIGGER TRIGGER_THONGTIN_KHACHHANG
    ON KHACHHANG
    BEFORE 
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
                RAISERROR(N'Thông tin khách hàng không được phép bỏ trống!', 16, 1)
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
                RAISERROR(N'Thông tin nhập quá ký tự cho phép!', 16, 1)
                ROLLBACK TRANSACTION
            END
        ELSE IF (
            LEN(@PASSWRD) < 7
            OR
            LEN(@TENKH) < 2
            OR
            LEN(@EMAIL) < 10
            OR
            LEN(@SDT) < 8
        )
            BEGIN
                RAISERROR(N'Thông tin chưa đủ độ dài tối thiểu cho phép!', 16, 1)
                ROLLBACK TRANSACTION
            END
		ELSE IF (
			@EMAIL NOT LIKE '%@gmail.com'
		)
			BEGIN
				RAISERROR(N'Email chưa chính xác!', 16, 1)
				ROLLBACK TRANSACTION
			END
		ELSE IF (
			LEFT(@SDT, 1) <> '0'
		)
			BEGIN
				RAISERROR(N'Số điện thoại chưa chính xác!', 16, 1)
				ROLLBACK TRANSACTION
			END
    END
    GO

