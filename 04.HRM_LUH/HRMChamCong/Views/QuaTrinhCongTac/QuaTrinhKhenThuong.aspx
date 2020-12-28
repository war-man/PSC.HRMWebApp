﻿<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="QuaTrinhKhenThuong.aspx.cs" Inherits="HRMChamCong.Views.QuaTrinhCongTac.QuaTrinhKhenThuong" %>

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
                    <th style="width: 15%;" class="textToCenter">Số quyết định</th>
                    <th style="width: 15%;" class="textToCenter">Ngày khen thưởng</th>
                    <th style="width: 15%;" class="textToCenter">Danh hiệu</th>
                    <th style="width: 55%;">Lý do</th>
                </tr>
                <tbody data-bind="foreach: DanhSach_QuaTrinhKhenThuong">
                    <tr>
                        <td data-bind="text: SoQuyetDinh" class="textToCenter"></td>
                        <td data-bind="text: NgayKhenThuong == null ? '' : formatDate(new Date(NgayKhenThuong))" class="textToCenter"></td>
                        <td data-bind="text: DanhHieu" class="textToCenter"></td>
                        <td data-bind="text: LyDo" class="textToCenter"></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</body>
</html>
