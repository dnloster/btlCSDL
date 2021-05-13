INSERT INTO dbo.BACSI
(
    MABS,
    HOBS,
    TENBS,
    DIACHIBS,
    GTBS,
    NSBS,
    SDTBS
)
VALUES
(   'BS001',        -- MABS - char(10)
    N'Nguyễn Hữu',       -- HOBS - nvarchar(15)
    N'Long',       -- TENBS - nvarchar(15)
    N'Hà Nội',       -- DIACHIBS - nvarchar(40)
    N'Nam',       -- GTBS - nvarchar(10)
    '10-30-2000', -- NSBS - date
    '01015638'         -- SDTBS - char(10)
    )
INSERT INTO dbo.BACSI
(
    MABS,
    HOBS,
    TENBS,
    DIACHIBS,
    GTBS,
    NSBS,
    SDTBS
)
VALUES
	('BS002',N'Trần Quang',N'Thái',N'Thái Bình',N'Nam','05-09-2000','01016067'),
	('BS003',N'Nguyễn Huy',N'Tuân',N'Hà Nam',N'Nam','11-29-2000','01018450'),
	('BS004',N'Trần Tuấn',N'Cường',N'Nam Định',N'Nam','06-08-2000','01031852'),
	('BS005',N'Phạm Tiến',N'Dũng',N'Bắc Ninh',N'Nam','11-12-2000','01031886'),
	('BS006',N'Cao Sông',N'Thao',N'Hải Dương',N'Nam','02-15-2000','01032835'),
	('BS007',N'Đàm Đức',N'Long',N'Bắc Giang',N'Nam','09-02-2000','01036889'),
	('BS008',N'Phạm Huy',N'Hùng',N'Hà Giang',N'Nam','09-26-2000','01040017'),
	('BS009',N'Lương Xuân',N'Hiệp',N'Thanh Hoá',N'Nam','06-09-2000','01041739'),
	('BS010',N'Nguyễn Thành',N'Tuân',N'Hà Nội',N'Nam','05-26-2000','01042875')

INSERT INTO dbo.KHACHHANG
(
    MAKH,
    HOKH,
    TENKH,
    DIACHIKH,
    GTKH,
    NSKH,
    NGUOIBT,
    SDTKH
)
VALUES
(   'KH001',        -- MAKH - char(10)
    N'Đào Minh',       -- HOKH - nvarchar(15)
    N'Hiếu',       -- TENKH - nvarchar(15)
    N'Lào Cai',       -- DIACHIKH - nvarchar(40)
    N'Nam',       -- GTKH - nvarchar(10)
    '03-17-2000', -- NSKH - date
    N'',       -- NGUOIBT - nvarchar(30)
    '01044409'         -- SDTKH - char(10)
    ),

	('KH002',N'Đinh Công',N'Hiển',N'Phú Thọ',N'Nam','03-02-2000',N'','01046854'),
	('KH003',N'Đỗ Minh',N'Hiếu',N'Nghệ An',N'Nam','11-29-2000',N'','01051635'),
	('KH004',N'Nguyễn Hữu',N'Long',N'Đà Nẵng',N'Nam','08-09-2000',N'','01051769'),
	('KH005',N'Nguyễn Đình',N'Phượng',N'Hà Tĩnh',N'Nam','01-31-2000',N'','01051874'),
	('KH006',N'Nguyễn Khánh',N'Châu',N'Nam Định',N'Nam','02-07-2000',N'','01054292'),
	('KH007',N'Tạ Quang',N'Minh',N'Hà Nội',N'Nam','02-26-2000',N'','01056797'),
	('KH008',N'Lê Hữu',N'Trung',N'Phú Thọ',N'Nam','02-28-2000',N'','01057059'),
	('KH009',N'Cao Thái',N'Sơn',N'Cao Bằng',N'Nam','02-27-2000',N'','01059069'),
	('KH010',N'Nguyễn Đức',N'Tài',N'Bắc Ninh',N'Nam','09-14-2000',N'','01059075'),
	('KH011',N'Nguyễn Trung',N'Đức',N'Hà Nam',N'Nam','04-02-2000',N'','01062566'),
	('KH012',N'Bùi Ngọc',N'Đại',N'Thái Bình',N'Nam','06-27-2000',N'','01064609'),
	('KH013',N'Vũ Hoàng',N'Anh',N'Ninh Bình',N'Nam','10-12-2000',N'','01069408'),
	('KH014',N'Vũ Minh',N'Quang',N'Nam Định',N'Nam','09-14-2000',N'','01070220'),
	('KH015',N'Nguyễn Tiến',N'Dũng',N'Phú Thọ',N'Nam','10-29-2000',N'','01071865'),
	('KH016',N'Phạm Tuấn',N'Thành',N'Cao Bằng',N'Nam','12-15-2000',N'','01074839'),
	('KH017',N'Trần Công',N'Duy',N'Hà Nội',N'Nam','09-08-1999',N'','01075689'),
	('KH018',N'Hoàng Anh',N'Quý',N'Thái Bình',N'Nam','08-11-1999',N'','01076383'),
	('KH019',N'Dương Văn',N'Dần',N'Thái Nguyên',N'Nam','06-28-1998',N'','01078369'),
	('KH020',N'Nguyễn Kim',N'Hùng',N'Hà Nội',N'Nam','08-25-1999',N'','01078618')

