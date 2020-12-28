﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="HRMChamCong.Views.QuanLyXetABC.Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script src="/Scripts/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="/Scripts/jquery.linq.min.js"></script>
    <script src="/Scripts/knockout-3.2.0.js"></script>
    <script type="text/javascript">
        function formatDate(date) {
            return date.getDate() + "/" + parseInt(date.getMonth() + 1) + "/" + date.getFullYear();
        }
        function viewModel() {
            var self = this;
            self.ChiTietChamCong = ko.observableArray();
            self.HinhThucNghiList = ko.observableArray();
            self.HoTen = ko.observable();
            self.MaNhanSu = ko.observable();
            self.KXD = 0;
            self.CN = 0;
            self.NN = 0;
            self.P = 0;
            self.He = 0;
            self.Ro = 0;
            self.TS = 0;
            self.P = 0;
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/QuanLyChamCong_GetListHinhThucNghi',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: false,
                success: function (result) {
                    var obj = $.parseJSON(result.d);
                    obj.push({ Oid: null, TenHinhThucNghi: "Làm cả ngày" });
                    var data = $.Enumerable.From(obj).OrderBy(function (x) {
                        return x.TenHinhThucNghi;
                    }).ToArray();
                    self.HinhThucNghiList(data);

                }
            });
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/QuanLyXetABC_Detail',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: ko.toJSON({
                    thang: '<%#Request.QueryString["Thang"] %>',
                    nam: '<%#Request.QueryString["Nam"] %>',
                    idNhanVien: '<%#Request.QueryString["Id"] %>',
                }),
                async: false,
                success: function (result) {
                    var data = $.parseJSON(result.d);
                    self.ChiTietChamCong(data.ChiTietChamCong);
                    self.HoTen(data.HoTen);
                    self.MaNhanSu(data.MaNhanSu);
                        self.KXD = $.Enumerable.From(data.ChiTietChamCong).Sum(function (x) {
                            return x.MaHinhThucNghi == '';



                        });
                    self.CN = $.Enumerable.From(data.ChiTietChamCong).Sum(function (x) {
                        return x.IDHinhThucNghi == null;
                    });
                    self.NN = $.Enumerable.From(data.ChiTietChamCong).Sum(function (x) {
                        return x.MaHinhThucNghi == '1/2';
                    });
                    self.P = $.Enumerable.From(data.ChiTietChamCong).Sum(function (x) {
                        return x.MaHinhThucNghi == 'P';
                    });
                    self.Ro = $.Enumerable.From(data.ChiTietChamCong).Sum(function (x) {
                        return x.MaHinhThucNghi == 'Ro';
                    });
                    self.TS = $.Enumerable.From(data.ChiTietChamCong).Sum(function (x) {
                        return x.MaHinhThucNghi == 'TS';
                    });
                    self.He = $.Enumerable.From(data.ChiTietChamCong).Sum(function (x) {
                        return x.MaHinhThucNghi == 'H';
                    });
                }
            });
        }

        $(function () {
            var view;
            view = new viewModel();
            ko.applyBindings(view, $("#abc_detail")[0]);
        });
    </script>
</head>
<body>
    <div id="abc_detail">
        <table border="0" cellpadding="0" cellspacing="0">
            <tbody>
                <tr>
                    <td>
                        <img alt="Trường Đại Học Công Nghiệp TP.HCM" src="/Images/logo.png" align="middle"></td>
                    <td style="font-family: Arial,Tahoma; font-size: 20pt; font-weight: bold;">TRƯỜNG ĐẠI HỌC CÔNG NGHIỆP TP.HCM</td>
                </tr>
            </tbody>
        </table>
        <div align="center" style="font-family: Arial, Tahoma; font-size: 14pt; font-weight: bold; padding-bottom: 5px;">Bảng chấm công của <span data-bind="text:HoTen() + ' ('+MaNhanSu()+')'"></span>- <%#Request.QueryString["Thang"].ToString() %>/<%#Request.QueryString["Nam"] %></div>
        <table border="1" width="100%" cellpadding="3" cellspacing="0" style="font-family: Arial, Tahoma; font-size: 10pt">
            <tbody>
                <tr style="height: 30px;">
                    <th>STT</th>
                    <th>Ngày chấm công</th>
                    <!-- ko foreach:HinhThucNghiList -->
                    <th data-bind="text:TenHinhThucNghi"></th>
                    <!-- /ko -->
                </tr>
                <!-- ko foreach:ChiTietChamCong -->

                <tr>
                    <td style="text-align: center; width: 50px;" data-bind="text:$index()+1"></td>
                    <td style="text-align: center;" data-bind="text:formatDate(new Date(Ngay))"></td>
                    <!-- ko foreach:$parent.HinhThucNghiList -->
                    <td style="text-align: center;" data-bind="text:$data.Oid == $parent.IDHinhThucNghi ? 'X' : ''"></td>
                    <!-- /ko -->
                </tr>

                <!-- /ko -->

            </tbody>
        </table>
        <table border="0" width="100%" cellpadding="3" cellspacing="0" style="font-family: Arial, Tahoma; font-size: 10pt; padding-top: 7px;">
            <tbody>
                <tr>
                    <td style="text-align: right; padding-right: 5px;">Không xác định
                    <br>
                        Số ngày làm cả ngày:
                    <br>
                        Số ngày làm nửa ngày:
                    <br>
                        Số ngày nghỉ có phép:
                    <br>
                        Số ngày nghỉ không phép:
                    <br>
                        Số ngày nghỉ thai sản:
                    <br>
                        Số ngày nghỉ hè:
                    </td>
                    <td style="font-weight: bold; text-align: left; padding-left: 5px; width: 60px;">
                        <span data-bind="text:KXD"></span>
                        <br>
                        <span data-bind="text:CN"></span>
                        <br>
                        <span data-bind="text:NN"></span>
                        <br>
                        <span data-bind="text:P"></span>
                        <br>
                        <span data-bind="text:Ro"></span>
                        <br>
                        <span data-bind="text:TS"></span>
                        <br>
                        <span data-bind="text:He"></span>

                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>

