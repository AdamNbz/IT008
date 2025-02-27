﻿CREATE DATABASE IT8_DATABASE_PROJECT
USE IT8_DATABASE_PROJECT

SET DATEFORMAT dmy

GO

CREATE TABLE KHACHHANG
(
    USERNAME VARCHAR(20) NOT NULL,
    PASSWRD VARCHAR(20) NOT NULL,
    TENKH NVARCHAR(60) NOT NULL,
    EMAIL VARCHAR(60) NOT NULL,
    SDT VARCHAR(10) NOT NULL,
	SODU MONEY DEFAULT 0,
    GTINH BIT NOT NULL, -- 0: female, 1: male
    CONSTRAINT CS_PK_KHACHHANG PRIMARY KEY(USERNAME)
)
CREATE TABLE SANTHETHAO
(
    MASANTT VARCHAR(10) NOT NULL,
    MONTHETHAO VARCHAR(40) NOT NULL,
    TENSANTT VARCHAR(50) NOT NULL,
    GTSANG MONEY NOT NULL,
    GTCHIEU MONEY NOT NULL,
    GTTOI MONEY NOT NULL,
    CONSTRAINT CS_PK_SANTHETHAO PRIMARY KEY(MASANTT)
)

CREATE TABLE GIAMGIA
(
	MAGIAMGIA VARCHAR(10) NOT NULL,
	HESO VARCHAR(4) NOT NULL,
	TGHIEULUC DATE NOT NULL
	CONSTRAINT CK_PK_GIAMGIA PRIMARY KEY(MAGIAMGIA)
)

ALTER TABLE HOADON DROP CONSTRAINT PK_GIAMGIA_TO_FK_HOADON

CREATE TABLE HOADON
(
    MAHD VARCHAR(10) NOT NULL,
    USERNAME VARCHAR(20) NOT NULL,
    NGTTOAN DATE NOT NULL,
    TRIGIA MONEY NOT NULL,
	MAGIAMGIA VARCHAR(10),
	PHUONGTHUCTT VARCHAR(20),
	TINHTRANGHD BIT DEFAULT 0, -- 0 là chưa thanh toán, 1 là đã thanh toán
    CONSTRAINT CS_PK_HOADON PRIMARY KEY(MAHD)
)
CREATE TABLE CTHD
(
    MAHD VARCHAR(10) NOT NULL,
	MASANTT VARCHAR(10) NOT NULL,
    NGHDHLUC DATE NOT NULL,
	KHUNGGIO VARCHAR(50) NOT NULL, -- Có thể đặt nhiều khung giờ trong 1 sân, lưu theo dạng "[khung1]+[khung2]+...+[khungN]_[tgian sân 2]_[tgian sân 3]" (dạng chuỗi)
	SANDAT VARCHAR(3) DEFAULT 000,
	MONTHETHAO VARCHAR(40) NOT NULL
    CONSTRAINT CS_PK_CTHD PRIMARY KEY(MAHD)
)

CREATE TABLE THONGBAO
(
	MATB VARCHAR(10) NOT NULL,
	USERNAME VARCHAR(20) NOT NULL,
	LOAITB BIT NOT NULL, -- 0 là nạp tiền, 1 là yêu cầu reset mật khẩu
	CONSTRAINT CS_PK_THONGBAO PRIMARY KEY(MATB, USERNAME)
	CONSTRAINT PK_KHACHHANG_TO_FK_THONGBAO FOREIGN KEY(USERNAME) REFERENCES KHACHHANG(USERNAME)
)

GO

ALTER TABLE HOADON
ADD CONSTRAINT PK_KHACHHANG_TO_FK_HOADON
FOREIGN KEY(USERNAME) REFERENCES KHACHHANG(USERNAME)

ALTER TABLE HOADON
ADD CONSTRAINT PK_GIAMGIA_TO_FK_HOADON
FOREIGN KEY(MAGIAMGIA) REFERENCES GIAMGIA(MAGIAMGIA)

ALTER TABLE CTHD
ADD CONSTRAINT PK_HOADON_TO_FK_CTHD
FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD)

ALTER TABLE CTHD
ADD CONSTRAINT PK_SANTHETHAO_TO_FK_CTHD
FOREIGN KEY(MASANTT) REFERENCES SANTHETHAO(MASANTT)

ALTER TABLE SANTHETHAO
DROP CONSTRAINT CS_PK_SANTHETHAO

ALTER TABLE SANTHETHAO
ADD CONSTRAINT CS_PK_SANTHETHAO PRIMARY KEY(MASANTT, MONTHETHAO)

ALTER TABLE CTHD
ADD MONTHETHAO VARCHAR(40) NOT NULL

ALTER TABLE CTHD
DROP CONSTRAINT CS_PK_CTHD

ALTER TABLE CTHD
ADD CONSTRAINT CS_PK_CTHD PRIMARY KEY(MAHD, MASANTT, MONTHETHAO)

ALTER TABLE CTHD
DROP CONSTRAINT PK_SANTHETHAO_TO_FK_CTHD

ALTER TABLE CTHD
ADD CONSTRAINT PK_SANTHETHAO_TO_FK_CTHD
FOREIGN KEY(MASANTT, MONTHETHAO) REFERENCES SANTHETHAO(MASANTT, MONTHETHAO)