﻿
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
//	  Code duoc tao boi DESKTOP-PKPRC2J\NGOCBAO luc 08:39:16 ngay 09/07/2016
// </auto-generated>
//------------------------------------------------------------------------------

//using System.Data.Objects.DataClasses;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.Metadata.Edm;
[assembly: EdmSchemaAttribute()]

#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("ERPModel", "FK_BoPhan_BoPhanCha", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.BoPhan), "BoPhan1", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.BoPhan), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_WebUser_BoPhan_BoPhan", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(HRMWeb_Business.Model.BoPhan), "WebUser_BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.WebUser_BoPhan), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_WebMenu_Role_webRole", "WebGroup", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(HRMWeb_Business.Model.WebGroup), "WebMenu_Role", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.WebMenu_Role), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_WebMenu_Role_WebMenu1", "WebMenu", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(HRMWeb_Business.Model.WebMenu), "WebMenu_Role", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.WebMenu_Role), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_WebMenu_WebMenu", "WebMenu", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.WebMenu), "WebMenu1", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.WebMenu), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_KyTinhLuong_BangChotThongTinTinhLuong", "BangChotThongTinTinhLuong", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.BangChotThongTinTinhLuong), "KyTinhLuong", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.KyTinhLuong), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_BangLuongNhanVien_KyTinhLuong", "KyTinhLuong", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.KyTinhLuong), "BangLuongNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.BangLuongNhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_GiayToHoSo_DangLuuTru", "DangLuuTru", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.DangLuuTru), "GiayToHoSo", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.GiayToHoSo), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_GiayToHoSo_HoSo", "HoSo", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.HoSo), "GiayToHoSo", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.GiayToHoSo), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_GiayToHoSo_GiayTo", "GiayTo", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.GiayTo), "GiayToHoSo", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.GiayToHoSo), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_BoPhan_BoPhanChaOld", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.BoPhan), "BoPhan1", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.BoPhan), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_cc_QuanLyViPham_cc_HinhThucViPham", "CC_HinhThucViPham", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.CC_HinhThucViPham), "CC_QuanLyViPham", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_QuanLyViPham), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_QuanLyChamCongNhanVien_KyTinhLuong", "KyTinhLuong", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.KyTinhLuong), "QuanLyChamCongNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.QuanLyChamCongNhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_ThongTinNhanVien_TaiBoMon", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.BoPhan), "ThongTinNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.ThongTinNhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_ThongTinNhanVien_LoaiNhanSu", "LoaiNhanSu", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.LoaiNhanSu), "ThongTinNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.ThongTinNhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_KhaiBaoChamCongGiangVien_ThongTinNhanVien", "ThongTinNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.ThongTinNhanVien), "CC_KhaiBaoChamCongGiangVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_KhaiBaoChamCongGiangVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_KhaiBaoCongTac_HoSo", "HoSo", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(HRMWeb_Business.Model.HoSo), "CC_KhaiBaoCongTac", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_KhaiBaoCongTac), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_ChiTietChamCongNhanVien_BoPhan", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.BoPhan), "ChiTietChamCongNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.ChiTietChamCongNhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_DangKyChamCongNgoaiGio_CC_LyDoDangKyChamCongNgoaiGio", "CC_LyDoDangKyChamCongNgoaiGio", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.CC_LyDoDangKyChamCongNgoaiGio), "CC_DangKyChamCongNgoaiGio", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_DangKyChamCongNgoaiGio), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_DangKyChamCongNgoaiGio_ThongTinNhanVien", "ThongTinNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.ThongTinNhanVien), "CC_DangKyChamCongNgoaiGio", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_DangKyChamCongNgoaiGio), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_ChiTietChamCongNhanVien_QuanLyChamCongNhanVien", "QuanLyChamCongNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.QuanLyChamCongNhanVien), "ChiTietChamCongNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.ChiTietChamCongNhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_ChiTietChamCongNhanVien_ThongTinNhanVien", "ThongTinNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.ThongTinNhanVien), "ChiTietChamCongNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.ChiTietChamCongNhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_NhanVien_BoPhan", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.BoPhan), "NhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.NhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_NhanVien_BoPhanCu", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.BoPhan), "NhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.NhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_NhanVien_BoPhanTinhLuong", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.BoPhan), "NhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.NhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_NhanVien_Oid", "HoSo", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(HRMWeb_Business.Model.HoSo), "NhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.NhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_NhanVien_TinhTrang", "TinhTrang", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.TinhTrang), "NhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.NhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_ThongTinNhanVien_Oid", "NhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(HRMWeb_Business.Model.NhanVien), "ThongTinNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.ThongTinNhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_ChamCongTheoNgay_BoPhan", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(HRMWeb_Business.Model.BoPhan), "CC_ChamCongTheoNgay", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_ChamCongTheoNgay), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_ChamCongTheoNgay_CC_CaChamCong", "CC_CaChamCong", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.CC_CaChamCong), "CC_ChamCongTheoNgay", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_ChamCongTheoNgay), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_ChamCongTheoNgay_HinhThucNghi", "HinhThucNghi", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.HinhThucNghi), "CC_ChamCongTheoNgay", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_ChamCongTheoNgay), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_ChamCongTheoNgay_HoSo", "HoSo", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(HRMWeb_Business.Model.HoSo), "CC_ChamCongTheoNgay", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_ChamCongTheoNgay), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_cc_QuanLyViPham_CC_ChamCongTheoNgay", "CC_ChamCongTheoNgay", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.CC_ChamCongTheoNgay), "CC_QuanLyViPham", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_QuanLyViPham), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_DangKyKhungGioLamViec_CC_CaChamCong", "CC_CaChamCong", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.CC_CaChamCong), "CC_DangKyKhungGioLamViec", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_DangKyKhungGioLamViec), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_DangKyKhungGioLamViec_CC_KyDangKyKhungGio", "CC_KyDangKyKhungGio", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.CC_KyDangKyKhungGio), "CC_DangKyKhungGioLamViec", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_DangKyKhungGioLamViec), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_DangKyKhungGioLamViec_ThongTinNhanVien", "ThongTinNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.ThongTinNhanVien), "CC_DangKyKhungGioLamViec", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_DangKyKhungGioLamViec), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_NhanVien_ChucDanh", "ChucDanh", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.ChucDanh), "NhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.NhanVien), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_ChamCongNgayNghi_IDBoPhan", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.BoPhan), "CC_ChamCongNgayNghi", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_ChamCongNgayNghi), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_ChamCongNgayNghi_IDHinhThucNghi", "HinhThucNghi", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.HinhThucNghi), "CC_ChamCongNgayNghi", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_ChamCongNgayNghi), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_ChamCongNgayNghi_IDNhanVien", "ThongTinNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.ThongTinNhanVien), "CC_ChamCongNgayNghi", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_ChamCongNgayNghi), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_ThongTinNghiPhep_BoPhan", "BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.BoPhan), "ThongTinNghiPhep", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.ThongTinNghiPhep), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_ChiTietNghiPhep_ThongTinNghiPhep", "ThongTinNghiPhep", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.ThongTinNghiPhep), "ChiTietNghiPhep", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.ChiTietNghiPhep), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_ThongTinNghiPhep_QuanLyNghiPhep", "QuanLyNghiPhep", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.QuanLyNghiPhep), "ThongTinNghiPhep", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.ThongTinNghiPhep), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_ThongTinNghiPhep_ThongTinNhanVien", "ThongTinNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.ThongTinNhanVien), "ThongTinNghiPhep", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.ThongTinNghiPhep), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_NgayNghiTrongNam_QuanLyNgayNghiTrongNam", "QuanLyNgayNghiTrongNam", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.QuanLyNgayNghiTrongNam), "NgayNghiTrongNam", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.NgayNghiTrongNam), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_CC_ChamCongNgayNghi_IDWebUsers", "WebUser", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.WebUser), "CC_ChamCongNgayNghi", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.CC_ChamCongNgayNghi), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_WebUsers_HoSo", "HoSo", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.HoSo), "WebUser", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.WebUser), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_WebUsers_ThongTinNhanVien", "ThongTinNhanVien", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.ThongTinNhanVien), "WebUser", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.WebUser), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_WebUsers_WebGroup", "WebGroup", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HRMWeb_Business.Model.WebGroup), "WebUser", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.WebUser), true)]
[assembly: EdmRelationshipAttribute("ERPModel", "FK_WebUser_BoPhan_WebUsers", "WebUser", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One, typeof(HRMWeb_Business.Model.WebUser), "WebUser_BoPhan", System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HRMWeb_Business.Model.WebUser_BoPhan), true)]

#endregion

