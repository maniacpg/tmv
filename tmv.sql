create database TMV
go

use TMV
go

create table tblBenhNhan
(
MaBN varchar(10) primary key NOT NULL,
TenBN nvarchar(50)
)

create table tblDichVu
(
IDDV varchar(10) primary key NOT NULL,
TenDV nvarchar(100)
)

create table tblHopDong
(
    Ngay datetime,
    MaBN varchar(10),
    DichVu varchar(100),
    foreign key (MaBN) references tblBenhNhan(MaBN)    
)

ALTER TABLE tblHopDong
ALTER COLUMN Ngay DATE;


CREATE PROCEDURE sp_InsertBenhNhan
    @MaBN varchar(10),
    @TenBN nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO tblBenhNhan (MaBN, TenBN)
    VALUES (@MaBN, @TenBN);

    SELECT @@ROWCOUNT AS 'Rows Affected';
END

CREATE PROCEDURE sp_InsertHopDong
    @Ngay datetime,
    @MaBN varchar(10),
    @DichVu varchar(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO tblHopDong (Ngay, MaBN, DichVu)
    VALUES (@Ngay, @MaBN, @DichVu);

    SELECT @@ROWCOUNT AS 'Rows Affected';
END

CREATE PROCEDURE sp_GetHopDong
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Ngay, MaBN, DichVu
    FROM tblHopDong
    ORDER BY Ngay ASC;
END
exec sp_GetHopDong

CREATE PROCEDURE sp_GetHopDongByMaBN
    @MaBN varchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Ngay, MaBN, DichVu
    FROM tblHopDong
    WHERE MaBN = @MaBN
    ORDER BY Ngay ASC;
END


INSERT INTO tblBenhNhan (MaBN, TenBN) VALUES ('BN001', N'Nguyễn Văn An');
INSERT INTO tblBenhNhan (MaBN, TenBN) VALUES ('BN002', N'Trần Thị Bích');
INSERT INTO tblBenhNhan (MaBN, TenBN) VALUES ('BN003', N'Lê Hoàng Cường');
INSERT INTO tblBenhNhan (MaBN, TenBN) VALUES ('BN004', N'Phạm Quỳnh Dung');
INSERT INTO tblBenhNhan (MaBN, TenBN) VALUES ('BN005', N'Đặng Minh Đức');

INSERT INTO tblDichVu (IDDV, TenDV) VALUES ('DV001', N'Lăn kim');
INSERT INTO tblDichVu (IDDV, TenDV) VALUES ('DV002', N'Triệt lông');
INSERT INTO tblDichVu (IDDV, TenDV) VALUES ('DV003', N'Nâng mũi');
INSERT INTO tblDichVu (IDDV, TenDV) VALUES ('DV004', N'Cắt môi trái tim');
INSERT INTO tblDichVu (IDDV, TenDV) VALUES ('DV005', N'Cắt mí mắt');
INSERT INTO tblDichVu (IDDV, TenDV) VALUES ('DV006', N'Xăm lông mày');
INSERT INTO tblDichVu (IDDV, TenDV) VALUES ('DV007', N'Xăm môi');

select * from tblBenhNhan
select * from tblHopDong