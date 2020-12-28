﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chart.aspx.cs" Inherits="HRMChamCong.Views.QuanLyXetABC.Chart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="/Components/jqwidgets/jqx.base.css" rel="stylesheet" />
    <link href="/Components/jqwidgets/jqx.energyblue.css" rel="stylesheet" />
    <script src="/Scripts/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="/Components/jqwidgets/jqx-all.js" type="text/javascript"></script>
    <script src="/Components/jqwidgets/jqxcore.js"></script>
    <%--<script src="/Components/jqwidgets/jqxdata.js"></script>--%>
    <script src="/Components/jqwidgets/jqxdraw.js"></script>
    <script src="/Components/jqwidgets/jqxchart.core.js"></script>
    <script src="/Scripts/knockout-3.2.0.js"></script>
    <script type="text/javascript">
        var TenNhanVien = "",MaNhanSu="", data = [];
        var formatHour = function (dd) {
            var dtstr = dd.replace(/\D/g, " ");
            var dtcomps = dtstr.split(" ");
            var hours = parseInt(dtcomps[3]);
            var minutes = dtcomps[4] / 60;
            var seconds = dtcomps[5] / 3600;
            return hours + minutes + seconds;
        };

        function getDayOfWeek() {
            var weekday = new Array(7);
            weekday[0] = "Chủ nhật";
            weekday[1] = "Thứ 2";
            weekday[2] = "Thứ 3";
            weekday[3] = "Thứ 4";
            weekday[4] = "Thứ 5";
            weekday[5] = "Thứ 6";
            weekday[6] = "Thứ 7";
            return weekday;
        }
        function formatDate(date) {

            return date.getDate() + "/" + parseInt(date.getMonth() + 1) + "/" + date.getFullYear();
        }

        $(document).ready(function () {
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/Get_HoSoNhanVienBy_Id',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: ko.toJSON({
                    idNhanVien: '<%#Request.QueryString["Id"] %>'
                }),
                 async: false,
                 success: function (result) {
                     var data = $.parseJSON(result.d);
                     TenNhanVien = data.HoTen;
                     MaNhanSu = data.MaQuanLy
                 }
             });
            $.ajax({
                type: 'POST',
                url: '/Services/ChamCongService.asmx/QuanLyXetABC_BieuDo',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: ko.toJSON({
                    thang: '<%#Request.QueryString["Thang"] %>',
                    nam: '<%#Request.QueryString["Nam"] %>',
                    idNhanVien: '<%#Request.QueryString["Id"] %>'
                }),
                async: false,
                success: function (result) {
                    data = $.parseJSON(result.d);
                    var weekday = getDayOfWeek();
                    $(data).each(function (index, value) {
                        if (new Date(value.Ngay).getDay() == 0) {
                            value.GioVao = -1;
                            value.GioRa = -1;
                        }
                        value.Ngay = formatDate(new Date(value.Ngay)) + " ( " + weekday[new Date(value.Ngay).getDay()] +" )";
                        if (value.GioVao == null && value.GioRa == null)
                            return;
                        value.GioVao = value.GioVao == null ? null : formatHour(value.GioVao);
                        value.GioRa = value.GioVao != null && value.GioRa == null ? value.GioVao : formatHour(value.GioRa);
                    });
                }
            });
            var toolTipCustomFormatFn = function (value, itemIndex, serie, group, categoryValue, categoryAxis) {
                var from = Math.round(value.from * 3600);
                var to = Math.round(value.to * 3600);
                var hours_from = Math.floor(from / 3600);
                var hours_to = Math.floor(to / 3600);
                var minutes_from = Math.floor((from - (hours_from * 3600)) / 60);
                var minutes_to = Math.floor((to - (hours_to * 3600)) / 60);
                var seconds_from = from - (hours_from * 3600) - (minutes_from * 60);
                var seconds_to = to - (hours_to * 3600) - (minutes_to * 60);

                if (hours_from < 10) {
                    hours_from = "0" + hours_from;
                }
                if (hours_to < 10) {
                    hours_to = "0" + hours_to;
                }
                if (minutes_from < 10) {
                    minutes_from = "0" + minutes_from;
                }
                if (minutes_to < 10) {
                    minutes_to = "0" + minutes_to;
                }
                if (seconds_from < 10) {
                    seconds_from = "0" + seconds_from;
                }
                if (seconds_to < 10) {
                    seconds_to = "0" + seconds_to;
                }
                var time_from = hours_from + ':' + minutes_from + ':' + seconds_from;
                var time_to = hours_to + ':' + minutes_to + ':' + seconds_to;
                var str = '<DIV style="text-align:left"><b>Ngày: ' + categoryValue + '</b><br />Thời gian vào: <span style="color:red">' + time_from + '</span><br />';
                str += time_from == time_to ? '' : 'Thời gian ra: <span style="color:red">' + time_to + '</span><br /></DIV>';
                return str;
            };
            var settings = {
                //title: "TRƯỜNG ĐẠI HỌC CÔNG NGHIỆP TP.HCM",
                title: "TRƯỜNG ĐẠI HỌC ĐẠI HỌC QUỐC TẾ HỒNG BÀNG",
                description: "Thống kê giờ đi làm của " + TenNhanVien +" ("+ MaNhanSu +") - "+'<%#Request.QueryString["Thang"] %>' + '/' + '<%#Request.QueryString["Nam"] %>',
                enableAnimations: true,
                showLegend: true,
                padding: { left: 15, top: 5, right: 15, bottom: 5 },
                titlePadding: { left: 90, top: 0, right: 0, bottom: 10 },
                enableCrosshairs: true,
                source: data,
                xAxis:
                {
                    textRotationAngle: 90,
                    dataField: "Ngay",
                    showTickMarks: true,
                    tickMarksInterval: 1,
                    tickMarksColor: '#888888',
                    unitInterval: 1,
                    showGridLines: true,
                    //gridLinesInterval: 1,
                    //gridLinesColor: 'red'
                },
                colorScheme: 'scheme05',
                seriesGroups:
                [
                    {
                        type: 'rangecolumn',
                        columnsGapPercent: 100,
                        //orientation: 'vertical',
                        orientation: 'horizontal',
                        toolTipFormatFunction: toolTipCustomFormatFn,
                        valueAxis:
                        {
                            unitInterval: 1,
                            displayValueAxis: true,
                            position: 'top',
                            flip: true,
                            description: 'Giờ [h]',
                            formatSettings: { sufix: 'h' },
                            axisSize: 'auto',
                            tickMarksColor: '#888888',
                            minValue: 0,
                            maxValue: 24,
                            //showGridLines: false,
                            //gridLinesColor: 'brown',
                            //gridLinesInterval: 0
                        },
                        series: [
                            {
                                dataFieldTo: 'GioRa', displayText: 'Thời gian chấm công', dataFieldFrom: 'GioVao', opacity: 1,
                                showLabels: true,
                                labelsHorizontalAlignment: 'top',
                                formatFunction: function (val) {
                                    if (val.from == null && val.to == null)
                                        return " Chưa quét vân tay";
                                    return "";
                                }
                            }
                        ],
                        bands: [{ minValue: 0, maxValue: 24, color: '#E5E5E5', opacity: 0.5 }]
                    }
                ]
            };     
            $('#chartContainer').jqxChart(settings);
            $('.jqx-chart-axis-text').each(function (index, val) {
                if (val.outerHTML.indexOf('Chủ nhật') > -1) {
                    $(this).css("fill", "red");
                    return;
                }
            });
        });
    </script>
    <style>
        .over {
            position: relative;
        }

            .over span {
                position: absolute;
                top: -0.5em;
                left: 0;
            }

        .jqx-chart-label-text {
            fill: red !important;
        }
    </style>
</head>
<body>
    <div id='chartContainer' style="width: 1200px;height: 1500px"></div>
</body>
</html>
