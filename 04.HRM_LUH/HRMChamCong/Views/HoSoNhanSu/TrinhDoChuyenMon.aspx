﻿<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="TrinhDoChuyenMon.aspx.cs" Inherits="HRMChamCong.Views.HoSoNhanSu.TrinhDoChuyenMon" %>

<html>
<head></head>
<body>
    <div>
        <div class="hrm_clear">
        </div>
        <div class="hrm_content">
            <div class="hrm_box">
                <div class="hrm_left">
                    Trình độ học vấn:
                </div>
                <div class="hrm_right"
                    data-bind="text: TrinhDoHocVan">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Trình độ chuyên môn cao nhất:
                </div>
                <div class="hrm_right"
                    data-bind="text: TrinhDoChuyenMonCaoNhat">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Chuyên ngành:
                </div>
                <div class="hrm_right"
                    data-bind="text: ChuyenNganhDaoTao">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Trường đào tạo:
                </div>
                <div class="hrm_right"
                    data-bind="text: TruongDaoTao">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Hình thức đào tạo:
                </div>
                <div class="hrm_right"
                    data-bind="text: HinhThucDaoTao">
                </div>
            </div>
               <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Năm tốt nghiệp:
                </div>
                <div class="hrm_right"
                    data-bind="text: NamTotNghiep">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Học hàm:
                </div>
                <div class="hrm_right"
                    data-bind="text: HocHam">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Năm công nhận học hàm:
                </div>
                <div class="hrm_right"
                    data-bind="text: NamCongNhan">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Đang theo học:
                </div>
                <div class="hrm_right"
                    data-bind="text: DangTheoHoc">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Lý luật chính trị:
                </div>
                <div class="hrm_right"
                    data-bind="text: LyLuanChinhTri">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Quản lý nhà nước:
                </div>
                <div class="hrm_right"
                    data-bind="text: QuanLyNhaNuoc">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Quản lý giáo dục:
                </div>
                <div class="hrm_right"
                    data-bind="text: QuanLyGiaoDuc">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Quản lý kinh tế:
                </div>
                <div class="hrm_right"
                    data-bind="text: QuanLyKinhTe">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Trình độ tin học:
                </div>
                <div class="hrm_right"
                    data-bind="text: TrinhDoTinHoc">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Ngoại ngữ chính:
                </div>
                <div class="hrm_right"
                    data-bind="text: NgoaiNguChinh">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div class="hrm_box">
                <div class="hrm_left">
                    Trình độ ngoại ngữ chính:
                </div>
                <div class="hrm_right"
                    data-bind="text: TrinhDoNgoaiNguChinh">
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div>
                <div>
                    <div class="hrm_subtitle">
                        Danh sách văn bằng
                    </div>
                    <div class="hrm_line">
                    </div>
                    <div>

                        <table width="100%" border="1" style="border-collapse: collapse">
                            <tr class="backGroundTitle" style="height: 50px;">
                                <th class="textToCenter">Trình độ chuyên môn</th>
                                <th class="textToCenter">Chuyên ngành đào tạo</th>
                                <th class="textToCenter">Trường đào tạo</th>
                                <th class="textToCenter">Năm tốt nghiệp</th>
                                <th class="textToCenter">Hình thức đào tạo</th>
                                <th class="textToCenter">Xếp loại</th>
                                <th class="textToCenter">Điểm trung bình</th>
                            </tr>
                            <tbody data-bind="foreach: DanhSach_VanBang">
                                <tr>
                                    <td data-bind="text: TenTrinhDoChuyenMon" class="textToCenter"></td>
                                    <td data-bind="text: ChuyenNganhDaoTao" class="textToCenter"></td>
                                    <td data-bind="text: TruongDaoTao" class="textToCenter"></td>
                                    <td data-bind="text: NamTotNghiep" class="textToCenter"></td>
                                    <td data-bind="text: HinhThucDaoTao" class="textToCenter"></td>
                                    <td data-bind="text: XepLoai" class="textToCenter"></td>
                                    <td data-bind="text: DiemTrungBinh" class="textToCenter"></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class="hrm_clear">
            </div>
            <div>
                <div class="hrm_subtitle">
                    Danh sách chứng chỉ
                </div>
                <div class="hrm_line">
                </div>
                <div>
                    <table width="100%" border="1" style="border-collapse: collapse">
                        <tr class="backGroundTitle">
                            <th class="textToCenter">Loại chứng chỉ</th>
                            <th class="textToCenter">Trình độ</th>
                            <th class="textToCenter">Xếp loại</th>
                            <th class="textToCenter">Điểm</th>
                            <th class="textToCenter">Ngày cấp</th>
                            <th class="textToCenter">Nơi cấp</th>
                        </tr>
                        <tbody data-bind="foreach: DanhSach_ChungChi">
                            <tr>
                                <td data-bind="text: LoaiChungChi" class="textToCenter"></td>
                                <td data-bind="text: TrinhDoChuyenMon" class="textToCenter"></td>
                                <td data-bind="text: XepLoai" class="textToCenter"></td>
                                <td data-bind="text: Diem" class="textToCenter"></td>
                                <td data-bind="text: NgayCap == null ? '' : formatDate(new Date(NgayCap))" class="textToCenter"></td>
                                <td data-bind="text: NoiCap" class="textToCenter"></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <%--<div class="hrm_clear">
            </div>
            <div>
                <div class="hrm_subtitle">
                    Danh sách chứng chỉ ngoại ngữ
                </div>
                <div class="hrm_line">
                </div>
                <div>
                    <table width="100%" border="1" style="border-collapse: collapse">
                        <tr class="backGroundTitle">
                            <th class="textToCenter">Ngoại ngữ</th>
                            <th class="textToCenter">Trình độ</th>
                            <th class="textToCenter">Điểm</th>
                        </tr>
                        <tbody data-bind="foreach: DanhSach_NgoaiNgu">
                            <tr>
                                <td data-bind="text: TenNgoaiNgu" class="textToCenter"></td>
                                <td data-bind="text: TrinhDo" class="textToCenter"></td>
                                <td data-bind="text: Diem" class="textToCenter"></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>--%>
        </div>
    </div>
</body>
</html>
