﻿<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="ThongTinLuong.aspx.cs" Inherits="HRMChamCong.Views.HoSoNhanSu.ThongTinLuong" %>

<html>
<head></head>
<body>
    <div id="HoSo_ThongTinLuong">
        <h3 style="font-weight: bold; color: #333">Thông tin lương</h3>
        <div class="hrm_clear">
        </div>
        <div class="hrm_content">
            <div class="hrm_box">
                <div class="hrm_left">
                    Mã ngạch lương:
                </div>
                <div class="hrm_right"
                    data-bind="text: MaNgach">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Tên ngạch lương:
                </div>
                <div class="hrm_right"
                    data-bind="text: TenNgach">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Nhóm ngạch lương:
                </div>
                <div class="hrm_right"
                    data-bind="text: NhomNgachLuong">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Ngày bổ nhiệm ngạch:
                </div>
                <div class="hrm_right"
                    data-bind="text: NgayBoNhiemNgach">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Bậc lương:
                </div>
                <div class="hrm_right"
                    data-bind="text: BacLuong">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Hệ số lương:
                </div>
                <div class="hrm_right"
                    data-bind="text: HeSoLuong">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Ngày hưởng lương:
                </div>
                <div class="hrm_right"
                    data-bind="text: NgayHuongLuong">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Mốc nâng lương lần sau:
                </div>
                <div class="hrm_right"
                    data-bind="text: MocNangLuongLanSau">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    % mức lương được hưởng:
                </div>
                <div class="hrm_right"
                    data-bind="text: MucLuongDuocHuong">
                </div>
            </div>
           <%-- <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Hưởng HSPC chuyên viên:
                </div>
                <div class="hrm_right"
                    data-bind="text: DuocHuongHSPCChuyenVien">
                </div>
            </div>--%>
          
            <div class="hrm_clear">
            </div>
            <div class="hrm_subtitle1">
                Phụ Nhà Nước
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC Chức vụ:
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCChucVu">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Ngày hưởng HSPC chức vụ:
                </div>
                <div class="hrm_right"
                    data-bind="text: NgayHuongHSPCChucVu">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC kiêm nhiệm:
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCKiemNhiem">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC trách nhiệm:
                </div>
                <div class="hrm_right"
                    data-bind="text: HeSoPhuCapTrachNhiem">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC độc hại:
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCDocHai">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC khác:
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCKhac">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    % vượt khung thâm niên:
                </div>
                <div class="hrm_right"
                    data-bind="text: VuotKhung">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPCVK thâm niên:
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCVuotKhung">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    % thâm niên nhà giáo:
                </div>
                <div class="hrm_right"
                    data-bind="text: ThamNien">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC thâm niên nhà giáo:
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCThamNien">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Ngày hưởng HSPC thâm niên:
                </div>
                <div class="hrm_right"
                    data-bind="text: NgayHuongHSPCChuyenMon">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    % PC ưu đãi:
                </div>
                <div class="hrm_right"
                    data-bind="text: PhanTramUuDai">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC ưu đãi:
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCUuDai">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_subtitle1">
                Phụ Cấp Trường
            </div>
           <%-- <div class="hrm_box">
                <div class="hrm_left">
                    HSPC lãnh đạo:
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCLanhDao">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC trách nhiệm:
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCTrachNhiem">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Ngày hưởng HSPC trách nhiệm:
                </div>
                <div class="hrm_right"
                    data-bind="text: NgayHuongHSPCTracNhiem">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC chuyên môn:
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCChuyenMon">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Ngày hưởng HSPC chuyên môn:
                </div>
                <div class="hrm_right"
                    data-bind="text: NgayHuongHSPCChuyenMon">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC kiêm nhiệm :
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCKiemNhiemTrongTruong">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    HSPC thâm niên :
                </div>
                <div class="hrm_right"
                    data-bind="text: HSPCThamNienTruong">
                </div>
            </div>
            --%>
            <div class="hrm_clear">
            </div>
            <div class="hrm_subtitle">
                Thông tin thuế TNCN
            </div>
              <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Mã số thuế:
                </div>
                <div class="hrm_right"
                    data-bind="text: MaSoThue">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Cơ quan thuế:
                </div>
                <div class="hrm_right"
                    data-bind="text: CoQuanThue">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Số người phụ thuộc:
                </div>
                <div class="hrm_right"
                    data-bind="text: SoNguoiPhuThuoc">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Số tháng giảm trừ:
                </div>
                <div class="hrm_right"
                    data-bind="text: SoThangGiamTru">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Loại cư trú:
                </div>
                <div class="hrm_right"
                    data-bind="text: LoaiCuTru">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div>
                <div class="hrm_subtitle">
                    Tài khoản ngân hàng
                </div>
                <div class="hrm_line">
                </div>
                <div>
                    <table width="100%" border="1" style="border-collapse: collapse">
                        <tr class="backGroundTitle">
                            <th class="textToCenter">Số tài khoản</th>
                            <th class="textToCenter">Ngân hàng</th>
                            <th class="textToCenter">Tài khoản chính</th>
                        </tr>
                        <tbody data-bind="foreach: DanhSach_TaiKhoanNganHang">
                            <tr>
                                <td data-bind="text: SoTaiKhoan" class="textToCenter"></td>
                                <td data-bind="text: NganHang" class="textToCenter"></td>
                                <td class="textToCenter">
                                    <input type="checkbox" data-bind="checked: TaiKhoanChinh" /></td>
                            </tr>
                        </tbody>
                    </table>
                    <br />
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div>
                <div class="hrm_subtitle">
                    Danh sách người phụ thuộc
                </div>
                <div class="hrm_line">
                </div>
                <div>
                    <table width="100%" border="1" style="border-collapse: collapse">
                        <tr class="backGroundTitle">
                            <th class="textToCenter">Họ tên</th>
                            <th class="textToCenter">Quan hệ</th>
                            <th class="textToCenter">Từ ngày</th>
                            <th class="textToCenter">Đến ngày</th>
                        </tr>
                        <tbody data-bind="foreach: DanhSach_NguoiPhuThuoc">
                            <tr>
                                <td data-bind="text: HoTen" class="textToCenter"></td>
                                <td data-bind="text: QuanHe" class="textToCenter"></td>
                                 <td data-bind="text: TuNgay == null ? '' : formatDate(new Date(TuNgay))" class="textToCenter"></td>
                                <td data-bind="text: DenNgay == null ? '' : formatDate(new Date(DenNgay))" class="textToCenter"></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class="hrm_clear">
            </div>
        </div>
    </div>
</body>
</html>
