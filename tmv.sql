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

CREATE TABLE tblHopDong
(
    Ngay DATE,
    MaBN VARCHAR(10),
    DichVu NVARCHAR(100) COLLATE Vietnamese_CI_AS,
    FOREIGN KEY (MaBN) REFERENCES tblBenhNhan(MaBN)    
);

ALTER TABLE tblHopDong
ALTER COLUMN Ngay DATE;




CREATE PROCEDURE sp_InsertBenhNhan
    @MaBN varchar(10),
    @TenBN nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO tblBenhNhan (MaBN, TenBN)
    VALUES (@MaBN, @TenBN COLLATE Vietnamese_CI_AS);

    SELECT @@ROWCOUNT AS 'Rows Affected';
END

CREATE PROCEDURE sp_InsertHopDong
    @Ngay DATE,
    @MaBN VARCHAR(10),
    @DichVu NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO tblHopDong (Ngay, MaBN, DichVu)
    VALUES (@Ngay, @MaBN COLLATE Vietnamese_CI_AS, @DichVu COLLATE Vietnamese_CI_AS);

    SELECT @@ROWCOUNT AS 'Rows Affected';
END;

select * from tblHopDong

delete tblHopDong
CREATE PROCEDURE sp_GetHopDong
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Ngay, MaBN, DichVu
    FROM tblHopDong
    ORDER BY Ngay ASC;
END

CREATE PROCEDURE sp_GetHopDongByMaBN
    @MaBN varchar(10) 
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Ngay, MaBN, DichVu
    FROM tblHopDong
    WHERE MaBN = @MaBN COLLATE Vietnamese_CI_AS
    ORDER BY Ngay ASC;
END

Alter proc Select_ThongTinKhamTheoNgay
as 
begin
	select h.Ngay, b.MaBN, b.TenBN, h.DichVu, COUNT(b.MaBN) AS SoLuongBenhNhan
	from tblBenhNhan as b, tblHopDong as h 
	where h.MaBN = b.MaBN 
	GROUP BY 
        h.Ngay
	order by h.Ngay asc
end
go

alter PROCEDURE Select_ThongTinKhamTheoNgay
AS
BEGIN
    SET NOCOUNT ON;

    -- Sử dụng CTE để đếm số lượng bệnh nhân theo ngày
    WITH BenhNhanTheoNgay AS (
        SELECT 
            Ngay,
            COUNT(DISTINCT MaBN) AS SoLuongBenhNhan
        FROM 
            tblHopDong
        GROUP BY 
            Ngay
    )

    -- Truy vấn kết hợp thông tin chi tiết
    SELECT 
        h.Ngay,
        b.MaBN,
        b.TenBN,
        h.DichVu,
        bn.SoLuongBenhNhan
    FROM 
        tblHopDong AS h
    INNER JOIN 
        tblBenhNhan AS b ON h.MaBN = b.MaBN
    INNER JOIN 
        BenhNhanTheoNgay AS bn ON h.Ngay = bn.Ngay
    ORDER BY 
        h.Ngay ASC;
END
GO

exec Select_ThongTinKhamTheoNgay
delete tblHopDong


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