INSERT INTO dbo.NHANVIEN
(
    MANV,
    HONV,
    TENNV,
    DIACHINV,
    GTNV,
    NSNV,
    SDTNV
)
VALUES
(   'NV001',        -- MANV - char(10)
    N'Nguyễn Văn',       -- HONV - nvarchar(15)
    N'Trung',       -- TENNV - nvarchar(15)
    N'Phú Thọ',       -- DIACHINV - nvarchar(40)
    N'Nam',       -- GTNV - nvarchar(10)
    '08-16-2000', -- NSNV - date
    '02000710'         -- SDTNV - char(10)
    ),

	('NV002',N'Lê Ngọc',N'Long',N'Ninh Bình',N'Nam','07-01-2000','02029210'),
	('NV003',N'Lê Hoài',N'Bắc',N'Thái Bình Bình',N'Nam','08-01-2000','02044275'),
	('NV004',N'Nguyễn Việt',N'Hoàng',N'Nghệ An',N'Nam','01-04-2000','02055716'),
	('NV005',N'Tăng Thành',N'Nhân',N'Hà Tĩnh',N'Nam','09-17-2000','02045419'),
	('NV006',N'Võ Quốc',N'Phong',N'Ninh Bình',N'Nam','10-11-2000','02045544'),
	('NV007',N'Đặng Hồng',N'Phúc',N'Nam Định',N'Nam','01-29-2000','02045556'),
	('NV008',N'Vũ Ngọc',N'Thái',N'Bắc Ninh',N'Nam','05-20-2000','02045771'),
	('NV009',N'Nguyễn Văn',N'Trọng',N'Bắc Giang',N'Nam','01-29-2000','03006782'),
	('NV010',N'Nguyễn Tiến',N'Dũng',N'Quảng Ninh',N'Nam','02-22-2000','03009148')

INSERT INTO dbo.KHO
(
    MAKHO,
    SUCCHUA
)
VALUES
(   'K01', -- MAKHO - char(10)
    200  -- SUCCHUA - int
    ),
	('K02',200),
	('K03',200),
	('K04',200),
	('K05',200)

