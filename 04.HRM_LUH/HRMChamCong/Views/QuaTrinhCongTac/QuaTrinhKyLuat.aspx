﻿<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="QuaTrinhKyLuat.aspx.cs" Inherits="HRMChamCong.Views.QuaTrinhCongTac.QuaTrinhKyLuat" %>

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
                    <th style="width: 20%" class="textToCenter">Số quyết định</th>
                    <th style="width: 20%" class="textToCenter">Ngày</th>
                    <th style="width: 30%" class="textToCenter">Hình thức kỷ luật</th>
                    <th style="width: 30%">Lý do</th>
                </tr>
                <tbody data-bind="foreach: DanhSach_QuaTrinhKyLuat">
                    <tr>
                        <td data-bind="text: SoQuyetDinh" class="textToCenter"></td>
                        <td data-bind="text: TuNgay == null ? '' : formatDate(new Date(TuNgay))" class="textToCenter"></td>
                        <td data-bind="text: HinhThucKyLuat" class="textToCenter"></td>
                        <td data-bind="text: LyDo" class="textToCenter"></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</body>
</html>
