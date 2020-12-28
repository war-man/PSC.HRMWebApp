﻿<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="QuaTrinhDaoTao.aspx.cs" Inherits="HRMChamCong.Views.QuaTrinhCongTac.QuaTrinhDaoTao" %>

<%@ Import Namespace="HRMChamCong.Helper" %>
<html>
<head></head>
<body>
    <div>
        <div class="hrm_clear">
        </div>
        <div class="hrm_content" style="width: 900px !important">
            <table width="100%" border="1" style="border-collapse: collapse">
                <tr class="backGroundTitle" style="height: 25px;">
                    <th class="textToCenter">Năm nhập học</th>
                    <th class="textToCenter">Năm tốt nghiệp</th>
                    <th class="textToCenter">Trình độ</th>
                    <th class="textToCenter">Trường đào tạo</th>
                    <th class="textToCenter">Ngành đào tạo</th>
                    <th class="textToCenter">Hình thức đào tạo</th>
                </tr>
                <tbody data-bind="foreach: DanhSach_QuaTrinhDaoTao">
                    <tr>
                        <td data-bind="text: NamNhapHoc" class="textToCenter"></td>
                        <td data-bind="text: NamTotNghiep" class="textToCenter"></td>
                        <td data-bind="text: TrinhDoChuyenMon" class="textToCenter"></td>
                        <td data-bind="text: TruongDaoTao" class="textToCenter"></td>
                        <td data-bind="text: ChuyenNganhDaoTao" class="textToCenter"></td>
                        <td data-bind="text: HinhThucDaoTao" class="textToCenter"></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</body>
</html>
