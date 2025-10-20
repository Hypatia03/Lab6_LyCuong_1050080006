create proc CapNhatThongTin
    @maNXB char(10),
    @tenNXB nvarchar(100),
    @diaChi nvarchar(500)
as
begin
    update NhaXuatBan
    set
        NXB = @maNXB,
        TenNXB = @tenNXB,
        DiaChi = @diaChi
    where NXB = @maNXB
end
