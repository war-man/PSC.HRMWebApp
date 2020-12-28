﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="HRMChamCong.Views.User.Detail" %>
<%@ Import Namespace="HRMChamCong.Helper" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<script type="text/javascript">
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
                    </script>--%>
    <script type="text/javascript">
        var id;
        function ViewModel(data) {
            var self = this;
            self.MaNhanSu = data.MaNhanSu;
            self.userName = ko.observable(data.UserName);
            self.password = ko.observable(data.Password);
            self.confirmPassword = ko.observable(data.Password);
            self.fullName = ko.observable(data.HoVaTen);
            self.email = ko.observable(data.Email);
            self.UserChamCong = ko.observable(data.UserChamCong);
            self.accountList = ko.observableArray();
            self.accountSelected = ko.observable(data.WebGroupID);
            self.TenBoPhan = data.TenBoPhan;
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/WebGroup_GetList',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: false,
                success: function (result) {
                    var obj = $.parseJSON(result.d);
                    var a = obj[0].ID;
                    self.accountList(obj);
                }
            });

            self.status = ko.observable(data.HoatDong.toString());
            self.departments = ko.observableArray(data.DanhSachDTO_BoPhan);
            self.changePassword = ko.observable(false);
            self.allSelected = ko.observable();
        }
        ViewModel.prototype =
        {
            selectAll: function () {
                var self = this;
                ko.utils.arrayForEach(self.departments(), function (val) {
                    val.Chon(!self.allSelected());
                });
                return true;
            },
            validateEmail: function (email) {
                var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
                return re.test(email);
            },
            validate: function () {
                var self = this;
                return $.trim(self.userName()).length != 0 && $.trim(self.password()).length != 0 && $.trim(self.confirmPassword()).length != 0 && self.password() == self.confirmPassword();
            },
            validateUsernameExist: function (webUserId, userName) {
                var temp;
                $.ajax({
                    type: 'POST',
                    url: '/Services/ChamCongService.asmx/WebUsers_KiemTraTrungUsername',
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: ko.toJSON({ webUserId: webUserId, userName: userName }),
                    async: false,
                    success: function (result) {
                        temp = $.parseJSON(result.d);
                    }
                });
                return temp;
            },
            save: function () {
                var self = this;
                if (!self.validate())
                    return;
                if (self.validateUsernameExist(id, self.userName())) {
                    alert("Tên đăng nhập đã tồn tại");
                    $("#txtUserName").focus();
                    return;
                }
                ko.utils.arrayForEach(self.departments(), function (val) {
                    val.Chon = val.Chon();
                });
                var obj =
                {
                    Oid: id,
                    UserName: self.userName(),
                    Password: self.password(),
                    HoVaTen: self.fullName(),
                    Email: self.email(),
                    HoatDong: self.status(),
                    DanhSachDTO_BoPhan: self.departments(),
                    WebGroupID: self.accountSelected() == undefined ? null : self.accountSelected(),
                    UserChamCong: self.UserChamCong()
                };
                $.ajax({
                    data: JSON.stringify({ obj: obj }),
                    contentType: "application/json; charset=utf-8",
                    type: 'POST',
                    url: '/Services/ChamCongService.asmx/Save_QuanLyUser',
                    async: false,
                    dataType: "json",
                    success: function (result) {
                        alert("Lưu thành công !!");
                        location.reload();
                    }
                });
            }
        };

        $(function () {
            id = '<%#Request.QueryString["Id"]%>';

            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/GetDetail_QuanLyUser',
                async: false,
                data: JSON.stringify({ id: id }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    var data = $.parseJSON(result.d);
                    var model = new ViewModel(data);
                    var countcheckAll = $.Enumerable.From(model.departments()).Count(function (x) {
                        return x.Chon == true;
                    });
                    if (countcheckAll == data.DanhSachDTO_BoPhan.length)
                        model.allSelected(true);
                    else
                        model.allSelected(false);
                    ko.utils.arrayForEach(model.departments(), function (val) {
                        val.Chon = ko.observable(val.Chon);
                    });


                    ko.applyBindings(model, $("#userDetail")[0]);
                }
            });

        });
    </script>
    <style type="text/css">
        .formGroup {
            padding: 10px 0px 0px 0px;
            margin: 0 auto;
            vertical-align:middle;
        }

            .formGroup label {
                float: left;
                width: 200px;
            }

            .formGroup span {
                padding: 0px 10px;
            }

        .container {
            border: solid 1px #7F9DB9;
            width: 520px;
            height: 350px;
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="userDetail">

        <div class="col-lg-8 col-xs-12 col-sm-12">
            <div class="form-horizontal form-bordered">
                <div style="font-family: sans-serif; font-size: 24px; color: cadetblue; text-align: center;">Thông tin người dùng</div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right">Mã nhân sự</label>
                    <div class="col-sm-9">
                        <input class="form-control" type="text" data-bind="value: MaNhanSu, disable: true" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right">Tên user<span class="validate" data-bind="visible: $.trim(userName()).length == 0">(*)</span></label>
                    <div class="col-sm-9">
                        <input type="text" class="form-control" data-bind="value: userName" id="txtUserName" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right">Mật khẩu<span class="validate" data-bind="visible: $.trim(password()).length == 0 || confirmPassword() != password()">(*)</span></label>
                    <div class="col-sm-6 ">
                        <input type="password" class="form-control" data-bind="value: password, disable: changePassword() == false ? true : false" />
                    </div>
                    <div class="col-sm-3">
                        <div style="margin-top: 7px; float: left;">
                            <input type="checkbox" data-bind="checked: changePassword" /></div>
                        <label class="control-label no-padding-right">Đổi mật khẩu</label>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right">Xác nhận mật khẩu <span class="validate" data-bind="visible: $.trim(confirmPassword()).length == 0 || confirmPassword() != password()">(*)</span></label>
                    <div class="col-sm-6 ">
                        <input type="password" class="form-control" data-bind="value: confirmPassword, disable: changePassword() == false ? true : false" />
                    </div>
                    <div class="col-sm-3" style="vertical-align: middle;">
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right">Họ tên</label>
                    <div class="col-sm-9">
                        <input type="text" class="form-control" data-bind="value: fullName, disable: true" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right">Email</label>
                    <div class="col-sm-9">
                        <input type="text" class="form-control" data-bind="value: email, disable: true" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right">Loại tài khoản</label>
                    <div class="col-sm-9">
                        <select data-bind="options: accountList, optionsText: 'Name', optionsValue: 'ID', value: accountSelected, optionsCaption: '-- Chưa chọn --'"></select>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right">Bộ phận</label>
                    <label class="col-sm-9 control-label" style="text-align: left;"><span data-bind="text: TenBoPhan"></span></label>

                </div>
                <div class="form-group">
                    <label class="col-lg-3 col-sm-3 col-xs-3 control-label no-padding-right">Trạng thái </label>
                    <div class="col-lg-3 col-sm-4 col-xs-4 ">
                        <div style="margin-top: 7px; float: left;">
                            <input type="radio" data-bind="checked: status" value="true" name="rStatus" />
                        </div>
                        <label class="control-label no-padding-right">Hoạt động</label>
                    </div>
                    <div class="col-lg-3 col-sm-4 col-xs-4" style="vertical-align: middle;">
                        <div style="margin-top: 7px; float: left;">
                            <input type="radio" data-bind="checked: status" value="false" name="rStatus" />
                        </div>
                        <label class="control-label no-padding-right">Khóa lại</label>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right">Phòng ban được quản lý</label>
                    <div class="col-sm-9" style="overflow-y: scroll; height: 300px; padding-top: 10px;">

                        <div class="form_checkbox">
                            <div style="float: left;">
                                <input type="checkbox" data-bind="click: selectAll, checked: allSelected" /></div>
                            <div style="float: left;"><span>Chọn tất cả</span></div>
                        </div>
                        <div class="clearfix"></div>
                        <!-- ko foreach: departments -->
                        <div class="form_checkbox">
                            <div style="float: left;">
                                <input type="checkbox" data-bind="checked: Chon" /></div>
                            <div style="float: left;"><span data-bind="text: STT + '. ' + TenBoPhan"></span></div>
                            <div class="clearfix"></div>
                        </div>
                        <!-- /ko -->

                    </div>

                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right"></label>
                    <label class="col-sm-9 control-label" style="text-align: left;"><span>Lưu ý : <span style="color: red">(*)</span> bắt buộc nhập</span></label>

                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label no-padding-right"></label>
                    <div class="col-sm-9">
                        <a href="#" class="btn btn-labeled btn-palegreen" style="width: 158px;" data-bind="click: save">
                            <i class="btn-label glyphicon glyphicon-ok"></i>Lưu
                        </a>
                        <a href="javascript:history.back()" class="btn btn-labeled btn-blue" style="width: 158px;">
                            <i class="btn-label glyphicon glyphicon-chevron-left"></i>Trở về
                        </a>
                    </div>
                </div>
                <div class="form-group">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
