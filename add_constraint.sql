ALTER TABLE dbo.VACCIN ADD 
	CONSTRAINT VC_LVC_FK FOREIGN KEY (MALOAIVC) REFERENCES dbo.LOAIVACCIN(MALOAIVC)

ALTER TABLE dbo.LOAIVACCIN ADD
	CONSTRAINT LVC_KHO_FK FOREIGN KEY (MAKHO) REFERENCES dbo.KHO(MAKHO)

ALTER TABLE dbo.CHITIET_PN ADD
	CONSTRAINT CHITIETPN_PK PRIMARY KEY (MAVC,MAPN),
	CONSTRAINT CTPN_PN_FK FOREIGN KEY (MAPN) REFERENCES dbo.PHIEUNHAP(MAPN),
	CONSTRAINT CTPN_VC_FK FOREIGN KEY (MAVC) REFERENCES dbo.VACCIN(MAVC)

ALTER TABLE dbo.LUOTDUNG ADD
	CONSTRAINT LUOTDUNG_PK PRIMARY KEY (MAPT,MAVC),
	CONSTRAINT LD_PT_FK FOREIGN KEY (MAPT) REFERENCES dbo.PHIEUTIEM(MAPT),
	CONSTRAINT LD_VC_FK FOREIGN KEY (MAVC) REFERENCES dbo.VACCIN(MAVC)

ALTER TABLE dbo.PHIEUKTSK ADD
	CONSTRAINT PKTSK_BS_FK FOREIGN KEY (MABS) REFERENCES dbo.BACSI(MABS),
	CONSTRAINT PKTSK_KH_FK FOREIGN KEY (MAKH) REFERENCES dbo.KHACHHANG(MAKH)

ALTER TABLE dbo.PHIEUTIEM ADD
	CONSTRAINT PT_NV_FK FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN(MANV),
	CONSTRAINT PT_KH_FK FOREIGN KEY (MAKH) REFERENCES dbo.KHACHHANG(MAKH)

ALTER TABLE dbo.HOADON ADD
	CONSTRAINT HD_PT_FK FOREIGN KEY (MAPT) REFERENCES dbo.PHIEUTIEM(MAPT)

ALTER TABLE dbo.PHIEUNHAP ADD
	CONSTRAINT PN_NV_FK FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN(MANV)