INSERT INTO dbo.LOAIVACCIN
(
    MALOAIVC,
    CHUNGLOAI,
    CONGDUNG,
    MAKHO
)
VALUES
(   'LVC001',  -- MALOAIVC - char(15)
    N'Vắc xin phòng Lao', -- CHUNGLOAI - nvarchar(20)
    N'Phòng ngừa các hình thái lao nguy hiểm', -- CONGDUNG - nvarchar(40)
    'K01'   -- MAKHO - char(10)
),
	('LVC002',N'Vắc xin phòng Viêm gan B',N'Ngăn ngừa bệnh viêm gan B và các hậu quả như xơ gan, ung thư gan','K02'),
	('LVC003',N'Vắc xin phòng thủy đậu',N' Tạo miễn dịch chủ động, phòng ngừa bệnh thủy đậu','K03'),
	('LVC004',N'Vắc xin phòng cúm',N'kích thích cơ thể sinh đáp ứng miễn dịch, tạo ra các kháng thể phòng cúm','K04'),
	('LVC005',N'Vắc xin phòng dại',N' Phòng ngừa ở các đối tượng có nguy cơ phơi nhiễm virus dại cao','K05')

INSERT INTO dbo.VACCIN
(
    MAVC,
    TENVC,
    DONGIA,
    DONVITINH,
    NUOCSX,
    NSX,
    HSD,
    SLTK,
    MALOAIVC
)
VALUES
('VC101',N'BCG',125000,1,N'Việt Nam','05-12-2021','05-12-2022',50,'LVC001'),
('VC102',N'Euvax B',116000,0.5,N'Hàn Quốc','05-12-2021','05-12-2022',60,'LVC002'),
('VC202',N'Engerix B',190000,0.5,N'Bỉ','05-12-2021','05-12-2022',100,'LVC002'),
('VC302',N'Hepavax Gene',145000,0.5,N'Hàn Quốc','05-12-2021','05-12-2022',70,'LVC002'),
('VC103',N'Varivax',915000,1,N'Mỹ','05-12-2021','05-12-2022',50,'LVC003'),
('VC203',N'Varilrix',945000,1,N'Bỉ','05-12-2021','05-12-2022',30,'LVC003'),
('VC303',N'Varicella',700000,1,N'Hàn Quốc','05-12-2021','05-12-2023',50,'LVC003'),
('VC104',N'Vaxigrip',305000,0.25,N'Pháp','05-12-2021','05-12-2023',100,'LVC004'),
('VC204',N'Influvac',348000,0.5,N'Hà Lan','05-12-2021','05-12-2022',50,'LVC004'),
('VC304',N'GC Flu',240000,0.5,N'Hàn Quốc','05-12-2021','05-12-2022',100,'LVC004'),
('VC404',N'Ivacflu-S',190000,0.5,N'Việt Nam','05-12-2021','05-12-2022',50,'LVC004'),
('VC105',N'Verorab',323000,0.5,N'Pháp','05-12-2021','05-12-2022',100,'LVC005'),
('VC205',N'Abhayrab TB',255000,0.5,N'Ấn Độ','05-12-2021','05-12-2022',70,'LVC005'),
('VC305',N'Abhayrab TTD',215000,0.2,N'Ấn Độ','05-12-2021','05-12-2022',70,'LVC005')


INSERT INTO dbo.HOADON
(
    MAHD,
    TONGTIEN,
    NGAYTT,
    MAPT
)
VALUES
('HD001',1250000,'2021-02-22','PT001'),
('HD002',520000,'2021-03-23','PT002'),
('HD003',250000,'2021-03-24','PT003'),
('HD004',750000,'2021-01-24','PT004'),
('HD005',750000,'2021-02-22','PT005')

INSERT INTO dbo.PHIEUKTSK
(
    MAPHIEUKTSK,
    NGAYKT,
    NOIDUNG,
    MAKH,
	MABS
)
VALUES
('KT001', '2021-02-22', 'Kiểm tra tim mạch', 'KH001', 'BS001'),
('KT002', '2021-02-22', 'Kiểm tra huyết áp', 'KH002', 'BS002'),
('KT003', '2021-02-22', 'Kiểm tra hệ thống miễn dịch', 'KH003', 'BS003'),
('KT004', '2021-02-22', 'Kiểm tra hệ thần kinh', 'KH004', 'BS004'),
('KT005', '2021-02-22', 'Kiểm tra máu', 'KH005', 'BS005')
