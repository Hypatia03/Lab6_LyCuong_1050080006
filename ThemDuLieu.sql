CREATE PROCEDURE ThemDuLieu
    @maXB CHAR(10),
    @tenXB NVARCHAR(100),
    @diaChi NVARCHAR(500)
AS
BEGIN
    INSERT INTO NhaXuatBan
    VALUES (@maXB, @tenXB, @diaChi);
END 