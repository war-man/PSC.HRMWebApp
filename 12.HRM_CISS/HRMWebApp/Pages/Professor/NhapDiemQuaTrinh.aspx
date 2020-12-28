﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhapDiemQuaTrinh.aspx.cs" Inherits="MyUIS_MVC.Pages.Professor.NhapDiemQuaTrinh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nhập điểm quá trình</title>
    <style>
        .textbox{
    text-align:center;
}
        .trhover{
            background-color:#eee;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 900px; margin: auto; overflow: auto">
            <table cellpadding="0" cellspacing="5" border="0" width="100%">
                <tr>
                    <td colspan="4" align="center">
                        <asp:Label ID="Label1" runat="server" Text="NHẬP ĐIỂM QUÁ TRÌNH" CssClass="title" Font-Bold="True" Font-Size="20pt"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td width="130px">Năm học:</td>
                    <td>
                        <asp:Label ID="lblYearStudy" runat="server" Font-Bold="true"></asp:Label>
                    </td>
                    <td width="130px">Học kỳ:</td>
                    <td>
                        <asp:Label ID="lblTermID" runat="server" Font-Bold="true"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>Học phần:</td>
                    <td>
                        <asp:Label ID="lblCurriculumName" runat="server" Font-Bold="true"></asp:Label>
                    </td>
                    <td>Mã học phần:</td>
                    <td>
                        <asp:Label ID="lblCurriculumID" runat="server" Font-Bold="true"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Thời gian nhập điểm:</td>
                    <td>
                        <asp:Label ID="lblFromdate" runat="server" Font-Bold="true"></asp:Label>

                    </td>
                    <td>%Quá trình:</td>
                    <td>
                        <asp:Label ID="lblAssignmentdetail" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" align="right" style="text-align: right" class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4" style="text-align:center">
                        <asp:Label ID="lblThongbao" runat="server" Font-Bold="True" Font-Italic="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="text-align: right">
                        <asp:Button ID="btnDongform" runat="server" OnClientClick="window.close(); return false;" Text="Đóng"  />
                        <asp:Button ID="btnKhoaDiem" runat="server" OnClientClick="return confirm('Xác nhận khóa điểm ?')" Text="Khóa điểm" OnClick="btnKhoaDiem_Click" />
                        &nbsp;<asp:Button ID="btnLuuDiem" runat="server" Text="Lưu điểm" OnClick="btnLuuDiem_Click" />          
                    </td>
                </tr>
            </table>
            <div>

                <asp:Literal ID="lrtHtml" runat="server"></asp:Literal>

            </div>
        </div>
    </form>
<script>
    function heartBeat() {
        $.get("/KeepAlive.ashx", function (data) { });
    }

    $(function () {
        setInterval("heartBeat()", 10000 * 10); // 10p gửi request một lần
    });
    ///////////////////////////////////////////
    function stopRKey(evt) {
        var evt = (evt) ? evt : ((event) ? event : null);
        var node = (evt.target) ? evt.target : ((evt.srcElement) ? evt.srcElement : null);
        if ((evt.keyCode == 13) && (node.type == "text")) { return false; }
    }

    document.onkeypress = stopRKey;

    ///////////////////////////////////////
    function clickEnter(cuobj, obj, event) {
        var keyCode;
        if (event.keyCode > 0) {
            keyCode = event.keyCode;
        }
        else if (event.which > 0) {
            keyCode = event.which;
        }
        else {
            keycode = event.charCode;
        }
        if (keyCode == 13 || keyCode == 40 || keyCode == 9) {
            var valueee = document.getElementById(cuobj).value;
            if (isNaN(valueee) == false && (valueee > 10 || valueee < 0)) {
                alert('Điểm không hợp lệ');
                document.getElementById(cuobj).style.border = "thin solid red";
                document.getElementById(cuobj).focus();
            }
            else if (isNaN(valueee) == true) {
                alert('Điểm không hợp lệ');
                document.getElementById(cuobj).style.border = "thin solid red";
                document.getElementById(cuobj).focus();
            }
            else {
                document.getElementById(obj).focus();
                document.getElementById(cuobj).style.border = "thin solid blue";
            }
            return false;
        }
        else {

            return true;
        }
    }
    // 
    function Onblur(cuobj, obj)
    {
        var valueee = document.getElementById(cuobj).value;
        if (isNaN(valueee) == true || valueee > 10 || valueee < 0) {
            alert('Điểm không hợp lệ');
            document.getElementById(cuobj).style.border = "thin solid red";
            document.getElementById(cuobj).focus();
            return false;

        }
        else { }
    }
</script>
</body>
</html>
