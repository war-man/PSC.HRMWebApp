﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="HRMChamCong.Views.HoSoNhanSu.Manage" %>
<%@ Import Namespace="HRMChamCong.Helper" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link href="/CSS/hrmmain.css" rel="stylesheet" />
    <style type="text/css">
        .boldText {
            font-weight: bold;
        }

        .textToCenter {
            text-align: center;
        }

        .textToRight {
            text-align: right;
        }

        .backGroundTitle {
            background: #DCDCDC;
        }
    </style>
    
    <script type="text/javascript">
        function formatDate(date) {
            return date.getDate() + "/" + parseInt(date.getMonth() + 1) + "/" + date.getFullYear();
        }
        function ViewModel_GiayToHoSo() {
            var self = this;
            self.giayToHoSoList = ko.observableArray();
            self.giayToDirectory = ko.observable('');
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/GiayToHoSo_GetList_ByNhanVienId',
                async: false,
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({
                    nhanVienId: '<%#HttpContext.Current.Session[SessionKey.ThongTinNhanVien.ToString()]%>'
                }),
                dataType: "json",
                success: function (result) {
                    var data = $.parseJSON(result.d);
                    self.giayToHoSoList(data);
                }
            });
            var source_giayToHoSo =
            {
                datatype: "json",
                datafields: [
                    { name: 'Oid', type: 'string' },
                    { name: 'TenDangLuuTru', type: 'string' },
                    { name: 'SoGiayTo', type: 'string' },
                    { name: 'NgayBanHanh', type: 'date' },
                    { name: 'SoBanTrichYeu', type: 'int' },
                    { name: 'LuuTru', type: 'string' },
					{ name: 'Giay_To', type: 'string' }
                ],
                id: 'Oid',
                localdata: self.giayToHoSoList()
            };
            var dataAdapter_giayToHoSo = new $.jqx.dataAdapter(source_giayToHoSo);
            $("#giayToHoSoGrid").jqxGrid(
                {
                    source: dataAdapter_giayToHoSo,
                    width: '100%',
                    pageable: true,
                    pagesize: 5,
                    filterable: true,
                    sortable: true,
                    autorowheight: true,
                    autoheight: true,
                    theme: "darkBlue",
                    columns: [
                        {
                            text: 'STT',
                            columntype: 'number',
                            width: 35,
                            editable: false,
                            cellsrenderer: function (row, column, value) {
                                return "<div style='text-align:center;margin-top:5px;'>" + (value + 1) + "</div>";
                            }
                        },
						{
						    text: 'Lưu trữ', datafield: 'LuuTru', width: 205, align: 'center', cellsalign: "middle"
						},
                        {
                            text: 'Dạng lưu trữ', datafield: 'TenDangLuuTru', width: 150, align: 'center', cellsalign: "middle"
                        }, {
                            text: 'Giấy tờ', datafield: 'Giay_To', width: 160, align: 'center', cellsalign: "middle"
                        },
                        {
                            text: 'Số giấy tờ', datafield: 'SoGiayTo', width: 100, align: 'center', cellsalign: "middle"
                        },
                        {
                            text: 'Ngày ban hành', datafield: 'NgayBanHanh', cellsformat: 'd/M/yyyy', width: 150, align: 'center', cellsalign: "middle"
                        },
                        {
                            text: 'Số bản trích yếu', datafield: 'SoBanTrichYeu', width: 120, align: 'center', cellsalign: "middle"
                        }

                    ]
                });
            $("#giayToHoSoGrid").on('rowselect', function (event) {
                $("#outerContainer").show();
                var row = $("#giayToHoSoGrid").jqxGrid('getrowdata', event.args.rowindex);
                self.giayToDirectory('<%#System.Configuration.ConfigurationManager.AppSettings["HoSoGiayToPath"]%>' + row.LuuTru);
            });

        }
        
        function ViewModel_HopDongLaoDong() {
            var self = this;
            self.BacLuong = "";
            self.ChucDanhChuyenMon = "";
            self.ChucVuNguoiKy = "";
            self.DenNgay = null;
            self.HeSoLuong = "";
            self.LoaiHopDong = "";
            self.MaNgachLuong = "";
            self.MucLuongDuocHuong = "";
            self.NgayKy = null;
            self.NguoiKy = "";
            self.SoHopDong = "";
            self.TenNgachLuong = "";
            self.TuNgay = null;
            self.DanhSach_HopDongDaKy = ko.observableArray();
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/ModuleThongTinNhanSu_HOPDONGLAODONG',
                async: false,
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({
                    webUserId: '<%#HttpContext.Current.Session[SessionKey.ThongTinNhanVien.ToString()]%>'
                }),
                dataType: "json",
                success: function (result) {
                    var data = $.parseJSON(result.d);
                    if (data.HopDong != null) {
                        self.BacLuong = data.HopDong.BacLuong;
                        self.ChucDanhChuyenMon = data.HopDong.ChucDanhChuyenMon;
                        self.ChucVuNguoiKy = data.HopDong.ChucVuNguoiKy;
                        self.DenNgay = data.HopDong.DenNgay;
                        self.HeSoLuong = data.HopDong.HeSoLuong;
                        self.LoaiHopDong = data.HopDong.LoaiHopDong;
                        self.MaNgachLuong = data.HopDong.MaNgachLuong;
                        self.MucLuongDuocHuong = data.HopDong.MucLuongDuocHuong;
                        self.NgayKy = data.HopDong.NgayKy;
                        self.NguoiKy = data.HopDong.NguoiKy;
                        self.SoHopDong = data.HopDong.SoHopDong;
                        self.TenNgachLuong = data.HopDong.TenNgachLuong;
                        self.TuNgay = data.HopDong.TuNgay;
                    }
                    self.DanhSach_HopDongDaKy(data.DanhSach_HopDongDaKy);

                }
            });
        }
        
        function ViewModel_QuanHeGiaDinh() {
            var self = this;
            self.DanhSach_QuanHeGiaDinh = ko.observableArray();
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/ModuleThongTinNhanSu_QuanHeGiaDinh',
                async: false,
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({
                    webUserId: '<%#HttpContext.Current.Session[SessionKey.ThongTinNhanVien.ToString()]%>'
                }),
                dataType: "json",
                success: function (result) {
                    var data = $.parseJSON(result.d);
                    self.DanhSach_QuanHeGiaDinh(data);

                }
            });
        }
        
        function ViewModel_SoYeuLyLich() {
            var self = this;
            self.CanNang = "";
            self.ChieuCao = "";
            self.ChucDanh = "";
            self.ChucVuCaoNhatDaQua = "";
            self.ChucVuHienTai = "";
            self.ChucVuKiemNhiem = "";
            self.CongViecHienNay = "";
            self.CongViecTuyenDung = "";
            self.DanToc = "";
            self.DiaChiThuongTru = "";
            self.DienThoaiDiDong = "";
            self.DienThoaiNha = "";
            self.DonViCongTac = "";
            self.DonViTuyenDung = "";
            self.Email = "";
            self.GioiTinh = "";
            self.HinhThucTuyenDung = "";
            self.HoTen = "";
            self.LoaiCanBo = "";
            self.NgayBoNhiem = "";
            self.NgayCap = "";
            self.NgaySinh = "";
            self.NgayTuyenDung = "";
            self.NgayVaoCoQuanHienNay = "";
            self.NgayVaoNganhGiaoDuc = "";
            self.NhomMau = "";
            self.NoiCap = "";
            self.NoiOHienNay = "";
            self.NoiSinh = "";
            self.QueQuan = "";
            self.QuocTich = "";
            self.SoCMND = "";
            self.SoHieuCongChuc = "";
            self.TenGoiKhac = "";
            self.ThanhPhanXuatThan = "";
            self.TinhTrangHonNhan = "";
            self.TinhTrangSucKhoe = "";
            self.TonGiao = "";
            self.UuTienBanThan = "";
            self.UuTienGiaDinh = "";
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/ThongTinNhanSu_SoYeuLyLich_Json',
                async: false,
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({
                    webUserId: '<%#HttpContext.Current.Session[SessionKey.ThongTinNhanVien.ToString()]%>'
                }),
                dataType: "json",
                success: function (result) {
                    var data = $.parseJSON(result.d);
                    self.CanNang = data.CanNang;
                    self.ChieuCao = data.ChieuCao;
                    self.ChucDanh = data.ChucDanh;
                    self.ChucVuCaoNhatDaQua = data.ChucVuCaoNhatDaQua;
                    self.ChucVuHienTai = data.ChucVuHienTai;
                    self.ChucVuKiemNhiem = data.ChucVuKiemNhiem;
                    self.CongViecHienNay = data.CongViecHienNay;
                    self.CongViecTuyenDung = data.CongViecTuyenDung;
                    self.DanToc = data.DanToc;
                    self.DiaChiThuongTru = data.DiaChiThuongTru;
                    self.DienThoaiDiDong = data.DienThoaiDiDong;
                    self.DienThoaiNha = data.DienThoaiNha;
                    self.DonViCongTac = data.DonViCongTac;
                    self.DonViTuyenDung = data.DonViTuyenDung;
                    self.Email = data.Email;
                    self.GioiTinh = data.GioiTinh;
                    self.HinhThucTuyenDung = data.HinhThucTuyenDung;
                    self.HoTen = data.HoTen;
                    self.LoaiCanBo = data.LoaiCanBo;
                    self.NgayBoNhiem = data.NgayBoNhiem;
                    self.NgayCap = data.NgayCap;
                    self.NgaySinh = data.NgaySinh;
                    self.NgayTuyenDung = data.NgayTuyenDung;
                    self.NgayVaoCoQuanHienNay = data.NgayVaoCoQuanHienNay;
                    self.NgayVaoNganhGiaoDuc = data.NgayVaoNganhGiaoDuc;
                    self.NhomMau = data.NhomMau;
                    self.NoiCap = data.NoiCap;
                    self.NoiOHienNay = data.NoiOHienNay;
                    self.NoiSinh = data.NoiSinh;
                    self.QueQuan = data.QueQuan;
                    self.QuocTich = data.QuocTich;
                    self.SoCMND = data.SoCMND;
                    self.SoHieuCongChuc = data.SoHieuCongChuc;
                    self.TenGoiKhac = data.TenGoiKhac;
                    self.ThanhPhanXuatThan = data.ThanhPhanXuatThan;
                    self.TinhTrangHonNhan = data.TinhTrangHonNhan;
                    self.TinhTrangSucKhoe = data.TinhTrangSucKhoe;
                    self.TonGiao = data.TonGiao;
                    self.UuTienBanThan = data.UuTienBanThan;
                    self.UuTienGiaDinh = data.UuTienGiaDinh;
                    self.NoiCap = data.NoiCap;
                    self.HopDongHienTai = data.HopDongHienTai;
                }
            });
        }
        
        function ViewModel_ThongTinLuong() {
            var self = this;
            self.BacLuong = "";
            self.CoQuanThue = "";
            self.DuocHuongHSPCChuyenVien = "";
            self.HSPCChucVu = "";
            self.HSPCChuyenMon = "";
            self.HSPCDocHai = "";
            self.HSPCKhac = "";
            self.HSPCKiemNhiem = "";
            self.HSPCKiemNhiemTrongTruong = "";
            self.HSPCLanhDao = "";
            self.HSPCLuuDong = "";
            self.HSPCThamNien = "";
            self.HSPCThamNienTruong = "";
            self.HSPCTrachNhiem = "";
            self.HSPCUuDai = "";
            self.HSPCVuotKhung = "";
            self.HeSoLuong = "";
            self.HeSoPhuCapTrachNhiem = "";
            self.LoaiCuTru = "";
            self.MaNgach = "";
            self.MaSoThue = "";
            self.MocNangLuong = "";
            self.MucLuongDuocHuong = "";
            self.NgayBoNhiemNgach = "";
            self.NgayHuongHSPCChucVu = "";
            self.NgayHuongHSPCChuyenMon = "";
            self.NgayHuongHSPCThamNien = "";
            self.NgayHuongHSPCTracNhiem = "";
            self.NgayHuongLuong = "";
            self.NhomNgachLuong = "";
            self.PCDacBiet = "";
            self.PCDacThu = "";
            self.PCThuHut = "";
            self.PhanTramUuDai = "";
            self.SoNguoiPhuThuoc = "";
            self.SoThangGiamTru = "";
            self.TenNgach = "";
            self.ThamNien = "";
            self.VuotKhung = "";
            self.DanhSach_TaiKhoanNganHang = ko.observableArray();
            self.DanhSach_NguoiPhuThuoc = ko.observableArray();
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/ThongTinNhanSu_THONGTINLUONGNHANVIEN',
                async: false,
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({
                    webUserId: '<%#HttpContext.Current.Session[SessionKey.ThongTinNhanVien.ToString()]%>'
                }),
                dataType: "json",
                success: function (result) {
                    var data = $.parseJSON(result.d);
                    if (data.ThongTinLuong != null) {
                        self.BacLuong = data.ThongTinLuong.BacLuong;
                        self.CoQuanThue = data.ThongTinLuong.CoQuanThue;
                        self.DuocHuongHSPCChuyenVien = data.ThongTinLuong.DuocHuongHSPCChuyenVien;
                        self.HSPCChucVu = data.ThongTinLuong.HSPCChucVu;
                        self.HSPCChuyenMon = data.ThongTinLuong.HSPCChuyenMon;
                        self.HSPCDocHai = data.ThongTinLuong.HSPCDocHai;
                        self.HSPCKhac = data.ThongTinLuong.HSPCKhac;
                        self.HSPCKiemNhiem = data.ThongTinLuong.HSPCKiemNhiem;
                        self.HSPCKiemNhiemTrongTruong = data.ThongTinLuong.HSPCKiemNhiemTrongTruong;
                        self.HSPCLanhDao = data.ThongTinLuong.HSPCLanhDao;
                        self.HSPCLuuDong = data.ThongTinLuong.HSPCLuuDong;
                        self.HSPCThamNien = data.ThongTinLuong.HSPCThamNien;
                        self.HSPCThamNienTruong = data.ThongTinLuong.HSPCThamNienTruong;
                        self.HSPCTrachNhiem = data.ThongTinLuong.HSPCTrachNhiem;
                        self.HSPCUuDai = data.ThongTinLuong.HSPCUuDai;
                        self.HSPCVuotKhung = data.ThongTinLuong.HSPCVuotKhung;
                        self.HeSoLuong = data.ThongTinLuong.HeSoLuong;
                        self.HeSoPhuCapTrachNhiem = data.ThongTinLuong.HeSoPhuCapTrachNhiem;
                        self.LoaiCuTru = data.ThongTinLuong.LoaiCuTru;
                        self.MaNgach = data.ThongTinLuong.MaNgach;
                        self.MaSoThue = data.ThongTinLuong.MaSoThue;
                        self.MocNangLuong = data.ThongTinLuong.MocNangLuong;
                        self.MucLuongDuocHuong = data.ThongTinLuong.MucLuongDuocHuong;
                        self.NgayBoNhiemNgach = data.ThongTinLuong.NgayBoNhiemNgach;
                        self.NgayHuongHSPCChucVu = data.ThongTinLuong.NgayHuongHSPCChucVu;
                        self.NgayHuongHSPCChuyenMon = data.ThongTinLuong.NgayHuongHSPCChuyenMon;
                        self.NgayHuongHSPCThamNien = data.ThongTinLuong.NgayHuongHSPCThamNien;
                        self.NgayHuongHSPCTracNhiem = data.ThongTinLuong.NgayHuongHSPCTracNhiem;
                        self.NgayHuongLuong = data.ThongTinLuong.NgayHuongLuong;
                        self.NhomNgachLuong = data.ThongTinLuong.NhomNgachLuong;
                        self.PCDacBiet = data.ThongTinLuong.PCDacBiet;
                        self.PCDacThu = data.ThongTinLuong.PCDacThu;
                        self.PCThuHut = data.ThongTinLuong.PCThuHut;
                        self.PhanTramUuDai = data.ThongTinLuong.PhanTramUuDai;
                        self.SoNguoiPhuThuoc = data.ThongTinLuong.SoNguoiPhuThuoc;
                        self.SoThangGiamTru = data.ThongTinLuong.SoThangGiamTru;
                        self.TenNgach = data.ThongTinLuong.TenNgach;
                        self.ThamNien = data.ThongTinLuong.ThamNien;
                        self.VuotKhung = data.ThongTinLuong.VuotKhung;
                        self.MocNangLuongLanSau = data.MocNangLuongLanSau;
                    }
                    self.DanhSach_TaiKhoanNganHang(data.DanhSach_TaiKhoanNganHang);
                    self.DanhSach_NguoiPhuThuoc(data.DanhSach_NguoiPhuThuoc);
                }
            });
        }

        function ViewModel_TrinhDoChuyenMon() {
            var self = this;
            self.ChuyenNganhDaoTao = "";
            self.DangTheoHoc = "";
            self.HinhThucDaoTao = "";
            self.HocHam = "";
            self.LyLuanChinhTri = "";
            self.NamCongNhan = "";
            self.NamTotNghiep = "";
            self.NgoaiNguChinh = "";
            self.QuanLyGiaoDuc = "";
            self.QuanLyKinhTe = "";
            self.QuanLyNhaNuoc = "";
            self.TrinhDoChuyenMonCaoNhat = "";
            self.TrinhDoHocVan = "";
            self.TrinhDoNgoaiNguChinh = "";
            self.TrinhDoTinHoc = "";
            self.TruongDaoTao = "";
            self.DanhSach_ChungChi = ko.observableArray();
            self.DanhSach_NgoaiNgu = ko.observableArray();
            self.DanhSach_VanBang = ko.observableArray();
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/ModuleThongTinNhanSu_TRINHDOCHUYENMONNHANVIEN',
                async: false,
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({
                    webUserId: '<%#HttpContext.Current.Session[SessionKey.ThongTinNhanVien.ToString()]%>'
                }),
                dataType: "json",
                success: function (result) {
                    var data = $.parseJSON(result.d);
                    if (data.TrinhDoChuyenMon != null) {
                        self.ChuyenNganhDaoTao = data.TrinhDoChuyenMon.ChuyenNganhDaoTao;
                        self.DangTheoHoc = data.TrinhDoChuyenMon.DangTheoHoc;
                        self.HinhThucDaoTao = data.TrinhDoChuyenMon.HinhThucDaoTao;
                        self.HocHam = data.TrinhDoChuyenMon.HocHam;
                        self.LyLuanChinhTri = data.TrinhDoChuyenMon.LyLuanChinhTri;
                        self.NamCongNhan = data.TrinhDoChuyenMon.NamCongNhan;
                        self.NamTotNghiep = data.TrinhDoChuyenMon.NamTotNghiep;
                        self.NgoaiNguChinh = data.TrinhDoChuyenMon.NgoaiNguChinh;
                        self.QuanLyGiaoDuc = data.TrinhDoChuyenMon.QuanLyGiaoDuc;
                        self.QuanLyKinhTe = data.TrinhDoChuyenMon.QuanLyKinhTe;
                        self.QuanLyNhaNuoc = data.TrinhDoChuyenMon.QuanLyNhaNuoc;
                        self.TrinhDoChuyenMonCaoNhat = data.TrinhDoChuyenMon.TrinhDoChuyenMonCaoNhat;
                        self.TrinhDoHocVan = data.TrinhDoChuyenMon.TrinhDoHocVan;
                        self.TrinhDoNgoaiNguChinh = data.TrinhDoChuyenMon.TrinhDoNgoaiNguChinh;
                        self.TrinhDoTinHoc = data.TrinhDoChuyenMon.TrinhDoTinHoc;
                        self.TruongDaoTao = data.TrinhDoChuyenMon.TruongDaoTao;
                        self.NamTotNghiep = data.NamTotNghiep;
                    }
                    self.DanhSach_ChungChi(data.DanhSach_ChungChi);
                    self.DanhSach_NgoaiNgu(data.DanhSach_NgoaiNgu);
                    self.DanhSach_VanBang(data.DanhSach_VanBang);
                }
            });
        }


        function LoadMenuTab() {
            var self = this;
            self.menuList = ko.observableArray();
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/WebMenu_GetChildMenuListBy_WebUserId_AndMenuId',
                async: false,
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({
                    webUserId: '<%#HttpContext.Current.Session[SessionKey.UserId.ToString()]%>',
                    menuId: '<%#HttpContext.Current.Request.QueryString["Id"]%>',
                }),
                dataType: "json",
                success: function (result) {
                    var obj = $.parseJSON(result.d);
                    $(obj).each(function (index, value) {
                        value.tabId = value.Url.split("/")[3].split(".")[0];
                    });
                    self.menuList(obj);

                }
            });
        }

        $(document).ready(function () {
            var menuTab = new LoadMenuTab();
            ko.applyBindings(menuTab, $('#jqxTabs_MenuList_HoSoNhanSu')[0]);
            $('#jqxTabs_MenuList_HoSoNhanSu').jqxTabs({ width: '100%', theme: 'darkBlue', scrollStep: 500 });
            var loadPage = function (url, tabIndex, value) {
                $.get(url, function (data) {
                    $('#' + value).html(data);
                    ko.cleanNode($('#' + value)[0]);
                    ko.applyBindings(new window["ViewModel_" + value](), document.getElementById(value));
                });
            };            
            loadPage(menuTab.menuList()[0].Url, 1, menuTab.menuList()[0].Url.split('/')[3].split('.')[0]);
            $('#jqxTabs_MenuList_HoSoNhanSu').on('selected', function (event) {
                var pageIndex = event.args.item;
                var contentDiv = $("#jqxTabs_MenuList_HoSoNhanSu .jqx-tabs-content-element")[pageIndex];
                if (contentDiv.id == '')
                    return;
                loadPage('/Views/HoSoNhanSu/' + contentDiv.id + '.aspx', pageIndex, contentDiv.id);
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id='jqxTabs_MenuList_HoSoNhanSu'>
        <ul >
             <!-- ko foreach:menuList -->
             <li data-bind="text: Name" style="margin-left: 5px;"></li>
             <!-- /ko -->
   
        </ul>
        <!-- ko foreach:menuList -->
            <div data-bind="attr: { id: $data.tabId }" style="padding: 10px 10px;"></div>
        <!-- /ko -->
     
    </div>

</asp:Content>
