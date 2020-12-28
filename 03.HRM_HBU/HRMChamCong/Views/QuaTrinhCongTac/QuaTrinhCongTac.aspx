﻿<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="QuaTrinhCongTac.aspx.cs" Inherits="HRMChamCong.Views.QuaTrinhCongTac.QuaTrinhCongTac" %>

<html>
<head></head>
<body>
    <div class="hrm_clear">
    </div>
    <div class="hrm_content" style="width: 900px !important">
        <table width="100%" border="1" style="border-collapse: collapse">
            <tr class="backGroundTitle" style="height: 25px;">
                <th style="width: 20%" class="textToCenter">Từ năm</th>
                <th style="width: 20%" class="textToCenter">Đến năm</th>
                <th style="width: 60%">Nội dung</th>
            </tr>
            <tbody data-bind="foreach: DanhSach_QuaTrinhCongTac">
                <tr>
                    <td data-bind="text: TuNam" class="textToCenter"></td>
                    <td data-bind="text: DenNam" class="textToCenter"></td>
                    <td data-bind="text: NoiDung"></td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>
