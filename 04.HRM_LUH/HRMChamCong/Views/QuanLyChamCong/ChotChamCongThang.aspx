﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChotChamCong.aspx.cs" Inherits="HRMChamCong.Views.QuanLyChamCong.ChotChamCongThang" %>

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
        function viewModel_ChotChamCong() {
            var self = this;
            self.department = ko.observableArray();
            self.departmentSelected = ko.observable(null);
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/QuanLyChamCong_GetDepartmentsOfUser',
                contentType: "application/json; charset=utf-8",
                data: ko.toJSON({ userId: '<%#HttpContext.Current.Session[SessionKey.UserId.ToString()]%>' }),
                dataType: "json",
                async: false,
                success: function (result) {
                    var obj = $.parseJSON(result.d);
                    self.department(obj);
                }
            });
            self.checkExits = function(month, year) {
                var check;

                $.ajax({
                    type: 'POST',
                    url: '/Services/ChamCongService.asmx/ChotChamCongThang_CheckExists',
                    contentType: "application/json; charset=utf-8",
                    data: ko.toJSON({
                        thang: month,
                        nam: year,
                        boPhanId: self.departmentSelected()
                    }),
                    dataType: "json",
                    async: false,
                    success: function (result) {
                        check = result.d;
                    }
                });
                return check;
            }

            self.save=function() {
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
                if (self.departmentSelected() == undefined) {
                    alert('Vui lòng chọn phòng ban !!');
                    $('#ddlPhongBan').focus();
                    return;
                }
                if (isNaN($('#txtYear').val())) {
                    alert('Năm không hợp lệ !!');
                    $('#txtYear').focus();
                    return;
                }
                if ($('input[name="rStatus"]:checked').val() == "true") {
                    if (self.checkExits($('#ddlMonth').val(), $('#txtYear').val())) {
                        alert('Tháng này đã chốt chấm công rồi !!');
                        return;
                    } else {
                        $.ajax({
                            type: 'POST',
                            url: '/Services/ChamCongService.asmx/ChotChamCongThang_Create',
                            contentType: "application/json; charset=utf-8",
                            data: ko.toJSON({
                                thang: $('#ddlMonth').val(),
                                nam: $('#txtYear').val(),
                                boPhanId:self.departmentSelected(),
                                userId: '<%#HttpContext.Current.Session[SessionKey.UserId.ToString()]%>'
                            }),
                            dataType: "json",
                            async: false,
                            success: function (result) {
                                alert("Chốt chấm công thành công !!");
                            }
                        });
                    }
                } else {
                    if (self.checkExits($('#ddlMonth').val(), $('#txtYear').val())) {
                        $.ajax({
                            type: 'POST',
                            url: '/Services/ChamCongService.asmx/ChotChamCongThang_Delete',
                            contentType: "application/json; charset=utf-8",
                            data: ko.toJSON({
                                thang: $('#ddlMonth').val(),
                                nam: $('#txtYear').val(),
                                boPhanId: self.departmentSelected()
                            }),
                            dataType: "json",
                            async: false,
                            success: function (result) {
                                alert("Hủy chốt chấm công thành công !!");
                            }
                        });
                    } else {
                        alert("Chưa có dữ liệu để hủy chấm công !!");
                        return;
                    }

                }
            }
        }
        

        $(function () {
            var view_chotchamCong = new viewModel_ChotChamCong();
            ko.applyBindings(view_chotchamCong, $("#chotChamCongThang")[0]);
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="chotChamCongThang">
        
        <div>
            
            <div style="font-family:sans-serif; font-size:24px;color:cadetblue">Chốt chấm công tháng</div>
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
            <label>Năm:</label>
            <input type="text" id="txtYear" style="width: 200px; height:32px; padding-left:5px;" maxlength="4" />

        </div>
        <div class="formGroup">
            <label>Bộ phận:</label>
            <select id="ddlPhongBan" style="width: 200px" data-bind="options: department, optionsText: function (type) { return type.STT + '. ' + type.TenBoPhan }, optionsValue: 'Oid', value: departmentSelected, optionsCaption: '-- Chọn phòng ban --'"></select>
        </div>
        <div class="formGroup">
            <label>Trạng thái:</label>
            <input type="radio" value="true" name="rStatus" checked="checked" /><span>Chốt chấm công</span>
            <input type="radio" value="false" name="rStatus" /><span>Hủy chốt chấm công</span>
        </div>
                <div class="formGroup">
            <a href="#" class="btn btn-labeled btn-palegreen" style="width: 158px;" data-bind="click: save">
                                            <i class="btn-label glyphicon glyphicon-ok"></i>Lưu
                                        </a>
                     <%--<a href="javascript:history.back()" class="btn btn-labeled btn-blue" data-bind="click: checkExits" style="width: 158px;">
                <i class="btn-label glyphicon glyphicon-chevron-left"></i>Trở về
                                        </a>--%>
                    <a href="javascript:history.back()" class="btn btn-labeled btn-blue" style="width: 158px;">
                <i class="btn-label glyphicon glyphicon-chevron-left"></i>Trở về
                                        </a>
                                     
        </div>
    </div>
</asp:Content>
