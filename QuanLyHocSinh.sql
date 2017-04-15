
CREATE TABLE tblDangNhap(
	TaiKhoan varchar(20) NOT NULL,
	MatKhau varchar(20) NOT NULL,
	primary key (TaiKhoan)
)

CREATE TABLE tblGiaoVien(
	MaGiaovien int,
	TenGiaovien nvarchar(50),
	SoDienthoai varchar(20),
	DiaChiEmail nvarchar(50),
	primary key(MaGiaovien)
)
CREATE TABLE tblLop(
	MaLop int,
	TenLop nvarchar(10),
	MaGiaoVien int,
	Ban nvarchar(10),
	primary key(MaLop),
	foreign key (MaGiaoVien) references tblGiaoVien(MaGiaoVien)
)
CREATE TABLE tblHocSinh(
	MaHocSinh int,
	TenHocSinh nvarchar(50),
	GT char(3) check(GT in ('Nam','Nu')),
	NgaySinh datetime,
	QueQuan nvarchar(20),
	DanToc nvarchar(20),
	MaLop int,
	primary key (MaHocsinh),
	foreign key (MaLop) references tblLop(MaLop)
)

CREATE TABLE tblMonHoc(
	MaMonHoc int,
	TenMonhoc nvarchar(20),
	MaBan varchar(5),
	primary key (MaMonhoc)
)
CREATE TABLE tblLopMonHoc(
	MaLopMH int,
	TenLopMH nvarchar(20),
	LichHoc nvarchar(20),
	MaMonHoc int,
	MaLop int,
	MaGiaoVien int,
	primary key (MaLopMH),
	foreign key (MaMonHoc) references tblMonHoc(MaMonHoc),
	foreign key (MaLop) references tblLop(MaLop),
	foreign key (MaGiaoVien) references tblGiaoVien(MaGiaoVien)
)