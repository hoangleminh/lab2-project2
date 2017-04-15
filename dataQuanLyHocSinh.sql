
insert into tblDangNhap(TaiKhoan,MatKhau) values ('admin','admin')

insert into tblGiaoVien(MaGiaovien,TenGiaovien,SoDienthoai,DiaChiEmail) values(1,'Nguyen Duc Hung','01649323424','NguyenDucHung@gmail.com')
insert into tblGiaoVien(MaGiaovien,TenGiaovien,SoDienthoai,DiaChiEmail) values(2,'Nguyen Thanh Duc','0934241345','NguyenThanhDuc@gmail.com')
insert into tblGiaoVien(MaGiaovien,TenGiaovien,SoDienthoai,DiaChiEmail) values(3,'Le Thi Ha','0934254234','LeThiHa@gmail.com')
insert into tblGiaoVien(MaGiaovien,TenGiaovien,SoDienthoai,DiaChiEmail) values(4,'Pham Van Nam','01643535256','PhamVanNam@gmail.com')
insert into tblGiaoVien(MaGiaovien,TenGiaovien,SoDienthoai,DiaChiEmail) values(5,'Dao Xuan Luc','04344242423','DaoXuanLuc@gmail.com')

insert into tblLop(MaLop,TenLop,MaGiaoVien,Ban) values (1,'9A1',1,'A')
insert into tblLop(MaLop,TenLop,MaGiaoVien,Ban) values (2,'9A2',2,'A')
insert into tblLop(MaLop,TenLop,MaGiaoVien,Ban) values (3,'9B1',3,'B')
insert into tblLop(MaLop,TenLop,MaGiaoVien,Ban) values (4,'9C4',4,'C')

insert into tblHocSinh(MaHocSinh,TenHocSinh,GT,NgaySinh,QueQuan,DanToc,MaLop) values (1,'Nguyen Van A','Nam','1997/08/25','Ha Dong','Kinh',1)

insert into tblMonHoc(MaMonhoc,TenMonhoc,MaBan) values (1,'Toan','A')
insert into tblMonHoc(MaMonhoc,TenMonhoc,MaBan) values (2,'Van','D')
insert into tblMonHoc(MaMonhoc,TenMonhoc,MaBan) values (3,'Sinh','B')
insert into tblMonHoc(MaMonhoc,TenMonhoc,MaBan) values (4,'Anh','A')
insert into tblMonHoc(MaMonhoc,TenMonhoc,MaBan) values (5,'Ly','A')
insert into tblMonHoc(MaMonhoc,TenMonhoc,MaBan) values (6,'Su','C')
insert into tblMonHoc(MaMonhoc,TenMonhoc,MaBan) values (7,'Hoa','A')
insert into tblMonHoc(MaMonhoc,TenMonhoc,MaBan) values (8,'Dia','C')

insert into tblLopMonHoc(MaLopMH,TenLopMH,LichHoc,MaMonHoc,MaLop,MaGiaoVien) values (1,'Toan 1','1-3 T2',1,1,1)

