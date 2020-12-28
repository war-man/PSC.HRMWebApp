﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DoDuLieuChamCong.aspx.cs" Inherits="HRMChamCong.Views.QuanLyChamCong.DoDuLieuChamCong" %>

<%@ Import Namespace="HRMChamCong.Helper" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(function () {
            var source;
            var pathname = window.location.pathname;
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/WebMenu_GetURLListBy_WebUserId',
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({
                    webUserId: '<%#HttpContext.Current.Session[SessionKey.UserId.ToString()]%>'
                }),
                dataType: "json",
                async: false,
                success: function (result) {
                    var data = $.parseJSON(result.d);
                    source = data;
                }
            });
            var check = $.inArray(pathname, source);
            if (check < 0) {
                window.location.href = "../../Default.aspx";
            }
        });
    </script>
    <style type="text/css">
        .formGroup {
            padding: 10px 0px 0px 0px;
            margin: 0 auto;
        }

            .formGroup label {
                float: left;
                width: 120px;
            }

            .formGroup span {
                padding: 0px 10px;
            }

        .container {
            border: solid 1px #7F9DB9;
            width: 400px;
            height: 500px;
            overflow-y: scroll;
        }

        .form_checkbox {
            padding: 0 5px;
        }

        h3 {
            color: #3B6097;
        }

        .formEvent {
            float: right;
        }

            .formEvent a {
                color: #3B6097;
                width: 50px;
                float: left;
            }

        .validate {
            color: red;
        }
    </style>
    <script type="text/javascript">
        var month, year, status;
        function checkExits(month, year) {
            var check;
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/DoDuLieuChamCongThang_CheckExists',
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({ thang: month, nam: year }),
                dataType: "json",
                async: false,
                success: function (result) {
                    check = result.d;
                }
            });
            return check;
        }
        function checkKyChamCong(month, year) {
            var check;
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/KyChamCong_Check',
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({ thang: month, nam: year }),
                dataType: "json",
                async: false,
                success: function (result) {
                    check = result.d;
                }
            });
            return check;
        }
        function viewModel() {
            var self = this;
            self.HinhThucNghiList = ko.observableArray();
            self.hinhThucNghiSelected = ko.observable("");
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/QuanLyChamCong_GetListHinhThucNghi',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: false,
                success: function (result) {
                    var obj = $.parseJSON(result.d);
                    self.HinhThucNghiList(obj);

                }
            });
        }
        viewModel.prototype = {
            save: function () {
                var self = this;

                if ($('#ddlMonth').val() == -1) {
                    alert('Vui lòng chọn tháng !!');
                    $('#ddlMonth').focus();
                    return;
                }
                if ($('#txtYear').val() == '') {
                    alert('Vui lòng nhập năm !!');
                    $('#txtYear').focus();
                    return;
                }
                if (isNaN($('#txtYear').val())) {
                    alert('Năm không hợp lệ !!');
                    $('#txtYear').focus();
                    return;
                }

                if (checkExits($('#ddlMonth').val(), $('#txtYear').val())) {
                    alert('Tháng ' + $('#ddlMonth').val() + '/' + $('#txtYear').val() + ' đã đổ dữ liệu chấm công rồi !!');
                    return;
                }
                if (checkKyChamCong($('#ddlMonth').val(), $('#txtYear').val()) == false) {
                    alert('Chưa có kỳ chấm công tháng ' + $('#ddlMonth').val() + '/' + $('#txtYear').val() + ' !!');
                    return;
                }
                $.ajax({
                    type: 'POST',
                    url: '/Services/ChamCongService.asmx/DoDuLieuChamCongThang',
                    contentType: "application/json; charset=utf-8",
                    data: ko.toJSON({
                        thang: $('#ddlMonth').val(),
                        nam: $('#txtYear').val(),
                        idHinhThucNghi: self.hinhThucNghiSelected() == undefined ? null : self.hinhThucNghiSelected(),
                        webUserId: '<%#HttpContext.Current.Session[SessionKey.UserId.ToString()]%>'
                    }),
                    dataType: "json",
                    async: false,
                    success: function (result) {
                        alert("Đổ dữ liệu chấm công thành công !!");
                    }
                });
            },
            saveAddition: function () {
                var self = this;

                if ($('#ddlMonth').val() == -1) {
                    alert('Vui lòng chọn tháng !!');
                    $('#ddlMonth').focus();
                    return;
                }
                if ($('#txtYear').val() == '') {
                    alert('Vui lòng nhập năm !!');
                    $('#txtYear').focus();
                    return;
                }
                if (isNaN($('#txtYear').val())) {
                    alert('Năm không hợp lệ !!');
                    $('#txtYear').focus();
                    return;
                }
                if (checkKyChamCong($('#ddlMonth').val(), $('#txtYear').val()) == false) {
                    alert('Chưa có kỳ chấm công tháng ' + $('#ddlMonth').val() + '/' + $('#txtYear').val() + ' !!');
                    return;
                }
                $.ajax({
                    type: 'POST',
                    url: '/Services/ChamCongService.asmx/DoDuLieuChamCongThang_BoSung',
                    contentType: "application/json; charset=utf-8",
                    data: ko.toJSON({
                        thang: $('#ddlMonth').val(),
                        nam: $('#txtYear').val(),
                        idHinhThucNghi: self.hinhThucNghiSelected() == undefined ? null : self.hinhThucNghiSelected(),
                        webUserId: '<%#HttpContext.Current.Session[SessionKey.UserId.ToString()]%>'
                    }),
                    dataType: "json",
                    async: false,
                    success: function (result) {
                        alert("Đổ dữ liệu chấm công thành công !!");
                    }
                });


            }
        };
        $(function () {
            var view = new viewModel();
            ko.applyBindings(view, $("#dodulieuchamcong")[0]);
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="dodulieuchamcong">

        <div>
            <div style="font-family: sans-serif; font-size: 24px; color: cadetblue">Đổ dữ liệu chấm công tháng</div>
            <div class="formGroup">
                <label>Tháng:</label>
                <select id="ddlMonth" style="width: 200px;">
                    <option value="-1">--- Chọn tháng ---</option>
                    <option value="1">Tháng 1</option>
                    <option value="2">Tháng 2</option>
                    <option value="3">Tháng 3</option>
                    <option value="4">Tháng 4</option>
                    <option value="5">Tháng 5</option>
                    <option value="6">Tháng 6</option>
                    <option value="7">Tháng 7</option>
                    <option value="8">Tháng 8</option>
                    <option value="9">Tháng 9</option>
                    <option value="10">Tháng 10</option>
                    <option value="11">Tháng 11</option>
                    <option value="12">Tháng 12</option>
                </select>
            </div>
        </div>
        <div class="formGroup">
            <label>Năm</label>
            <input type="text" id="txtYear" style="width: 200px; padding: 5px; height: 32px;" maxlength="4" />
        </div>
        <div class="formGroup">
            <label>Trạng thái:</label>
            <select data-bind="options: HinhThucNghiList, optionsText: 'TenHinhThucNghi', optionsValue: 'Oid', value: hinhThucNghiSelected, optionsCaption: 'Làm cả ngày'"></select>
        </div>
        <div class="formGroup">
            <a href="#" class="btn btn-labeled btn-palegreen" style="width: 158px;" data-bind="click: save">
                <i class="btn-label glyphicon glyphicon-ok"></i>Đổ dữ liệu tháng
            </a>
            <a href="#" class="btn btn-labeled btn-danger" style="width: 165px;" data-bind="click: saveAddition">
                <i class="btn-label glyphicon glyphicon-ok"></i>Đổ dữ liệu bổ sung
            </a>
            <a href="javascript:history.back()" class="btn btn-labeled btn-blue" style="width: 158px;">
                <i class="btn-label glyphicon glyphicon-chevron-left"></i>Trở về
            </a>

        </div>
        <%--    <div class="loading" style="padding-top: 10px; display: none;">
        <h5 style="color: red; font-style: italic">Vui lòng đợi trong giây lát ...</h5>
    </div>--%>
    </div>
</asp:Content>
