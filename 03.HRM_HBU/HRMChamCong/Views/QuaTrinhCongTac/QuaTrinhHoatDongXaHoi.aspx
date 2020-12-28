﻿<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="QuaTrinhHoatDongXaHoi.aspx.cs" Inherits="HRMChamCong.Views.QuaTrinhCongTac.QuaTrinhHoatDongXaHoi" %>

<%@ Import Namespace="HRMChamCong.Helper" %>

<html>
<head></head>
    <body>
        <div >
            <div class="hrm_clear">
            </div>
            <div class="hrm_content" style="width: 900px !important">
                <table width="100%" border="1" style="border-collapse: collapse">
                    <tr class="backGroundTitle" style="height: 25px;">
                        <th style="width: 15%" class="textToCenter">Từ ngày</th>
                        <th style="width: 15%" class="textToCenter">Đến ngày</th>
                        <th style="width: 70%" class="textToCenter">Nội dung</th>
                    </tr>
                    <tbody data-bind="foreach: DanhSach_QuaTrinhHoatDongXaHoi">
                        <tr>
                            <td data-bind="text: TuNam" class="textToCenter"></td>
                            <td data-bind="text: DenNam" class="textToCenter"></td>
                            <td data-bind="text: NoiDung" class="textToCenter"></td>

                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </body>
</html>
