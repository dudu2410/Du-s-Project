create database QLK
go
use QLK
go
create table hanghoa(
	mahh nchar(10),
	tenhh nvarchar(50),
	slton int,
	gia float,
	primary key (mahh)
);
go
create table khachhang(
	makh nchar(10),
	tenkh nvarchar(50),
	diachi nvarchar(50),
	primary key (makh)
);
go
create table phieunhap(
	manhap nchar(10),
	ngaynhap date,
	makh nchar(10),
	diengiai nvarchar(50),
	mahh nchar(10),
	sl int,
	primary key (mahh)
);
go
create table phieuxuat(
	maxuat nchar(10),
	ngayxuat date,
	makh nchar(10),
	diengiai nvarchar(50),
	mahh nchar(10),
	sl int,
	primary key (mahh)
);
go
create table kho(
	makho nchar(10),
	tenkho nvarchar(50),
	diachi nvarchar(50),
	primary key (makho)
);
go

--Khóa ngoại
ALTER TABLE phieunhap ADD FOREIGN KEY(mahh) REFERENCES hanghoa(mahh);
ALTER TABLE phieuxuat ADD FOREIGN KEY(mahh) REFERENCES hanghoa(mahh);
ALTER TABLE phieunhap ADD FOREIGN KEY(makh) REFERENCES khachhang(makh);
ALTER TABLE phieuxuat ADD FOREIGN KEY(makh) REFERENCES khachhang(makh);
ALTER TABLE phieunhap ADD FOREIGN KEY(makh) REFERENCES kho(makho);
ALTER TABLE phieuxuat ADD FOREIGN KEY(makh) REFERENCES kho(makho);





