﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiayToHoSo.aspx.cs" Inherits="HRMChamCong.Views.HoSoNhanSu.GiayToHoSo" %>
<!DOCTYPE html>
<html dir="ltr" mozdisallowselectionprint moznomarginboxes>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <meta name="google" content="notranslate">
    <title>PDF.js viewer</title>
    <style type="text/css">
        .innerCenter {
            margin-left: 80px;
        }
    </style>
<%--    <link rel="stylesheet" href="viewer.css" />
    <script src="compatibility.js"></script>
    <link rel="resource" type="application/l10n" href="locale/locale.properties" />
    <script src="l10n.js"></script>
    <script src="../build/pdf.js"></script>
    <script src="debugger.js"></script>
    <script src="viewer.js"></script>--%>

</head>
<body tabindex="1">
    <div id="giayToHoSoGrid" ></div>
    <div id="outerContainer" class="loadingInProgress" style="padding: 10px 0px 0px 0px;display: none">
        <div id="mainContainer">
            <div id="viewerContainer" tabindex="0">
                <div id="viewer">
                    <iframe style="border: none"
                        data-bind="attr: { src: '/Components/pdfjs/web/viewer.html?file=' + giayToDirectory() }"
                      
                        width="100%" height="900" allowfullscreen></iframe>
                </div>
            </div>
            <div id="errorWrapper" hidden='true'>
                <div id="errorMessageLeft">
                    <span id="errorMessage"></span>
                    <button id="errorShowMore" data-l10n-id="error_more_info">
                        More Information
                    </button>
                    <button id="errorShowLess" data-l10n-id="error_less_info" hidden='true'>
                        Less Information
                    </button>
                </div>
                <div id="errorMessageRight">
                    <button id="errorClose" data-l10n-id="error_close">
                        Close
                    </button>
                </div>
                <div class="clearBoth"></div>
                <textarea id="errorMoreInfo" hidden='true' readonly="readonly"></textarea>
            </div>
        </div>
    </div>
    <div id="printContainer"></div>
    <div id="mozPrintCallback-shim" hidden>
        <style scoped>
            #mozPrintCallback-shim {
                position: fixed;
                top: 0;
                left: 0;
                height: 100%;
                width: 100%;
                z-index: 9999999;
                display: block;
                text-align: center;
                background-color: rgba(0, 0, 0, 0.5);
            }

                #mozPrintCallback-shim[hidden] {
                    display: none;
                }

            @media print {
                #mozPrintCallback-shim {
                    display: none;
                }
            }

            #mozPrintCallback-shim .mozPrintCallback-dialog-box {
                display: inline-block;
                margin: -50px auto 0;
                position: relative;
                top: 45%;
                left: 0;
                min-width: 220px;
                max-width: 400px;
                padding: 9px;
                border: 1px solid hsla(0, 0%, 0%, .5);
                border-radius: 2px;
                box-shadow: 0 1px 4px rgba(0, 0, 0, 0.3);
                background-color: #474747;
                color: hsl(0, 0%, 85%);
                font-size: 16px;
                line-height: 20px;
            }

            #mozPrintCallback-shim .progress-row {
                clear: both;
                padding: 1em 0;
            }

            #mozPrintCallback-shim progress {
                width: 100%;
            }

            #mozPrintCallback-shim .relative-progress {
                clear: both;
                float: right;
            }

            #mozPrintCallback-shim .progress-actions {
                clear: both;
            }
        </style>
        <div class="mozPrintCallback-dialog-box">
            <!-- TODO: Localise the following strings -->
            Preparing document for printing...
    <div class="progress-row">
        <progress value="0" max="100"></progress>
        <span class="relative-progress">0%</span>
    </div>
            <div class="progress-actions">
                <input type="button" value="Cancel" class="mozPrintCallback-cancel">
            </div>
        </div>
    </div>
</body>
</html>

