/*
jQWidgets v3.6.0 (2014-Nov-25)
Copyright (c) 2011-2014 jQWidgets.
License: http://jqwidgets.com/license/
*/

(function(a) {
    a.jqx.jqxWidget("jqxChart", "", {});
    a.extend(a.jqx._jqxChart.prototype, {
        defineInstance: function() {
            var b = {
                title: "Title",
                description: "Description",
                source: [],
                seriesGroups: [],
                categoryAxis: null,
                xAxis: {},
                renderEngine: "",
                enableAnimations: true,
                enableAxisTextAnimation: false,
                backgroundImage: "",
                background: "#FFFFFF",
                padding: {
                    left: 5,
                    top: 5,
                    right: 5,
                    bottom: 5
                },
                backgroundColor: "#FFFFFF",
                showBorderLine: true,
                borderLineWidth: 1,
                borderLineColor: null,
                borderColor: null,
                titlePadding: {
                    left: 5,
                    top: 5,
                    right: 5,
                    bottom: 10
                },
                showLegend: true,
                legendLayout: null,
                enabled: true,
                colorScheme: "scheme01",
                animationDuration: 500,
                showToolTips: true,
                toolTipShowDelay: 500,
                toolTipDelay: 500,
                toolTipHideDelay: 4000,
                toolTipFormatFunction: null,
                columnSeriesOverlap: false,
                rtl: false,
                legendPosition: null,
                greyScale: false,
                axisPadding: 5,
                enableCrosshairs: false,
                crosshairsColor: "#BCBCBC",
                crosshairsDashStyle: "2,2",
                crosshairsLineWidth: 1,
                enableEvents: true,
                _itemsToggleState: [],
                _isToggleRefresh: false,
                drawBefore: null,
                draw: null
            };
            a.extend(true, this, b);
            this._createColorsCache()
        },
        _defaultLineColor: "#BCBCBC",
        _touchEvents: {
            mousedown: a.jqx.mobile.getTouchEventName("touchstart"),
            click: a.jqx.mobile.getTouchEventName("touchstart"),
            mouseup: a.jqx.mobile.getTouchEventName("touchend"),
            mousemove: a.jqx.mobile.getTouchEventName("touchmove"),
            mouseenter: "mouseenter",
            mouseleave: "mouseleave"
        },
        _getEvent: function(b) {
            if (this._isTouchDevice) {
                return this._touchEvents[b]
            } else {
                return b
            }
        },
        createInstance: function(d) {
            if (!a.jqx.dataAdapter) {
                throw "jqxdata.js is not loaded"
            }
            var c = this;
            c._refreshOnDownloadComlete();
            c._isTouchDevice = a.jqx.mobile.isTouchDevice();
            c.addHandler(c.host, c._getEvent("mousemove"), function(g) {
                if (c.enabled == false) {
                    return
                }
                var f = g.pageX || g.clientX || g.screenX;
                var j = g.pageY || g.clientY || g.screenY;
                var i = c.host.offset();
                if (c._isTouchDevice) {
                    var h = a.jqx.position(g);
                    f = h.left;
                    j = h.top
                } else {
                    g.preventDefault()
                }
                f -= i.left;
                j -= i.top;
                c.onmousemove(f, j)
            });
            c.addHandler(c.host, c._getEvent("mouseleave"), function(h) {
                if (c.enabled == false) {
                    return
                }
                var f = c._mouseX;
                var i = c._mouseY;
                var g = c._plotRect;
                if (g && f >= g.x && f <= g.x + g.width && i >= g.y && i <= g.y + g.height) {
                    return
                }
                c._cancelTooltipTimer();
                c._hideToolTip(0);
                c._unselect()
            });
            c.addHandler(c.host, "click", function(g) {
                if (c.enabled == false) {
                    return
                }
                var f = g.pageX || g.clientX || g.screenX;
                var j = g.pageY || g.clientY || g.screenY;
                var i = c.host.offset();
                if (c._isTouchDevice) {
                    var h = a.jqx.position(g);
                    f = h.left;
                    j = h.top
                } else {
                    g.preventDefault()
                }
                f -= i.left;
                j -= i.top;
                c._mouseX = f;
                c._mouseY = j;
                if (!isNaN(c._lastClickTs)) {
                    if ((new Date()).valueOf() - c._lastClickTs < 100) {
                        return
                    }
                }
                this._hostClickTimer = setTimeout(function() {
                    if (!c._isTouchDevice) {
                        c._cancelTooltipTimer();
                        c._hideToolTip();
                        c._unselect()
                    }
                    if (c._pointMarker && c._pointMarker.element) {
                        var l = c.seriesGroups[c._pointMarker.gidx];
                        var k = l.series[c._pointMarker.sidx];
                        c._raiseItemEvent("click", l, k, c._pointMarker.iidx)
                    }
                }, 100)
            });
            var e = c.element.style;
            if (e) {
                var b = false;
                if (e.width != null) {
                    b |= e.width.toString().indexOf("%") != -1
                }
                if (e.height != null) {
                    b |= e.height.toString().indexOf("%") != -1
                }
                if (b) {
                    a.jqx.utilities.resize(this.host, function() {
                        if (c.timer) {
                            clearTimeout(c.timer)
                        }
                        var f = 1;
                        c.timer = setTimeout(function() {
                            var g = c.enableAnimations;
                            c.enableAnimations = false;
                            c.refresh();
                            c.enableAnimations = g
                        }, f)
                    }, false, true)
                }
            }
        },
        _refreshOnDownloadComlete: function() {
            var d = this;
            var e = this.source;
            if (e instanceof a.jqx.dataAdapter) {
                var f = e._options;
                if (f == undefined || (f != undefined && !f.autoBind)) {
                    e.autoSync = false;
                    e.dataBind()
                }
                var c = this.element.id;
                if (e.records.length == 0) {
                    var b = function() {
                        if (d.ready) {
                            d.ready()
                        }
                        d.refresh()
                    };
                    e.unbindDownloadComplete(c);
                    e.bindDownloadComplete(c, b)
                } else {
                    if (d.ready) {
                        d.ready()
                    }
                }
                e.unbindBindingUpdate(c);
                e.bindBindingUpdate(c, function() {
                    d.refresh()
                })
            }
        },
        propertyChangedHandler: function(b, c, e, d) {
            if (this.isInitialized == undefined || this.isInitialized == false) {
                return
            }
            if (c == "source") {
                this._refreshOnDownloadComlete()
            }
            this.refresh()
        },
        _initRenderer: function(b) {
            if (!a.jqx.createRenderer) {
                throw "Please include a reference to jqxdraw.js"
            }
            return a.jqx.createRenderer(this, b)
        },
        _internalRefresh: function() {
            var b = this;
            if (a.jqx.isHidden(b.host)) {
                return
            }
            b._stopAnimations();
            if (!b.renderer || (!b._isToggleRefresh && !b._isUpdate)) {
                b._isVML = false;
                b.host.empty();
                b._ttEl = undefined;
                b._initRenderer(b.host)
            }
            var d = b.renderer;
            if (!d) {
                return
            }
            var c = d.getRect();
            b._render({
                x: 1,
                y: 1,
                width: c.width,
                height: c.height
            });
            if (d instanceof a.jqx.HTML5Renderer) {
                d.refresh()
            }
            b._isUpdate = false
        },
        saveAsPNG: function(d, b, c) {
            return this._saveAsImage("png", d, b, c)
        },
        saveAsJPEG: function(d, b, c) {
            return this._saveAsImage("jpeg", d, b, c)
        },
        _saveAsImage: function(d, e, b, c) {
            return a.jqx._widgetToImage(this, d, e, b, c)
        },
        refresh: function() {
            this._internalRefresh()
        },
        update: function() {
            this._isUpdate = true;
            this._internalRefresh()
        },
        _seriesTypes: ["line", "stackedline", "stackedline100", "spline", "stackedspline", "stackedspline100", "stepline", "stackedstepline", "stackedstepline100", "area", "stackedarea", "stackedarea100", "splinearea", "stackedsplinearea", "stackedsplinearea100", "steparea", "stackedsteparea", "stackedsteparea100", "rangearea", "splinerangearea", "steprangearea", "column", "stackedcolumn", "stackedcolumn100", "rangecolumn", "scatter", "stackedscatter", "stackedscatter100", "bubble", "stackedbubble", "stackedbubble100", "pie", "donut", "candlestick", "ohlc"],
        _render: function(F) {
            var m = this;
            var J = m.renderer;
            m._colorsCache.clear();
            if (!m._isToggleRefresh && m._isUpdate && m._renderData) {
                m._renderDataClone()
            }
            m._renderData = [];
            J.clear();
            m._unselect();
            m._hideToolTip(0);
            var n = m.backgroundImage;
            if (n == undefined || n == "") {
                m.host.css({
                    "background-image": ""
                })
            } else {
                m.host.css({
                    "background-image": (n.indexOf("(") != -1 ? n : "url('" + n + "')")
                })
            }
            m._rect = F;
            var Y = m.padding || {
                left: 5,
                top: 5,
                right: 5,
                bottom: 5
            };
            var q = J.createClipRect(F);
            var L = J.beginGroup();
            J.setClip(L, q);
            var ag = J.rect(F.x, F.y, F.width - 2, F.height - 2);
            if (n == undefined || n == "") {
                J.attr(ag, {
                    fill: m.backgroundColor || m.background || "white"
                })
            } else {
                J.attr(ag, {
                    fill: "transparent"
                })
            }
            if (m.showBorderLine != false) {
                var H = m.borderLineColor == undefined ? m.borderColor : m.borderLineColor;
                if (H == undefined) {
                    H = m._defaultLineColor
                }
                var o = this.borderLineWidth;
                if (isNaN(o) || o < 0 || o > 10) {
                    o = 1
                }
                J.attr(ag, {
                    "stroke-width": o,
                    stroke: H
                })
            }
            if (a.isFunction(m.drawBefore)) {
                m.drawBefore(J, F)
            }
            var U = {
                x: Y.left,
                y: Y.top,
                width: F.width - Y.left - Y.right,
                height: F.height - Y.top - Y.bottom
            };
            m._paddedRect = U;
            var f = m.titlePadding || {
                left: 2,
                top: 2,
                right: 2,
                bottom: 2
            };
            var l;
            if (m.title && m.title.length > 0) {
                var R = m.toThemeProperty("jqx-chart-title-text", null);
                l = J.measureText(m.title, 0, {
                    "class": R
                });
                J.text(m.title, U.x + f.left, U.y + f.top, U.width - (f.left + f.right), l.height, 0, {
                    "class": R
                }, true, "center", "center");
                U.y += l.height;
                U.height -= l.height
            }
            if (m.description && m.description.length > 0) {
                var S = m.toThemeProperty("jqx-chart-title-description", null);
                l = J.measureText(m.description, 0, {
                    "class": S
                });
                J.text(m.description, U.x + f.left, U.y + f.top, U.width - (f.left + f.right), l.height, 0, {
                    "class": S
                }, true, "center", "center");
                U.y += l.height;
                U.height -= l.height
            }
            if (m.title || m.description) {
                U.y += (f.bottom + f.top);
                U.height -= (f.bottom + f.top)
            }
            var b = {
                x: U.x,
                y: U.y,
                width: U.width,
                height: U.height
            };
            m._buildStats(b);
            var I = m._isPieOnlySeries();
            var t = m.seriesGroups;
            var G;
            var B = {};
            for (var Z = 0; Z < t.length && !I; Z++) {
                if (t[Z].type == "pie" || t[Z].type == "donut") {
                    continue
                }
                G = t[Z].orientation == "horizontal";
                var E = t[Z].valueAxis;
                if (!E) {
                    E = t[Z].valueAxis = {}
                }
                var d = m._getCategoryAxis(Z);
                if (!d) {
                    throw "seriesGroup[" + Z + "] is missing " + (!G ? "xAxis" : "valueAxis") + " definition"
                }
                var v = d == m._getCategoryAxis() ? -1 : Z;
                B[v] = 0
            }
            var T = m.axisPadding;
            if (isNaN(T)) {
                T = 5
            }
            var s = {
                left: 0,
                right: 0,
                leftCount: 0,
                rightCount: 0
            };
            var p = [];
            for (Z = 0; Z < t.length; Z++) {
                var ad = t[Z];
                if (ad.type == "pie" || ad.type == "donut" || ad.spider == true || ad.polar == true) {
                    p.push({
                        width: 0,
                        position: 0,
                        xRel: 0
                    });
                    continue
                }
                G = ad.orientation == "horizontal";
                var X = m._getCategoryAxis(Z);
                var v = X == m._getCategoryAxis() ? -1 : Z;
                var E = ad.valueAxis;
                if (!E) {
                    E = ad.valueAxis = {}
                }
                var Q = !G ? E.axisSize : X.axisSize;
                var k = {
                    x: 0,
                    y: b.y,
                    width: b.width,
                    height: b.height
                };
                var P;
                if (!Q || Q == "auto") {
                    if (G) {
                        Q = this._renderCategoryAxis(Z, k, true, b).width;
                        if ((B[v] & 1) == 1) {
                            Q = 0
                        } else {
                            if (Q > 0) {
                                B[v] |= 1
                            }
                        }
                        P = m._getCategoryAxis(Z).position
                    } else {
                        Q = m._renderValueAxis(Z, k, true, b).width;
                        if (ad.valueAxis) {
                            P = ad.valueAxis.position
                        }
                    }
                }
                if (P != "left" && m.rtl == true) {
                    P = "right"
                }
                if (P != "right") {
                    P = "left"
                }
                if (s[P + "Count"] > 0 && s[P] > 0 && Q > 0) {
                    s[P] += T
                }
                p.push({
                    width: Q,
                    position: P,
                    xRel: s[P]
                });
                s[P] += Q;
                s[P + "Count"]++
            }
            var z = Math.max(1, Math.max(F.width, F.height));
            var ac = {
                top: 0,
                bottom: 0,
                topCount: 0,
                bottomCount: 0
            };
            var V = [];
            for (Z = 0; Z < t.length; Z++) {
                var ad = t[Z];
                if (ad.type == "pie" || ad.type == "donut" || ad.spider == true || ad.polar == true) {
                    V.push({
                        height: 0,
                        position: 0,
                        yRel: 0
                    });
                    continue
                }
                G = ad.orientation == "horizontal";
                var E = ad.valueAxis;
                if (!E) {
                    E = ad.valueAxis = {}
                }
                var d = m._getCategoryAxis(Z);
                var v = d == m._getCategoryAxis() ? -1 : Z;
                var P;
                var ab = !G ? d.axisSize : E.axisSize;
                if (!ab || ab == "auto") {
                    if (G) {
                        ab = m._renderValueAxis(Z, {
                            x: 0,
                            y: 0,
                            width: z,
                            height: 0
                        }, true, b).height;
                        if (m.seriesGroups[Z].valueAxis) {
                            P = ad.valueAxis.position
                        }
                    } else {
                        ab = m._renderCategoryAxis(Z, {
                            x: 0,
                            y: 0,
                            width: z,
                            height: 0
                        }, true).height;
                        if ((B[v] & 2) == 2) {
                            ab = 0
                        } else {
                            if (ab > 0) {
                                B[v] |= 2
                            }
                        }
                        P = m._getCategoryAxis(Z).position
                    }
                }
                if (P != "top") {
                    P = "bottom"
                }
                if (ac[P + "Count"] > 0 && ac[P] > 0 && ab > 0) {
                    ac[P] += T
                }
                V.push({
                    height: ab,
                    position: P,
                    yRel: ac[P]
                });
                ac[P] += ab;
                ac[P + "Count"]++
            }
            m._createAnimationGroup("series");
            m._plotRect = b;
            var u = (m.showLegend != false);
            var D = !u ? {
                width: 0,
                height: 0
            } : m._renderLegend(m.legendLayout ? m._rect : U, true);
            if (this.legendLayout && (!isNaN(this.legendLayout.left) || !isNaN(this.legendLayout.top))) {
                D = {
                    width: 0,
                    height: 0
                }
            }
            if (U.height < ac.top + ac.bottom + D.height || U.width < s.left + s.right) {
                J.endGroup();
                return
            }
            b.height -= ac.top + ac.bottom + D.height;
            b.x += s.left;
            b.width -= s.left + s.right;
            b.y += ac.top;
            var r = [];
            if (!I) {
                var ae = m._getCategoryAxis().tickMarksColor || m._defaultLineColor;
                for (Z = 0; Z < t.length; Z++) {
                    var ad = t[Z];
                    if (ad.polar == true || ad.spider == true) {
                        continue
                    }
                    G = ad.orientation == "horizontal";
                    var v = m._getCategoryAxis(Z) == m._getCategoryAxis() ? -1 : Z;
                    var k = {
                        x: b.x,
                        y: 0,
                        width: b.width,
                        height: V[Z].height
                    };
                    if (V[Z].position != "top") {
                        k.y = b.y + b.height + V[Z].yRel
                    } else {
                        k.y = b.y - V[Z].yRel - V[Z].height
                    }
                    if (G) {
                        m._renderValueAxis(Z, k, false, b)
                    } else {
                        r.push(k);
                        if ((B[v] & 4) == 4) {
                            continue
                        }
                        if (!m._isGroupVisible(Z)) {
                            continue
                        }
                        m._renderCategoryAxis(Z, k, false, b);
                        B[v] |= 4
                    }
                }
            }
            if (u) {
                var C = m.legendLayout ? m._rect : U;
                var O = U.x + a.jqx._ptrnd((U.width - D.width) / 2);
                var N = b.y + b.height + ac.bottom;
                var Q = U.width;
                var ab = D.height;
                if (m.legendLayout) {
                    if (!isNaN(m.legendLayout.left)) {
                        O = m.legendLayout.left
                    }
                    if (!isNaN(m.legendLayout.top)) {
                        N = m.legendLayout.top
                    }
                    if (!isNaN(m.legendLayout.width)) {
                        Q = m.legendLayout.width
                    }
                    if (!isNaN(m.legendLayout.height)) {
                        ab = m.legendLayout.height
                    }
                }
                if (O + Q > C.x + C.width) {
                    Q = C.x + C.width - O
                }
                if (N + ab > C.y + C.height) {
                    ab = C.y + C.height - N
                }
                m._renderLegend({
                    x: O,
                    y: N,
                    width: Q,
                    height: ab
                })
            }
            m._hasHorizontalLines = false;
            if (!I) {
                for (Z = 0; Z < t.length; Z++) {
                    var ad = t[Z];
                    if (ad.polar == true || ad.spider == true) {
                        continue
                    }
                    G = t[Z].orientation == "horizontal";
                    var k = {
                        x: b.x - p[Z].xRel - p[Z].width,
                        y: b.y,
                        width: p[Z].width,
                        height: b.height
                    };
                    if (p[Z].position != "left") {
                        k.x = b.x + b.width + p[Z].xRel
                    }
                    if (G) {
                        r.push(k);
                        if ((B[m._getCategoryAxis(Z)] & 8) == 8) {
                            continue
                        }
                        if (!m._isGroupVisible(Z)) {
                            continue
                        }
                        m._renderCategoryAxis(Z, k, false, b);
                        B[m._getCategoryAxis(Z)] |= 8
                    } else {
                        m._renderValueAxis(Z, k, false, b)
                    }
                }
            }
            if (b.width <= 0 || b.height <= 0) {
                return
            }
            m._plotRect = {
                x: b.x,
                y: b.y,
                width: b.width,
                height: b.height
            };
            for (Z = 0; Z < t.length; Z++) {
                this._drawPlotAreaLines(Z, true, {
                    gridLines: false,
                    tickMarks: false,
                    alternatingBackground: true
                });
                this._drawPlotAreaLines(Z, false, {
                    gridLines: false,
                    tickMarks: false,
                    alternatingBackground: true
                })
            }
            for (Z = 0; Z < t.length; Z++) {
                this._drawPlotAreaLines(Z, true, {
                    gridLines: true,
                    tickMarks: true,
                    alternatingBackground: false
                });
                this._drawPlotAreaLines(Z, false, {
                    gridLines: true,
                    tickMarks: true,
                    alternatingBackground: false
                })
            }
            var K = J.createClipRect({
                x: b.x - 2,
                y: b.y,
                width: b.width + 4,
                height: b.height
            });
            var M = J.beginGroup();
            J.setClip(M, K);
            for (Z = 0; Z < t.length; Z++) {
                var ad = t[Z];
                var c = false;
                for (var af in m._seriesTypes) {
                    if (m._seriesTypes[af] == ad.type) {
                        c = true;
                        break
                    }
                }
                if (!c) {
                    throw 'jqxChart: invalid series type "' + ad.type + '"'
                }
                if (a.isFunction(ad.drawBefore)) {
                    ad.drawBefore(J, F, Z)
                }
                if (ad.polar == true || ad.spider == true) {
                    if (ad.type.indexOf("pie") == -1 && ad.type.indexOf("donut") == -1) {
                        m._renderSpiderAxis(Z, b)
                    }
                }
                if (ad.bands) {
                    for (var W = 0; W < ad.bands.length; W++) {
                        m._renderBand(Z, W, b)
                    }
                }
                if (ad.type.indexOf("column") != -1) {
                    m._renderColumnSeries(Z, b)
                } else {
                    if (ad.type.indexOf("pie") != -1 || ad.type.indexOf("donut") != -1) {
                        m._renderPieSeries(Z, b)
                    } else {
                        if (ad.type.indexOf("line") != -1 || ad.type.indexOf("area") != -1) {
                            m._renderLineSeries(Z, b)
                        } else {
                            if (ad.type.indexOf("scatter") != -1 || ad.type.indexOf("bubble") != -1) {
                                m._renderScatterSeries(Z, b)
                            } else {
                                if (ad.type.indexOf("candlestick") != -1) {
                                    m._renderCandleStickSeries(Z, b, false)
                                } else {
                                    if (ad.type.indexOf("ohlc") != -1) {
                                        m._renderCandleStickSeries(Z, b, true)
                                    }
                                }
                            }
                        }
                    }
                }
                if (a.isFunction(ad.draw)) {
                    m.draw(J, F, Z)
                }
            }
            J.endGroup();
            if (m.enabled == false) {
                var aa = J.rect(F.x, F.y, F.width, F.height);
                J.attr(aa, {
                    fill: "#777777",
                    opacity: 0.5,
                    stroke: "#00FFFFFF"
                })
            }
            if (a.isFunction(m.draw)) {
                m.draw(J, F)
            }
            J.endGroup();
            m._startAnimation("series");
            if (this._renderCategoryAxisRangeSelector) {
                var e = [];
                if (!this._isSelectorRefresh) {
                    m.removeHandler(a(document), m._getEvent("mousemove"), m._onSliderMouseMove);
                    m.removeHandler(a(document), m._getEvent("mousedown"), m._onSliderMouseDown);
                    m.removeHandler(a(document), m._getEvent("mouseup"), m._onSliderMouseUp)
                }
                for (Z = 0; Z < m.seriesGroups.length; Z++) {
                    var A = this._getCategoryAxis(Z);
                    if (e.indexOf(A) == -1) {
                        if (this._renderCategoryAxisRangeSelector(Z, r[Z])) {
                            e.push(A)
                        }
                    }
                }
            }
        },
        _isPieOnlySeries: function() {
            var c = this.seriesGroups;
            if (c.length == 0) {
                return false
            }
            for (var b = 0; b < c.length; b++) {
                if (c[b].type != "pie" && c[b].type != "donut") {
                    return false
                }
            }
            return true
        },
        _renderChartLegend: function(S, C, Q, u) {
            var k = this;
            var D = k.renderer;
            var I = {
                x: C.x + 3,
                y: C.y + 3,
                width: C.width - 6,
                height: C.height - 6
            };
            var E = {
                width: I.width,
                height: 0
            };
            var G = 0,
                F = 0;
            var p = 20;
            var l = 0;
            var f = 10;
            var O = 10;
            var v = 0;
            for (var N = 0; N < S.length; N++) {
                var J = S[N].css;
                if (!J) {
                    J = k.toThemeProperty("jqx-chart-legend-text", null)
                }
                p = 20;
                var A = S[N].text;
                var j = D.measureText(A, 0, {
                    "class": J
                });
                if (j.height > p) {
                    p = j.height
                }
                if (j.width > v) {
                    v = j.width
                }
                if (u) {
                    if (N != 0) {
                        F += p
                    }
                    if (F > I.height) {
                        F = 0;
                        G += v + 2 * O + f;
                        v = j.width;
                        E.width = G + v
                    }
                } else {
                    if (G != 0) {
                        G += O
                    }
                    if (G + 2 * f + j.width > I.width && j.width < I.width) {
                        G = 0;
                        F += p;
                        p = 20;
                        l = I.width;
                        E.height = F + p
                    }
                }
                var K = false;
                if (j.width > C.width) {
                    K = true;
                    var q = C.width;
                    var R = A;
                    var U = R.split(/\s+/).reverse();
                    var m = [];
                    var s = "";
                    var o = [];
                    while (undefined != (word = U.pop())) {
                        m.push(word);
                        s = m.join(" ");
                        var B = k.renderer.measureText(s, 0, {
                            "class": J
                        });
                        if (B.width > q && o.length > 0) {
                            m.pop();
                            m = [word];
                            s = m.join(" ")
                        }
                        o.push({
                            text: s
                        })
                    }
                    j.width = 0;
                    var b = 0;
                    for (var H = 0; H < o.length; H++) {
                        var T = o[H].text;
                        var B = k.renderer.measureText(T, 0, {
                            "class": J
                        });
                        j.width = Math.max(j.width, B.width);
                        b += j.height
                    }
                    j.height = b
                }
                var w = I.x + G + j.width < C.x + C.width && I.y + F + j.height < C.y + C.height;
                if (k.legendLayout) {
                    var w = I.x + G + j.width < k._rect.x + k._rect.width && I.y + F + j.height < k._rect.y + k._rect.height
                }
                if (!Q && w) {
                    var h = S[N].seriesIndex;
                    var n = S[N].groupIndex;
                    var c = S[N].itemIndex;
                    var z = S[N].color;
                    var e = k._isSerieVisible(n, h, c);
                    var P = D.beginGroup();
                    var M = e ? S[N].opacity : 0.1;
                    if (K) {
                        var R = A;
                        var q = C.width;
                        var U = R.split(/\s+/).reverse();
                        var m = [];
                        var s = "";
                        var d = 0;
                        var o = [];
                        while (undefined != (word = U.pop())) {
                            m.push(word);
                            s = m.join(" ");
                            var B = k.renderer.measureText(s, 0, {
                                "class": J
                            });
                            if (B.width > q && o.length > 0) {
                                m.pop();
                                d += B.height;
                                m = [word];
                                s = m.join(" ")
                            }
                            o.push({
                                text: s,
                                dy: d
                            })
                        }
                        for (var H = 0; H < o.length; H++) {
                            var T = o[H].text;
                            d = o[H].dy;
                            var B = k.renderer.measureText(T, 0, {
                                "class": J
                            });
                            if (u) {
                                k.renderer.text(T, I.x + G + 1.5 * f, I.y + F + d, j.width, p, 0, {
                                    "class": J
                                }, false, "left", "center")
                            } else {
                                k.renderer.text(T, I.x + G + 1.5 * f, I.y + F + d, j.width, p, 0, {
                                    "class": J
                                }, false, "center", "center")
                            }
                        }
                        var L = D.rect(I.x + G, I.y + F + f / 2 + d / 2, f, f);
                        if (u) {
                            F += d
                        }
                        k.renderer.attr(L, {
                            fill: z,
                            "fill-opacity": M,
                            stroke: z,
                            "stroke-width": 1,
                            "stroke-opacity": S[N].opacity
                        })
                    } else {
                        var L = D.rect(I.x + G, I.y + F + f / 2, f, f);
                        k.renderer.attr(L, {
                            fill: z,
                            "fill-opacity": M,
                            stroke: z,
                            "stroke-width": 1,
                            "stroke-opacity": S[N].opacity
                        });
                        if (u) {
                            k.renderer.text(A, I.x + G + 1.5 * f, I.y + F, j.width, j.height + f / 2, 0, {
                                "class": J
                            }, false, "left", "center")
                        } else {
                            k.renderer.text(A, I.x + G + 1.5 * f, I.y + F, j.width, p, 0, {
                                "class": J
                            }, false, "center", "center")
                        }
                    }
                    k.renderer.endGroup();
                    k._setLegendToggleHandler(n, h, c, P)
                }
                if (u) {} else {
                    G += j.width + 2 * f;
                    if (l < G) {
                        l = G
                    }
                }
            }
            if (Q) {
                E.height = a.jqx._ptrnd(F + p + 5);
                E.width = a.jqx._ptrnd(l);
                return E
            }
        },
        _isSerieVisible: function(f, b, d) {
            while (this._itemsToggleState.length < f + 1) {
                this._itemsToggleState.push([])
            }
            var e = this._itemsToggleState[f];
            while (e.length < b + 1) {
                e.push(isNaN(d) ? true : [])
            }
            var c = e[b];
            if (isNaN(d)) {
                return c
            }
            if (!a.isArray(c)) {
                e[b] = c = []
            }
            while (c.length < d + 1) {
                c.push(true)
            }
            return c[d]
        },
        _isGroupVisible: function(e) {
            var d = false;
            var c = this.seriesGroups[e].series;
            if (!c) {
                return d
            }
            for (var b = 0; b < c.length; b++) {
                if (this._isSerieVisible(e, b)) {
                    d = true;
                    break
                }
            }
            return d
        },
        _toggleSerie: function(h, b, e, c) {
            var g = !this._isSerieVisible(h, b, e);
            if (c != undefined) {
                g = c
            }
            var i = this.seriesGroups[h];
            var f = i.series[b];
            this._raiseEvent("toggle", {
                state: g,
                seriesGroup: i,
                serie: f,
                elementIndex: e
            });
            if (isNaN(e)) {
                this._itemsToggleState[h][b] = g
            } else {
                var d = this._itemsToggleState[h][b];
                if (!a.isArray(d)) {
                    d = []
                }
                while (d.length < e) {
                    d.push(true)
                }
                d[e] = g
            }
            this._isToggleRefresh = true;
            this.update();
            this._isToggleRefresh = false
        },
        showSerie: function(d, b, c) {
            this._toggleSerie(d, b, c, true)
        },
        hideSerie: function(d, b, c) {
            this._toggleSerie(d, b, c, false)
        },
        _setLegendToggleHandler: function(j, c, h, e) {
            var i = this.seriesGroups[j];
            var f = i.series[c];
            var b = f.enableSeriesToggle;
            if (b == undefined) {
                b = i.enableSeriesToggle != false
            }
            if (b) {
                var d = this;
                this.renderer.addHandler(e, "click", function(g) {
                    g.preventDefault();
                    d._toggleSerie(j, c, h)
                })
            }
        },
        _renderLegend: function(o, n) {
            var r = this;
            var d = [];
            for (var q = 0; q < r.seriesGroups.length; q++) {
                var l = r.seriesGroups[q];
                if (l.showLegend == false) {
                    continue
                }
                for (var p = 0; p < l.series.length; p++) {
                    var t = l.series[p];
                    if (t.showLegend == false) {
                        continue
                    }
                    var h = r._getSerieSettings(q, p);
                    var m;
                    if (l.type == "pie" || l.type == "donut") {
                        var f = r._getCategoryAxis(q);
                        var k = t.legendFormatSettings || l.legendFormatSettings || f.formatSettings || t.formatSettings || l.formatSettings;
                        var c = t.legendFormatFunction || l.legendFormatFunction || f.formatFunction || t.formatFunction || l.formatFunction;
                        var e = r._getDataLen(q);
                        for (var j = 0; j < e; j++) {
                            m = r._getDataValue(j, t.displayText, q);
                            m = r._formatValue(m, k, c, q, p, j);
                            var b = r._getColors(q, p, j);
                            d.push({
                                groupIndex: q,
                                seriesIndex: p,
                                itemIndex: j,
                                text: m,
                                css: t.displayTextClass,
                                color: b.fillColor,
                                opacity: h.opacity
                            })
                        }
                        continue
                    }
                    var k = t.legendFormatSettings || l.legendFormatSettings;
                    var c = t.legendFormatFunction || l.legendFormatFunction;
                    m = r._formatValue(t.displayText || t.dataField || "", k, c, q, p, NaN);
                    var b = r._getSeriesColors(q, p);
                    d.push({
                        groupIndex: q,
                        seriesIndex: p,
                        text: m,
                        css: t.displayTextClass,
                        color: b.fillColor,
                        opacity: h.opacity
                    })
                }
            }
            return r._renderChartLegend(d, o, n, (r.legendLayout && r.legendLayout.flow == "vertical"))
        },
        _renderCategoryAxis: function(e, B, S, d) {
            var j = this;
            var t = j._getCategoryAxis(e);
            var R = j.seriesGroups[e];
            var Z = R.orientation == "horizontal";
            var J = {
                width: 0,
                height: 0
            };
            if (!t || t.visible == false || R.type == "spider") {
                return J
            }
            if (!j._isGroupVisible(e)) {
                return J
            }
            var Y = j._alignValuesWithTicks(e);
            if (j.rtl) {
                t.flip = true
            }
            var E = Z ? B.height : B.width;
            var z = t.text;
            var v = j._calculateXOffsets(e, E);
            var V = v.axisStats;
            var l = t.rangeSelector;
            var H = 0;
            if (l) {
                if (!this._selectorGetSize) {
                    throw new Error("jqxChart: Missing reference to jqxchart.rangeselector.js")
                }
                H = this._selectorGetSize(t)
            }
            var I = V.interval;
            if (isNaN(I)) {
                return
            }
            var f = {
                visible: (t.showGridLines != false),
                color: (t.gridLinesColor || j._defaultLineColor),
                unitInterval: (t.gridLinesInterval || I),
                dashStyle: t.gridLinesDashStyle,
                offsets: [],
                alternatingBackgroundColor: t.alternatingBackgroundColor,
                alternatingBackgroundColor2: t.alternatingBackgroundColor2,
                alternatingBackgroundOpacity: t.alternatingBackgroundOpacity
            };
            var C = {
                visible: (t.showTickMarks != false),
                color: (t.tickMarksColor || j._defaultLineColor),
                unitInterval: (t.tickMarksInterval || I),
                dashStyle: t.tickMarksDashStyle,
                offsets: []
            };
            var r = t.textRotationAngle || 0;
            var M;
            var X = V.min;
            var u = V.max;
            var P = v.padding;
            var U = t.flip == true || j.rtl;
            if (t.type == "date") {
                f.offsets = this._generateDTOffsets(X, u, E, P, f.unitInterval, I, V.dateTimeUnit, Y, NaN, false, U);
                C.offsets = this._generateDTOffsets(X, u, E, P, C.unitInterval, I, V.dateTimeUnit, Y, NaN, false, U);
                M = this._generateDTOffsets(X, u, E, P, I, I, V.dateTimeUnit, Y, NaN, true, U)
            } else {
                f.offsets = this._generateOffsets(X, u, E, P, f.unitInterval, I, Y, NaN, false, U);
                C.offsets = this._generateOffsets(X, u, E, P, C.unitInterval, I, Y, NaN, false, U);
                M = this._generateOffsets(X, u, E, P, I, I, Y, NaN, true, U)
            }
            if (v.length == 0) {
                M = []
            }
            var c = t.horizontalTextAlignment;
            var o = j.renderer.getRect();
            var n = o.width - B.x - B.width;
            var q = j._getDataLen(e);
            var p;
            if (j._elementRenderInfo && j._elementRenderInfo.length > e) {
                p = j._elementRenderInfo[e].xAxis
            }
            var s = [];
            var L = t.formatFunction;
            var y = t.formatSettings;
            if (t.type == "date" && !y && !L) {
                L = this._getDefaultDTFormatFn(t.baseUnit || "day")
            }
            for (var Q = 0; Q < M.length; Q++) {
                var O = M[Q].value;
                var K = M[Q].offset;
                if (t.type != "date" && V.useIndeces && t.dataField) {
                    var W = Math.round(O);
                    O = j._getDataValue(W, t.dataField);
                    if (O == undefined) {
                        O = ""
                    }
                }
                var z = j._formatValue(O, y, L, e, undefined, Q);
                if (z == undefined || z.toString() == "") {
                    z = V.useIndeces ? (V.min + Q).toString() : (O == undefined ? "" : O.toString())
                }
                var b = {
                    key: O,
                    text: z,
                    targetX: K,
                    x: K
                };
                if (p && p.itemOffsets[O]) {
                    b.x = p.itemOffsets[O].x;
                    b.y = p.itemOffsets[O].y
                }
                s.push(b)
            }
            var N = t.descriptionClass;
            if (!N) {
                N = j.toThemeProperty("jqx-chart-axis-description", null)
            }
            var A = t["class"];
            if (!A) {
                A = j.toThemeProperty("jqx-chart-axis-text", null)
            }
            if (Z) {
                r -= 90
            }
            var T = {
                text: t.description,
                style: N,
                halign: t.horizontalDescriptionAlignment || "center",
                valign: t.verticalDescriptionAlignment || "center",
                textRotationAngle: Z ? -90 : 0
            };
            var k = {
                textRotationAngle: r,
                style: A,
                halign: c,
                valign: t.verticalTextAlignment || "center",
                textRotationPoint: t.textRotationPoint || "auto",
                textOffset: t.textOffset
            };
            var G = (Z && t.position == "right") || (!Z && t.position == "top");
            var m = {
                rangeLength: v.rangeLength,
                itemWidth: v.itemWidth,
                intervalWidth: v.intervalWidth,
                data: v,
                rect: B
            };
            var D = {
                items: s,
                renderData: m
            };
            while (j._renderData.length < e + 1) {
                j._renderData.push({})
            }
            j._renderData[e].xAxis = m;
            var F = j._getAnimProps(e);
            var w = F.enabled && s.length < 500 ? F.duration : 0;
            if (j.enableAxisTextAnimation == false) {
                w = 0
            }
            if (!S && l) {
                if (Z) {
                    B.width -= H;
                    if (t.position != "right") {
                        B.x += H
                    }
                } else {
                    B.height -= H;
                    if (t.position == "top") {
                        B.y += H
                    }
                }
            }
            m.gridLinesSettings = f;
            m.tickMarksSettings = C;
            m.isMirror = G;
            m.rect = B;
            var h = j._renderAxis(Z, G, T, k, {
                x: B.x,
                y: B.y,
                width: B.width,
                height: B.height
            }, d, I, false, true, D, f, C, S, w);
            if (Z) {
                h.width += H
            } else {
                h.height += H
            }
            return h
        },
        _animateAxisText: function(f, h) {
            var c = f.items;
            var d = f.textSettings;
            for (var e = 0; e < c.length; e++) {
                var g = c[e];
                if (!g.visible) {
                    continue
                }
                var b = g.targetX;
                var j = g.targetY;
                if (!isNaN(g.x) && !isNaN(g.y)) {
                    b = g.x + (b - g.x) * h;
                    j = g.y + (j - g.y) * h
                }
                if (g.element) {
                    this.renderer.removeElement(g.element);
                    g.element = undefined
                }
                g.element = this.renderer.text(g.text, b, j, g.width, g.height, d.textRotationAngle, {
                    "class": d.style
                }, false, d.halign, d.valign, d.textRotationPoint)
            }
        },
        _getPolarAxisCoords: function(j, h) {
            var i = this.seriesGroups[j];
            var c = this._calcGroupOffsets(j, h).xoffsets;
            if (!c) {
                return
            }
            var e = h.x + a.jqx.getNum([i.offsetX, h.width / 2]);
            var d = h.y + a.jqx.getNum([i.offsetY, h.height / 2]);
            var f = i.radius;
            if (isNaN(f)) {
                f = Math.min(h.width, h.height) / 2 * 0.6
            }
            var b = this._alignValuesWithTicks(j);
            var g = i.startAngle;
            if (isNaN(g)) {
                g = 0
            } else {
                g = (g < 0 ? -1 : 1) * (Math.abs(g) % 360);
                g = 2 * Math.PI * g / 360
            }
            return {
                x: e,
                y: d,
                r: f,
                itemWidth: c.itemWidth,
                rangeLength: c.rangeLength,
                valuesOnTicks: b,
                startAngle: g
            }
        },
        _toPolarCoord: function(d, g, c, i) {
            var h = ((c - g.x) * 2 * Math.PI) / Math.max(1, g.width) + d.startAngle;
            var b = ((g.height + g.y) - i) * d.r / Math.max(1, g.height);
            var f = d.x + b * Math.cos(h);
            var e = d.y + b * Math.sin(h);
            return {
                x: a.jqx._ptrnd(f),
                y: a.jqx._ptrnd(e)
            }
        },
        _renderSpiderAxis: function(e, H) {
            var l = this;
            var C = l._getCategoryAxis(e);
            if (!C || C.visible == false) {
                return
            }
            var w = l.seriesGroups[e];
            var I = l._getPolarAxisCoords(e, H);
            if (!I) {
                return
            }
            var S = a.jqx._ptrnd(I.x);
            var P = a.jqx._ptrnd(I.y);
            var W = I.r;
            var k = I.startAngle;
            if (W < 1) {
                return
            }
            W = a.jqx._ptrnd(W);
            var L = Math.PI * 2 * W;
            var E = l._calculateXOffsets(e, L);
            if (!E.rangeLength) {
                return
            }
            var O = C.unitInterval;
            if (isNaN(O) || O < 1) {
                O = 1
            }
            var f = {
                visible: (C.showGridLines != false),
                color: (C.gridLinesColor || l._defaultLineColor),
                unitInterval: (C.gridLinesInterval || C.unitInterval || O),
                dashStyle: C.gridLinesDashStyle,
                offsets: []
            };
            var J = {
                visible: (C.showTickMarks != false),
                color: (C.tickMarksColor || l._defaultLineColor),
                unitInterval: (C.tickMarksInterval || C.unitInterval || O),
                dashStyle: C.tickMarksDashStyle,
                offsets: []
            };
            var d = C.horizontalTextAlignment;
            var ah = l._alignValuesWithTicks(e);
            var N = l.renderer;
            var T;
            var ae = E.axisStats;
            var ag = ae.min;
            var D = ae.max;
            var Y = this._getPaddingSize(E.axisStats, C, ah, L, true, false);
            var ac = C.flip == true || l.rtl;
            if (C.type == "date") {
                f.offsets = this._generateDTOffsets(ag, D, L, Y, f.unitInterval, O, C.baseUnit, false, 0, false, ac);
                J.offsets = this._generateDTOffsets(ag, D, L, Y, J.unitInterval, O, C.baseUnit, false, 0, false, ac);
                T = this._generateDTOffsets(ag, D, L, Y, O, O, C.baseUnit, false, 0, true, ac)
            } else {
                f.offsets = this._generateOffsets(ag, D, L, Y, f.unitInterval, O, true, 0, false, ac);
                J.offsets = this._generateOffsets(ag, D, L, Y, J.unitInterval, O, true, 0, false, ac);
                T = this._generateOffsets(ag, D, L, Y, O, O, true, 0, false, ac)
            }
            var d = C.horizontalTextAlignment;
            var r = l.renderer.getRect();
            var q = r.width - H.x - H.width;
            var v = l._getDataLen(e);
            var t;
            if (l._elementRenderInfo && l._elementRenderInfo.length > e) {
                t = l._elementRenderInfo[e].xAxis
            }
            var z = [];
            for (var Z = 0; Z < T.length; Z++) {
                var Q = T[Z].offset;
                var V = T[Z].value;
                if (C.type != "date" && ae.useIndeces && C.dataField) {
                    var af = Math.round(V);
                    V = l._getDataValue(af, C.dataField);
                    if (V == undefined) {
                        V = ""
                    }
                }
                var F = l._formatValue(V, C.formatSettings, C.formatFunction, e, undefined, Z);
                if (F == undefined || F.toString() == "") {
                    F = ae.useIndeces ? (ae.min + Z).toString() : (V == undefined ? "" : V.toString())
                }
                var c = {
                    key: V,
                    text: F,
                    targetX: Q,
                    x: Q
                };
                if (t && t.itemOffsets[V]) {
                    c.x = t.itemOffsets[V].x;
                    c.y = t.itemOffsets[V].y
                }
                z.push(c)
            }
            var U = C.descriptionClass;
            if (!U) {
                U = l.toThemeProperty("jqx-chart-axis-description", null)
            }
            var G = C["class"];
            if (!G) {
                G = l.toThemeProperty("jqx-chart-axis-text", null)
            }
            var F = C.text;
            var y = C.textRotationAngle || 0;
            var ai = l.seriesGroups[e].orientation == "horizontal";
            if (ai) {
                y -= 90
            }
            var ab = {
                text: C.description,
                style: U,
                halign: C.horizontalDescriptionAlignment || "center",
                valign: C.verticalDescriptionAlignment || "center",
                textRotationAngle: ai ? -90 : 0
            };
            var n = {
                textRotationAngle: y,
                style: G,
                halign: d,
                valign: C.verticalTextAlignment || "center",
                textRotationPoint: C.textRotationPoint || "auto",
                textOffset: C.textOffset
            };
            var M = (ai && C.position == "right") || (!ai && C.position == "top");
            var p = {
                rangeLength: E.rangeLength,
                itemWidth: E.itemWidth
            };
            var K = {
                items: z,
                renderData: p
            };
            while (l._renderData.length < e + 1) {
                l._renderData.push({})
            }
            l._renderData[e].xAxis = p;
            var o = {
                stroke: f.color,
                fill: "none",
                "stroke-width": 1,
                "stroke-dasharray": f.dashStyle || ""
            };
            var X = N.circle(S, P, W, o);
            var A = z.length;
            var m = 2 * Math.PI / (A);
            var b = k;
            for (var Z = 0; Z < z.length; Z++) {
                var R = z[Z].x;
                var u = b + (R * 2 * Math.PI) / Math.max(1, L);
                u = (360 - u / (2 * Math.PI) * 360) % 360;
                if (u < 0) {
                    u = 360 + u
                }
                var j = N.measureText(z[Z].text, 0, {
                    "class": G
                });
                var B = this._adjustTextBoxPosition(S, P, j, W + (J.visible ? 7 : 2), u, false, false, true);
                N.text(z[Z].text, B.x, B.y, j.width, j.height, 0, {
                    "class": G
                }, false, "center", "center")
            }
            if (f.visible) {
                for (var Z = 0; Z < f.offsets.length; Z++) {
                    var R = f.offsets[Z].offset;
                    if (!ah) {
                        R -= Y.right / 2
                    }
                    var u = b + (R * 2 * Math.PI) / Math.max(1, L);
                    var h = S + W * Math.cos(u);
                    var g = P + W * Math.sin(u);
                    N.line(S, P, a.jqx._ptrnd(h), a.jqx._ptrnd(g), o)
                }
            }
            if (J.visible) {
                var s = 5;
                var o = {
                    stroke: J.color,
                    fill: "none",
                    "stroke-width": 1,
                    "stroke-dasharray": J.dashStyle || ""
                };
                for (var Z = 0; Z < J.offsets.length; Z++) {
                    var R = J.offsets[Z].offset;
                    if (!ah) {
                        R -= Y.right / 2
                    }
                    var u = b + (R * 2 * Math.PI) / Math.max(1, L);
                    var ad = {
                        x: S + W * Math.cos(u),
                        y: P + W * Math.sin(u)
                    };
                    var aa = {
                        x: S + (W + s) * Math.cos(u),
                        y: P + (W + s) * Math.sin(u)
                    };
                    N.line(a.jqx._ptrnd(ad.x), a.jqx._ptrnd(ad.y), a.jqx._ptrnd(aa.x), a.jqx._ptrnd(aa.y), o)
                }
            }
            l._renderSpiderValueAxis(e, H)
        },
        _renderSpiderValueAxis: function(e, c) {
            var t = this;
            var j = this.seriesGroups[e];
            var u = this._getPolarAxisCoords(e, c);
            if (!u) {
                return
            }
            var H = a.jqx._ptrnd(u.x);
            var G = a.jqx._ptrnd(u.y);
            var g = u.r;
            var A = u.startAngle;
            if (g < 1) {
                return
            }
            g = a.jqx._ptrnd(g);
            var E = this.seriesGroups[e].valueAxis;
            if (!E || false == E.displayValueAxis || false == E.visible) {
                return
            }
            var n = E["class"];
            if (!n) {
                n = this.toThemeProperty("jqx-chart-axis-text", null)
            }
            var m = E.formatSettings;
            var d = j.type.indexOf("stacked") != -1 && j.type.indexOf("100") != -1;
            if (d && !m) {
                m = {
                    sufix: "%"
                }
            }
            this._calcValueAxisItems(e, g);
            var h = this._stats.seriesGroups[e].mu;
            var f = {
                visible: (E.showGridLines != false),
                color: (E.gridLinesColor || t._defaultLineColor),
                unitInterval: (E.gridLinesInterval || h || 1),
                dashStyle: E.gridLinesDashStyle
            };
            var b = {
                stroke: f.color,
                fill: "none",
                "stroke-width": 1,
                "stroke-dasharray": f.dashStyle || ""
            };
            var p = this._renderData[e].valueAxis;
            var s = p.items;
            if (s.length) {
                this.renderer.line(H, G, H, a.jqx._ptrnd(G - g), b)
            }
            s = s.reverse();
            var w = this.renderer;
            for (var B = 0; B < s.length - 1; B++) {
                var v = s[B];
                var o = (E.formatFunction) ? E.formatFunction(v) : this._formatNumber(v, m);
                var q = w.measureText(o, 0, {
                    "class": n
                });
                var l = H + (E.showTickMarks != false ? 3 : 2);
                var k = G - p.itemWidth * B - q.height;
                w.text(o, l, k, q.width, q.height, 0, {
                    "class": n
                }, false, "center", "center")
            }
            var r = E.logarithmicScale == true;
            var D = r ? s.length : p.rangeLength;
            aIncrement = 2 * Math.PI / D;
            if (f.visible) {
                var b = {
                    stroke: f.color,
                    fill: "none",
                    "stroke-width": 1,
                    "stroke-dasharray": f.dashStyle || ""
                };
                for (var B = 0; B < D; B += f.unitInterval) {
                    var k = a.jqx._ptrnd(g * B / D);
                    w.circle(H, G, k, b)
                }
            }
            var z = {
                visible: (E.showTickMarks != false),
                color: (E.tickMarksColor || t._defaultLineColor),
                unitInterval: (E.tickMarksInterval || h),
                dashStyle: E.tickMarksDashStyle
            };
            if (z.visible) {
                tickMarkSize = 5;
                var b = {
                    stroke: z.color,
                    fill: "none",
                    "stroke-width": 1,
                    "stroke-dasharray": z.dashStyle || ""
                };
                var F = H - Math.round(tickMarkSize / 2);
                var C = F + tickMarkSize;
                for (var B = 0; B < D; B += z.unitInterval) {
                    if (f.visible && (B % f.unitInterval) == 0) {
                        continue
                    }
                    var k = a.jqx._ptrnd(G - g * B / D);
                    w.line(a.jqx._ptrnd(F), k, a.jqx._ptrnd(C), k, b)
                }
            }
        },
        _renderAxis: function(H, D, S, o, z, c, F, n, T, C, e, A, R, d) {
            var p = A.visible ? 4 : 0;
            var O = 2;
            var G = {
                width: 0,
                height: 0
            };
            var q = {
                width: 0,
                height: 0
            };
            if (H) {
                G.height = q.height = z.height
            } else {
                G.width = q.width = z.width
            }
            if (!R && D) {
                if (H) {
                    z.x -= z.width
                }
            }
            var m = C.renderData;
            var b = m.itemWidth;
            if (S.text != undefined && S != "") {
                var r = S.textRotationAngle;
                var f = this.renderer.measureText(S.text, r, {
                    "class": S.style
                });
                q.width = f.width;
                q.height = f.height;
                if (!R) {
                    this.renderer.text(S.text, z.x + (H ? (!D ? O : -O + 2 * z.width - q.width) : 0), z.y + (!H ? (!D ? z.height - O - q.height : O) : 0), H ? q.width : z.width, !H ? q.height : z.height, r, {
                        "class": S.style
                    }, true, S.halign, S.valign)
                }
            }
            var L = 0;
            var u = T ? -b / 2 : 0;
            if (T && !H) {
                o.halign = "center"
            }
            var N = z.x;
            var M = z.y;
            var E = o.textOffset;
            if (E) {
                if (!isNaN(E.x)) {
                    N += E.x
                }
                if (!isNaN(E.y)) {
                    M += E.y
                }
            }
            if (!H) {
                N += u;
                if (D) {
                    M += q.height > 0 ? q.height + 3 * O : 2 * O;
                    M += p - (T ? p : p / 4)
                } else {
                    M += T ? p : p / 4
                }
            } else {
                N += O + (q.width > 0 ? q.width + O : 0) + (D ? z.width - q.width : 0);
                M += u
            }
            var Q = 0;
            var K = 0;
            var s = C.items;
            m.itemOffsets = {};
            if (this._isToggleRefresh || !this._isUpdate) {
                d = 0
            }
            var l = false;
            var j = 0;
            for (var P = 0; P < s.length; P++, L += b) {
                var v = s[P].text;
                if (!isNaN(s[P].targetX)) {
                    L = s[P].targetX
                }
                var f = this.renderer.measureText(v, o.textRotationAngle, {
                    "class": o.style
                });
                if (f.width > K) {
                    K = f.width
                }
                if (f.height > Q) {
                    Q = f.height
                }
                j += H ? Q : K;
                if (!R) {
                    if ((H && L > z.height + 2) || (!H && L > z.width + 2)) {
                        break
                    }
                    var J = H ? N + (D ? (q.width == 0 ? p : p - O) : 0) : N + L;
                    var I = H ? M + L : M;
                    m.itemOffsets[s[P].key] = {
                        x: J,
                        y: I
                    };
                    if (!l) {
                        if (!isNaN(s[P].x) || !isNaN(s[P].y) && d) {
                            l = true
                        }
                    }
                    s[P].targetX = J;
                    s[P].targetY = I;
                    s[P].width = !H ? b : z.width - 2 * O - p - ((q.width > 0) ? q.width + O : 0);
                    s[P].height = H ? b : z.height - 2 * O - p - ((q.height > 0) ? q.height + O : 0);
                    s[P].visible = !n || (n && (P % F) == 0)
                }
            }
            m.avgWidth = s.length == 0 ? 0 : j / s.length;
            if (!R) {
                var t = {
                    items: s,
                    textSettings: o
                };
                if (isNaN(d) || !l) {
                    d = 0
                }
                this._animateAxisText(t, d == 0 ? 1 : 0);
                if (d != 0) {
                    var g = this;
                    this._enqueueAnimation("series", undefined, undefined, d, function(i, h, w) {
                        g._animateAxisText(h, w)
                    }, t)
                }
            }
            G.width += 2 * O + p + q.width + K + (H && q.width > 0 ? O : 0);
            G.height += 2 * O + p + q.height + Q + (!H && q.height > 0 ? O : 0);
            var B = {};
            var k = {
                stroke: e.color,
                "stroke-width": 1,
                "stroke-dasharray": e.dashStyle || ""
            };
            if (!R) {
                var I = a.jqx._ptrnd(z.y + (D ? z.height : 0));
                if (H) {
                    this.renderer.line(a.jqx._ptrnd(z.x + z.width), z.y, a.jqx._ptrnd(z.x + z.width), z.y + z.height, k)
                } else {
                    this.renderer.line(a.jqx._ptrnd(z.x), I, a.jqx._ptrnd(z.x + z.width + 1), I, k)
                }
            }
            G.width = a.jqx._rup(G.width);
            G.height = a.jqx._rup(G.height);
            return G
        },
        _drawPlotAreaLines: function(j, d, h) {
            var z = this.seriesGroups[j];
            var b = z.orientation != "horizontal";
            if (!this._renderData || this._renderData.length <= j) {
                return
            }
            var D = d ? "valueAxis" : "xAxis";
            var s = this._renderData[j][D];
            if (!s) {
                return
            }
            var m = this._renderData.axisDrawState;
            if (!m) {
                m = this._renderData.axisDrawState = {}
            }
            var u = "";
            if (d) {
                u = "valueAxis_" + j
            } else {
                u = "xAxis_" + ((z.xAxis || z.categoryAxis) ? j : "")
            }
            if (m[u]) {
                m = m[u]
            } else {
                m = m[u] = {}
            }
            if (!d) {
                b = !b
            }
            var B = s.gridLinesSettings;
            var p = s.tickMarksSettings;
            var f = s.rect;
            var k = this._plotRect;
            if (!B || !p) {
                return
            }
            var o = 0.5;
            var e = [];
            var c = {
                stroke: B.color,
                "stroke-width": 1,
                "stroke-dasharray": B.dashStyle || ""
            };
            var w = d ? f.y : f.x;
            var n = B.offsets;
            if (!n || n.length == 0) {
                return
            }
            for (var v = 0; v < n.length; v++) {
                if (b) {
                    A = a.jqx._ptrnd(f.y + n[v].offset);
                    if (A < f.y - o) {
                        break
                    }
                } else {
                    A = a.jqx._ptrnd(f.x + n[v].offset);
                    if (A > f.x + f.width + o) {
                        break
                    }
                }
                if (h.gridLines && B.visible != false && m.gridLines != true) {
                    if (b) {
                        this.renderer.line(a.jqx._ptrnd(k.x), A, a.jqx._ptrnd(k.x + k.width), A, c)
                    } else {
                        this.renderer.line(A, a.jqx._ptrnd(k.y), A, a.jqx._ptrnd(k.y + k.height), c)
                    }
                }
                e[A] = true;
                if (h.alternatingBackground && (B.alternatingBackgroundColor || B.alternatingBackgroundColor2) && m.alternatingBackground != true) {
                    var l = ((v % 2) == 0) ? B.alternatingBackgroundColor2 : B.alternatingBackgroundColor;
                    if (l) {
                        var C;
                        if (b) {
                            C = this.renderer.rect(a.jqx._ptrnd(k.x), w, a.jqx._ptrnd(k.width - 1), A - w, c)
                        } else {
                            C = this.renderer.rect(w, a.jqx._ptrnd(k.y), A - w, a.jqx._ptrnd(k.height), c)
                        }
                        this.renderer.attr(C, {
                            "stroke-width": 0,
                            fill: l,
                            opacity: B.alternatingBackgroundOpacity || 1
                        })
                    }
                    w = A
                }
            }
            var c = {
                stroke: p.color,
                "stroke-width": 1,
                "stroke-dasharray": p.dashStyle || ""
            };
            if (h.tickMarks && p.visible && m.tickMarks != true) {
                var r = 4;
                var n = p.offsets;
                for (var v = 0; v < n.length; v++) {
                    var A = a.jqx._ptrnd((b ? f.y + n[v].offset : f.x + n[v].offset));
                    if (e[A - 1]) {
                        A--
                    } else {
                        if (e[A + 1]) {
                            A++
                        }
                    }
                    if (b) {
                        if (A > f.y + f.height + o) {
                            break
                        }
                    } else {
                        if (A > f.x + f.width + o) {
                            break
                        }
                    }
                    var t = !s.isMirror ? -r : r;
                    if (b) {
                        this.renderer.line(f.x + f.width, A, f.x + f.width + t, A, c)
                    } else {
                        var q = a.jqx._ptrnd(f.y + (s.isMirror ? f.height : 0));
                        this.renderer.line(A, q, A, q - t, c)
                    }
                }
            }
            m.tickMarks = m.tickMarks || h.tickMarks;
            m.gridLines = m.gridLines || h.gridLines;
            m.alternatingBackground = m.alternatingBackground || h.alternatingBackground
        },
        _calcValueAxisItems: function(j, d) {
            var m = this._stats.seriesGroups[j];
            if (!m || !m.isValid) {
                return false
            }
            var v = this.seriesGroups[j];
            var b = v.orientation == "horizontal";
            var f = v.valueAxis;
            var l = f.valuesOnTicks != false;
            var e = f.dataField;
            var n = m.intervals;
            var r = d / n;
            var t = m.min;
            var q = m.mu;
            var c = f.logarithmicScale == true;
            var k = f.logarithmicScaleBase || 10;
            var h = v.type.indexOf("stacked") != -1 && v.type.indexOf("100") != -1;
            if (c) {
                q = !isNaN(f.unitInterval) ? f.unitInterval : 1
            }
            if (!l) {
                n = Math.max(n - 1, 1)
            }
            while (this._renderData.length < j + 1) {
                this._renderData.push({})
            }
            this._renderData[j].valueAxis = {};
            var o = this._renderData[j].valueAxis;
            o.itemWidth = o.intervalWidth = r;
            o.items = [];
            var p = o.items;
            for (var u = 0; u <= n; u++) {
                var s = 0;
                if (c) {
                    if (h) {
                        s = m.max / Math.pow(k, n - u)
                    } else {
                        s = t * Math.pow(k, u)
                    }
                } else {
                    s = l ? t + u * q : t + (u + 0.5) * q
                }
                p.push(s)
            }
            o.rangeLength = c && !h ? m.intervals : (m.intervals) * q;
            if (v.valueAxis.flip != true) {
                p = p.reverse()
            }
            return true
        },
        _renderValueAxis: function(e, u, K, d) {
            var J = this.seriesGroups[e];
            var P = J.orientation == "horizontal";
            var o = J.valueAxis;
            if (!o) {
                throw "SeriesGroup " + e + " is missing valueAxis definition"
            }
            var D = {
                width: 0,
                height: 0
            };
            if (!this._isGroupVisible(e) || this._isPieOnlySeries() || J.type == "spider") {
                return D
            }
            if (!this._calcValueAxisItems(e, (P ? u.width : u.height)) || false == o.displayValueAxis || false == o.visible) {
                return D
            }
            var H = o.descriptionClass;
            if (!H) {
                H = this.toThemeProperty("jqx-chart-axis-description", null)
            }
            var L = {
                text: o.description,
                style: H,
                halign: o.horizontalDescriptionAlignment || "center",
                valign: o.verticalDescriptionAlignment || "center",
                textRotationAngle: P ? 0 : (!this.rtl ? -90 : 90)
            };
            var s = o.itemsClass;
            if (!s) {
                s = this.toThemeProperty("jqx-chart-axis-text", null)
            }
            var j = {
                style: s,
                halign: o.horizontalTextAlignment || "center",
                valign: o.verticalTextAlignment || "center",
                textRotationAngle: o.textRotationAngle || 0,
                textRotationPoint: o.textRotationPoint || "auto",
                textOffset: o.textOffset
            };
            var O = o.valuesOnTicks != false;
            var E = this._stats.seriesGroups[e];
            var h = E.mu;
            var t = o.formatSettings;
            var c = J.type.indexOf("stacked") != -1 && J.type.indexOf("100") != -1;
            if (c && !t) {
                t = {
                    sufix: "%"
                }
            }
            var C = o.logarithmicScale == true;
            var z = o.logarithmicScaleBase || 10;
            if (C) {
                h = !isNaN(o.unitInterval) ? o.unitInterval : 1
            }
            var n = [];
            var k = this._renderData[e].valueAxis;
            var m;
            if (this._elementRenderInfo && this._elementRenderInfo.length > e) {
                m = this._elementRenderInfo[e].valueAxis
            }
            for (var I = 0; I < k.items.length; I++) {
                var G = k.items[I];
                var r = (o.formatFunction) ? o.formatFunction(G) : this._formatNumber(G, t);
                var b = {
                    key: G,
                    text: r
                };
                if (m && m.itemOffsets[G]) {
                    b.x = m.itemOffsets[G].x;
                    b.y = m.itemOffsets[G].y
                }
                n.push(b)
            }
            var l = o.gridLinesInterval || o.unitInterval;
            if (isNaN(l) || (C && l < h)) {
                l = h
            }
            var y = P ? u.width : u.height;
            var f = {
                visible: (o.showGridLines != false),
                color: (o.gridLinesColor || this._defaultLineColor),
                unitInterval: l,
                dashStyle: o.gridLinesDashStyle,
                alternatingBackgroundColor: o.alternatingBackgroundColor,
                alternatingBackgroundColor2: o.alternatingBackgroundColor2,
                alternatingBackgroundOpacity: o.alternatingBackgroundOpacity
            };
            var N = E.logarithmic ? E.minPow : E.min;
            var p = E.logarithmic ? E.maxPow : E.max;
            var M = false;
            if (f.visible || o.alternatingBackgroundColor || o.alternatingBackgroundColor2) {
                f.offsets = this._generateOffsets(N, p, y, {
                    left: 0,
                    right: 0
                }, f.unitInterval, h, true, 0, false, M)
            }
            var F = o.tickMarksInterval || o.unitInterval;
            if (isNaN(F) || (C && F < h)) {
                F = h
            }
            var v = {
                visible: (o.showTickMarks != false),
                color: (o.tickMarksColor || this._defaultLineColor),
                unitInterval: F,
                dashStyle: o.tickMarksDashStyle
            };
            if (v.visible) {
                v.offsets = this._generateOffsets(N, p, y, {
                    left: 0,
                    right: 0
                }, v.unitInterval, h, true, 0, false, M)
            }
            var B = (P && o.position == "top") || (!P && o.position == "right") || (!P && this.rtl && o.position != "left");
            var w = {
                items: n,
                renderData: k
            };
            var A = this._getAnimProps(e);
            var q = A.enabled && n.length < 500 ? A.duration : 0;
            if (this.enableAxisTextAnimation == false) {
                q = 0
            }
            k.gridLinesSettings = f;
            k.tickMarksSettings = v;
            k.isMirror = B;
            k.rect = u;
            return this._renderAxis(!P, B, L, j, u, d, h, C, O, w, f, v, K, q)
        },
        _generateOffsets: function(m, o, s, l, t, d, b, q, r, g) {
            var f = [];
            var h = o - m;
            var k = s - l.left - l.right;
            if (h == 0) {
                if (r || b) {
                    f.push({
                        offset: l.left + k / 2,
                        value: m
                    })
                } else {
                    f.push({
                        offset: 0,
                        value: m
                    })
                }
                return f
            }
            var u = k / h;
            var c = u * d;
            var e = l.left;
            if (!b) {
                if (!r) {
                    o += d
                }
            }
            for (var p = m; p <= o; p += d, e += c) {
                f.push({
                    offset: e,
                    value: p
                })
            }
            if (!b && f.length > 1) {
                if (isNaN(q)) {
                    q = r ? 0 : c / 2
                }
                for (var p = 0; p < f.length; p++) {
                    f[p].offset -= q;
                    if (f[p].offset <= 2) {
                        f[p].offset = 0
                    }
                    if (f[p].offset >= s - 2) {
                        f[p].offset = s
                    }
                }
            }
            if (t > d) {
                var n = [];
                var j = Math.round(t / d);
                for (var p = 0; p < f.length; p++) {
                    if ((p % j) == 0) {
                        n.push({
                            offset: f[p].offset,
                            value: f[p].value
                        })
                    }
                }
                f = n
            }
            if (g) {
                for (var p = 0; p < f.length; p++) {
                    f[p].offset = s - f[p].offset
                }
            }
            return f
        },
        _generateDTOffsets: function(p, s, y, n, z, c, o, b, u, v, g) {
            if (!o) {
                o = "day"
            }
            var f = [];
            if (p > s) {
                return f
            }
            if (p == s) {
                if (v) {
                    f.push({
                        offset: b ? y / 2 : n.left,
                        value: p
                    })
                } else {
                    if (b) {
                        f.push({
                            offset: y / 2,
                            value: p
                        })
                    }
                }
                return f
            }
            var j = y - n.left - n.right;
            var w = p;
            var k = n.left;
            var e = k;
            c = Math.max(c, 1);
            var m = c;
            var d = Math.min(1, c);
            if (c > 1 && o != "millisecond") {
                c = 1
            }
            while (a.jqx._ptrnd(e) <= a.jqx._ptrnd(n.left + j + (b ? 0 : n.right))) {
                f.push({
                    offset: e,
                    value: w
                });
                var A = new Date(w.valueOf());
                if (o == "millisecond") {
                    A.setMilliseconds(w.getMilliseconds() + c)
                } else {
                    if (o == "second") {
                        A.setSeconds(w.getSeconds() + c)
                    } else {
                        if (o == "minute") {
                            A.setMinutes(w.getMinutes() + c)
                        } else {
                            if (o == "hour") {
                                var l = A.valueOf();
                                A.setHours(w.getHours() + c);
                                if (l == A.valueOf()) {
                                    A.setHours(w.getHours() + c + 1)
                                }
                            } else {
                                if (o == "day") {
                                    A.setDate(w.getDate() + c)
                                } else {
                                    if (o == "month") {
                                        A.setMonth(w.getMonth() + c)
                                    } else {
                                        if (o == "year") {
                                            A.setFullYear(w.getFullYear() + c)
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                w = A;
                e = k + (w.valueOf() - p.valueOf()) * d / (s.valueOf() - p.valueOf()) * j
            }
            if (g) {
                for (var r = 0; r < f.length; r++) {
                    f[r].offset = y - f[r].offset
                }
            }
            if (m > 1 && o != "millisecond") {
                var q = [];
                for (var r = 0; r < f.length; r += m) {
                    q.push({
                        offset: f[r].offset,
                        value: f[r].value
                    })
                }
                f = q
            }
            if (!b && !v && f.length > 1) {
                var q = [];
                q.push({
                    offset: 0,
                    value: undefined
                });
                for (var r = 1; r < f.length; r++) {
                    q.push({
                        offset: f[r - 1].offset + (f[r].offset - f[r - 1].offset) / 2,
                        value: undefined
                    })
                }
                var t = q.length;
                if (t > 1) {
                    q.push({
                        offset: q[t - 1].offset + (q[t - 1].offset - q[t - 2].offset)
                    })
                } else {
                    q.push({
                        offset: y,
                        value: undefined
                    })
                }
                f = q
            }
            if (z > c) {
                var q = [];
                var h = Math.round(z / m);
                for (var r = 0; r < f.length; r++) {
                    if ((r % h) == 0) {
                        q.push({
                            offset: f[r].offset,
                            value: f[r].value
                        })
                    }
                }
                f = q
            }
            return f
        },
        _buildStats: function(J) {
            var T = {
                seriesGroups: []
            };
            this._stats = T;
            for (var s = 0; s < this.seriesGroups.length; s++) {
                var C = this.seriesGroups[s];
                T.seriesGroups[s] = {};
                var F = this._getCategoryAxis(s);
                var o = this._getCategoryAxisStats(s, F, (C.orientation == "vertical") ? J.width : J.height);
                var z = T.seriesGroups[s];
                z.isValid = true;
                var P = C.valueAxis != undefined;
                var K = (C.orientation == "horizontal") ? J.width : J.height;
                var M = false;
                var L = 10;
                if (P) {
                    M = C.valueAxis.logarithmicScale == true;
                    L = C.valueAxis.logarithmicScaleBase;
                    if (isNaN(L)) {
                        L = 10
                    }
                }
                var G = -1 != C.type.indexOf("stacked");
                var e = G && -1 != C.type.indexOf("100");
                var I = -1 != C.type.indexOf("range");
                if (e) {
                    z.psums = [];
                    z.nsums = []
                }
                var t = NaN,
                    N = NaN;
                var d = NaN,
                    f = NaN;
                var q = C.baselineValue;
                if (isNaN(q)) {
                    q = M && !e ? 1 : 0
                }
                var B = this._getDataLen(s);
                var c = 0;
                var V = NaN;
                for (var S = 0; S < B && z.isValid; S++) {
                    if (F.rangeSelector) {
                        var g = F.dataField ? this._getDataValue(S, F.dataField, s) : S;
                        if (g && o.isDateTime) {
                            g = this._castAsDate(g)
                        }
                        if (g && (g.valueOf() < o.min.valueOf() || g.valueOf() > o.max.valueOf())) {
                            continue
                        }
                    }
                    var W = P ? C.valueAxis.minValue : Infinity;
                    var E = P ? C.valueAxis.maxValue : -Infinity;
                    var u = 0,
                        w = 0;
                    for (var h = 0; h < C.series.length; h++) {
                        if (!this._isSerieVisible(s, h)) {
                            continue
                        }
                        var H = NaN,
                            Q = NaN,
                            A = NaN;
                        if (C.type.indexOf("candle") != -1 || C.type.indexOf("ohlc") != -1) {
                            var b = ["Open", "Low", "Close", "High"];
                            for (var R in b) {
                                var l = this._getDataValueAsNumber(S, C.series[h]["dataField" + b[R]], s);
                                if (isNaN(l)) {
                                    continue
                                }
                                A = isNaN(Q) ? l : Math.min(A, l);
                                Q = isNaN(Q) ? l : Math.max(Q, l)
                            }
                        } else {
                            if (I) {
                                var X = this._getDataValueAsNumber(S, C.series[h].dataFieldFrom, s);
                                var D = this._getDataValueAsNumber(S, C.series[h].dataFieldTo, s);
                                Q = Math.max(X, D);
                                A = Math.min(X, D)
                            } else {
                                H = this._getDataValueAsNumber(S, C.series[h].dataField, s);
                                if (isNaN(H) || (M && H <= 0)) {
                                    continue
                                }
                                A = Q = H
                            }
                        }
                        if ((isNaN(E) || Q > E) && ((!P || isNaN(C.valueAxis.maxValue)) ? true : Q <= C.valueAxis.maxValue)) {
                            E = Q
                        }
                        if ((isNaN(W) || A < W) && ((!P || isNaN(C.valueAxis.minValue)) ? true : A >= C.valueAxis.minValue)) {
                            W = A
                        }
                        if (!isNaN(H)) {
                            if (H > q) {
                                u += H
                            } else {
                                if (H < q) {
                                    w += H
                                }
                            }
                        }
                    }
                    if (!e && P) {
                        if (!isNaN(C.valueAxis.maxValue)) {
                            u = Math.min(C.valueAxis.maxValue, u)
                        }
                        if (!isNaN(C.valueAxis.minValue)) {
                            w = Math.max(C.valueAxis.minValue, w)
                        }
                    }
                    if (M && e) {
                        for (var h = 0; h < C.series.length; h++) {
                            if (!this._isSerieVisible(s, h)) {
                                V = 0.01;
                                continue
                            }
                            var H = this._getDataValueAsNumber(S, C.series[h].dataField, s);
                            if (isNaN(H) || H <= 0) {
                                V = 0.01;
                                continue
                            }
                            var O = u == 0 ? 0 : H / u;
                            if (isNaN(V) || O < V) {
                                V = O
                            }
                        }
                    }
                    var n = u - w;
                    if (c < n) {
                        c = n
                    }
                    if (e) {
                        z.psums[S] = u;
                        z.nsums[S] = w
                    }
                    if (E > N || isNaN(N)) {
                        N = E
                    }
                    if (W < t || isNaN(t)) {
                        t = W
                    }
                    if (u > d || isNaN(d)) {
                        d = u
                    }
                    if (w < f || isNaN(f)) {
                        f = w
                    }
                }
                if (e) {
                    d = d == 0 ? 0 : Math.max(d, -f);
                    f = f == 0 ? 0 : Math.min(f, -d)
                }
                var m = P ? C.valueAxis.unitInterval : 0;
                if (!m) {
                    if (P) {
                        m = this._calcInterval(G ? f : t, G ? d : N, Math.max(K / 80, 2))
                    } else {
                        m = G ? (d - f) / 10 : (N - t) / 10
                    }
                }
                var y = NaN;
                var U = 0;
                var r = 0;
                if (M) {
                    if (e) {
                        y = 0;
                        var O = 1;
                        U = r = a.jqx.log(100, L);
                        while (O > V) {
                            O /= L;
                            U--;
                            y++
                        }
                        t = Math.pow(L, U)
                    } else {
                        if (G) {
                            N = Math.max(N, d)
                        }
                        r = a.jqx._rnd(a.jqx.log(N, L), 1, true);
                        N = Math.pow(L, r);
                        U = a.jqx._rnd(a.jqx.log(t, L), 1, false);
                        t = Math.pow(L, U)
                    }
                    m = L
                }
                if (t < f) {
                    f = t
                }
                if (N > d) {
                    d = N
                }
                var v = M ? t : a.jqx._rnd(G ? f : t, m, false);
                var k = M ? N : a.jqx._rnd(G ? d : N, m, true);
                if (e && k > 100) {
                    k = 100
                }
                if (e && !M) {
                    k = (k > 0) ? 100 : 0;
                    v = (v < 0) ? -100 : 0;
                    m = P ? C.valueAxis.unitInterval : 10;
                    if (isNaN(m) || m <= 0 || m >= 100) {
                        m = 10
                    }
                }
                if (isNaN(k) || isNaN(v) || isNaN(m)) {
                    continue
                }
                if (isNaN(y)) {
                    y = parseInt(((k - v) / (m == 0 ? 1 : m)).toFixed())
                }
                if (M && !e) {
                    y = r - U;
                    c = Math.pow(L, y)
                }
                if (y < 1) {
                    continue
                }
                z.min = v;
                z.max = k;
                z.logarithmic = M;
                z.logBase = L;
                z.base = q;
                z.minPow = U;
                z.maxPow = r;
                z.mu = m;
                z.maxRange = c;
                z.intervals = y
            }
        },
        _getDataLen: function(c) {
            var b = this.source;
            if (c != undefined && c != -1 && this.seriesGroups[c].source) {
                b = this.seriesGroups[c].source
            }
            if (b instanceof a.jqx.dataAdapter) {
                b = b.records
            }
            if (b) {
                return b.length
            }
            return 0
        },
        _getDataValue: function(b, e, d) {
            var c = this.source;
            if (d != undefined && d != -1) {
                c = this.seriesGroups[d].source || c
            }
            if (c instanceof a.jqx.dataAdapter) {
                c = c.records
            }
            if (!c || b < 0 || b > c.length - 1) {
                return undefined
            }
            if (a.isFunction(e)) {
                return e(b, c)
            }
            return (e && e != "") ? c[b][e] : c[b]
        },
        _getDataValueAsNumber: function(b, e, c) {
            var d = this._getDataValue(b, e, c);
            if (this._isDate(d)) {
                return d.valueOf()
            }
            if (typeof(d) != "number") {
                d = parseFloat(d)
            }
            if (typeof(d) != "number") {
                d = undefined
            }
            return d
        },
        _renderPieSeries: function(e, c) {
            var f = this._getDataLen(e);
            var g = this.seriesGroups[e];
            var m = this._calcGroupOffsets(e, c).offsets;
            for (var p = 0; p < g.series.length; p++) {
                var k = g.series[p];
                var u = this._getSerieSettings(e, p);
                var h = k.colorScheme || g.colorScheme || this.colorScheme;
                var r = this._getAnimProps(e, p);
                var b = r.enabled && f < 5000 && !this._isToggleRefresh && this._isVML != true ? r.duration : 0;
                if (a.jqx.mobile.isMobileBrowser() && (this.renderer instanceof a.jqx.HTML5Renderer)) {
                    b = 0
                }
                var o = {
                    rect: c,
                    groupIndex: e,
                    serieIndex: p,
                    settings: u,
                    items: []
                };
                for (var t = 0; t < f; t++) {
                    var n = m[p][t];
                    if (!n.visible) {
                        continue
                    }
                    var q = n.fromAngle;
                    var d = n.toAngle;
                    var v = this.renderer.pieslice(n.x, n.y, n.innerRadius, n.outerRadius, q, b == 0 ? d : q, n.centerOffset);
                    var j = {
                        element: v,
                        displayValue: n.displayValue,
                        itemIndex: t,
                        visible: n.visible,
                        x: n.x,
                        y: n.y,
                        innerRadius: n.innerRadius,
                        outerRadius: n.outerRadius,
                        fromAngle: q,
                        toAngle: d,
                        centerOffset: n.centerOffset
                    };
                    o.items.push(j)
                }
                this._animatePieSlices(o, 0);
                var l = this;
                this._enqueueAnimation("series", undefined, undefined, b, function(s, i, w) {
                    l._animatePieSlices(i, w)
                }, o)
            }
        },
        _sliceSortFunction: function(d, c) {
            return d.fromAngle - c.fromAngle
        },
        _animatePieSlices: function(w, c) {
            var o;
            if (this._elementRenderInfo && this._elementRenderInfo.length > w.groupIndex && this._elementRenderInfo[w.groupIndex].series && this._elementRenderInfo[w.groupIndex].series.length > w.serieIndex) {
                o = this._elementRenderInfo[w.groupIndex].series[w.serieIndex]
            }
            var k = 360 * c;
            var b = [];
            for (var C = 0; C < w.items.length; C++) {
                var H = w.items[C];
                if (!H.visible) {
                    continue
                }
                var z = H.fromAngle;
                var j = H.fromAngle + c * (H.toAngle - H.fromAngle);
                if (o && o[H.displayValue]) {
                    var t = o[H.displayValue].fromAngle;
                    var d = o[H.displayValue].toAngle;
                    z = t + (z - t) * c;
                    j = d + (j - d) * c
                }
                b.push({
                    index: C,
                    from: z,
                    to: j
                })
            }
            if (o) {
                b.sort(this._sliceSortFunction)
            }
            var I = NaN;
            for (var C = 0; C < b.length; C++) {
                var H = w.items[b[C].index];
                if (H.labelElement) {
                    this.renderer.removeElement(H.labelElement)
                }
                var z = b[C].from;
                var j = b[C].to;
                if (o) {
                    if (!isNaN(I) && z > I) {
                        z = I
                    }
                    I = j;
                    if (C == b.length - 1 && j != b[0].from) {
                        j = 360 + b[0].from
                    }
                }
                var A = this.renderer.pieSlicePath(H.x, H.y, H.innerRadius, H.outerRadius, z, j, H.centerOffset);
                this.renderer.attr(H.element, {
                    d: A
                });
                var m = this._getColors(w.groupIndex, w.serieIndex, H.itemIndex, "radialGradient", H.outerRadius);
                var G = w.settings;
                this.renderer.attr(H.element, {
                    fill: m.fillColor,
                    stroke: m.lineColor,
                    "stroke-width": G.stroke,
                    "fill-opacity": G.opacity,
                    "stroke-opacity": G.opacity,
                    "stroke-dasharray": "none" || G.dashStyle
                });
                var D = this.seriesGroups[w.groupIndex];
                var r = D.series[w.serieIndex];
                if (r.showLabels == true || (!r.showLabels && D.showLabels == true)) {
                    var K = z,
                        L = j;
                    var p = Math.abs(K - L);
                    var v = p > 180 ? 1 : 0;
                    if (p > 360) {
                        K = 0;
                        L = 360
                    }
                    var u = K * Math.PI * 2 / 360;
                    var l = L * Math.PI * 2 / 360;
                    var n = p / 2 + K;
                    n = n % 360;
                    var J = n * Math.PI * 2 / 360;
                    var y;
                    if (r.labelsAutoRotate == true) {
                        y = n < 90 || n > 270 ? 360 - n : 180 - n
                    }
                    var q = this._showLabel(w.groupIndex, w.serieIndex, H.itemIndex, {
                        x: 0,
                        y: 0,
                        width: 0,
                        height: 0
                    }, "center", "center", true, false, false, y);
                    var h = r.labelRadius || H.outerRadius + Math.max(q.width, q.height);
                    h += H.centerOffset;
                    var F = a.jqx.getNum([r.offsetX, D.offsetX, w.rect.width / 2]);
                    var E = a.jqx.getNum([r.offsetY, D.offsetY, w.rect.height / 2]);
                    var f = w.rect.x + F;
                    var e = w.rect.y + E;
                    var B = this._adjustTextBoxPosition(f, e, q, h, n, H.outerRadius > h, r.labelLinesAngles != false, r.labelsAutoRotate == true);
                    H.labelElement = this._showLabel(w.groupIndex, w.serieIndex, H.itemIndex, {
                        x: B.x,
                        y: B.y,
                        width: q.width,
                        height: q.height
                    }, "left", "top", false, false, false, y);
                    if (h > H.outerRadius + 5 && r.labelLinesEnabled != false) {
                        H.labelArrowPath = this._updateLebelArrowPath(H.labelArrowPath, f, e, h, H.outerRadius, J, r.labelLinesAngles != false, m, G)
                    }
                }
                if (c == 1) {
                    this._installHandlers(H.element, "pieslice", w.groupIndex, w.serieIndex, H.itemIndex)
                }
            }
        },
        _updateLebelArrowPath: function(e, j, g, i, k, h, n, b, f) {
            var d = a.jqx._ptrnd(j + (i - 0) * Math.cos(h));
            var m = a.jqx._ptrnd(g - (i - 0) * Math.sin(h));
            var c = a.jqx._ptrnd(j + (k + 2) * Math.cos(h));
            var l = a.jqx._ptrnd(g - (k + 2) * Math.sin(h));
            var o = "M " + d + "," + m + " L" + c + "," + l;
            if (n) {
                o = "M " + d + "," + m + " L" + c + "," + m + " L" + c + "," + l
            }
            if (e) {
                this.renderer.attr(e, {
                    d: o
                })
            } else {
                e = this.renderer.path(o, {})
            }
            this.renderer.attr(e, {
                fill: "none",
                stroke: b.lineColor,
                "stroke-width": f.stroke,
                "stroke-opacity": f.opacity,
                "stroke-dasharray": "none" || f.dashStyle
            });
            return e
        },
        _adjustTextBoxPosition: function(f, e, n, g, s, c, i, o) {
            var d = s * Math.PI * 2 / 360;
            var k = a.jqx._ptrnd(f + g * Math.cos(d));
            var j = a.jqx._ptrnd(e - g * Math.sin(d));
            if (o) {
                var l = n.width;
                var p = n.height;
                var t = Math.atan(p / l) % (Math.PI * 2);
                var u = d % (Math.PI * 2);
                var r = 0,
                    q = 0;
                var m = 0;
                if (u <= t) {
                    m = l / 2 * Math.cos(d);
                    q = m * Math.sin(d);
                    r = -l / 2
                } else {
                    if (u >= t && u < Math.PI - t) {
                        m = (p / 2) * Math.sin(d);
                        q = p / 2;
                        r = -Math.cos(d) * m
                    } else {
                        if (u >= Math.PI - t && u < Math.PI + t) {
                            m = l / 2 * Math.cos(d);
                            q = -m * Math.sin(d);
                            r = l / 2
                        } else {
                            if (u >= Math.PI + t && u < 2 * Math.PI - t) {
                                m = p / 2 * Math.sin(d);
                                q = -p / 2;
                                r = Math.cos(d) * m
                            } else {
                                if (u >= 2 * Math.PI - t && u < 2 * Math.PI) {
                                    m = l / 2 * Math.cos(d);
                                    q = m * Math.sin(d);
                                    r = -l / 2
                                }
                            }
                        }
                    }
                }
                g += Math.abs(m) + 3;
                var k = a.jqx._ptrnd(f + g * Math.cos(d));
                var j = a.jqx._ptrnd(e - g * Math.sin(d));
                k -= n.width / 2;
                j -= n.height / 2;
                return {
                    x: k,
                    y: j
                }
            }
            if (!c) {
                if (!i) {
                    if (s >= 0 && s < 45 || s >= 315 && s < 360) {
                        j -= n.height / 2
                    } else {
                        if (s >= 45 && s < 135) {
                            j -= n.height;
                            k -= n.width / 2
                        } else {
                            if (s >= 135 && s < 225) {
                                j -= n.height / 2;
                                k -= n.width
                            } else {
                                if (s >= 225 && s < 315) {
                                    k -= n.width / 2
                                }
                            }
                        }
                    }
                } else {
                    if (s >= 90 && s < 270) {
                        j -= n.height / 2;
                        k -= n.width
                    } else {
                        j -= n.height / 2
                    }
                }
            } else {
                k -= n.width / 2;
                j -= n.height / 2
            }
            return {
                x: k,
                y: j
            }
        },
        _getColumnGroupsCount: function(c) {
            var e = 0;
            c = c || "vertical";
            var f = this.seriesGroups;
            for (var d = 0; d < f.length; d++) {
                var b = f[d].orientation || "vertical";
                if (f[d].type.indexOf("column") != -1 && b == c) {
                    e++
                }
            }
            return e
        },
        _getColumnGroupIndex: function(g) {
            var b = 0;
            var c = this.seriesGroups[g].orientation || "vertical";
            for (var e = 0; e < g; e++) {
                var f = this.seriesGroups[e];
                var d = f.orientation || "vertical";
                if (f.type.indexOf("column") != -1 && d == c) {
                    b++
                }
            }
            return b
        },
        _renderBand: function(p, l, j) {
            var o = this.seriesGroups[p];
            if (!o.bands || o.bands.length <= l) {
                return
            }
            var c = j;
            if (o.orientation == "horizontal") {
                c = {
                    x: j.y,
                    y: j.x,
                    width: j.height,
                    height: j.width
                }
            }
            var q = this._calcGroupOffsets(p, c);
            if (!q || q.length <= p) {
                return
            }
            var r = o.bands[l];
            var g = q.bands[l];
            var n = g.from;
            var m = g.to;
            var e = Math.abs(n - m);
            var i = {
                x: c.x,
                y: Math.min(n, m),
                width: c.width,
                height: e
            };
            if (o.orientation == "horizontal") {
                var d = i.x;
                i.x = i.y;
                i.y = d;
                d = i.width;
                i.width = i.height;
                i.height = d
            }
            var k = this.renderer.rect(i.x, i.y, i.width, i.height);
            var b = r.color || "#AAAAAA";
            var f = r.opacity;
            if (isNaN(f) || f < 0 || f > 1) {
                f = 0.5
            }
            this.renderer.attr(k, {
                fill: b,
                "fill-opacity": f,
                stroke: b,
                "stroke-opacity": f,
                "stroke-width": 0
            })
        },
        _calcColumnWidth: function(k, f, m) {
            var e = this.seriesGroups[k];
            var b = e.minColumnsWidth || 5;
            var l = e.maxColumnsWidth || m / 5;
            for (var j in e.series) {
                if (!isNaN(e.series[j].minColumnsWidth)) {
                    b = Math.max(b, e.series[j].minColumnsWidth)
                }
                if (!isNaN(e.series[j].maxColumnsWidth)) {
                    l = Math.min(l, e.series[j].maxColumnsWidth)
                }
            }
            var c = e.columnsGapPercent;
            if (isNaN(c) || c < 0 || c > 100) {
                c = 25
            }
            c /= 100;
            var h = l;
            for (var d = f.first; d < f.last; d++) {
                if (Math.abs(f.data[d + 1] - f.data[d]) >= h * (1 + c)) {
                    continue
                } else {
                    h = Math.abs(f.data[d + 1] - f.data[d]) / (1 + c)
                }
            }
            if (h < b) {
                h = b
            }
            return {
                width: h,
                isMin: h == b,
                columnGap: c
            }
        },
        _renderColumnSeries: function(k, H) {
            var v = this.seriesGroups[k];
            if (!v.series || v.series.length == 0) {
                return
            }
            var A = v.type.indexOf("stacked") != -1;
            var e = A && v.type.indexOf("100") != -1;
            var F = v.type.indexOf("range") != -1;
            var q = this._getDataLen(k);
            var N = v.seriesGapPercent;
            if (isNaN(N) || N < 0 || N > 100) {
                N = 10
            }
            var w = v.orientation == "horizontal";
            var o = H;
            if (w) {
                o = {
                    x: H.y,
                    y: H.x,
                    width: H.height,
                    height: H.width
                }
            }
            var r = this._calcGroupOffsets(k, o);
            if (!r || r.xoffsets.length == 0) {
                return
            }
            var h = this._getColumnGroupsCount(v.orientation);
            var b = this._getColumnGroupIndex(k);
            if (this.columnSeriesOverlap == true) {
                h = 1;
                b = 0
            }
            var Q = true;
            var c;
            if (v.polar == true || v.spider == true) {
                c = this._getPolarAxisCoords(k, o);
                N = 0
            }
            var y = {
                groupIndex: k,
                rect: H,
                vertical: !w,
                seriesCtx: [],
                renderData: r,
                polarAxisCoords: c
            };
            y.columnInfo = this._calcColumnWidth(k, r.xoffsets, w ? o.height : o.width);
            var u = this._getGroupGradientType(k);
            for (var l = 0; l < v.series.length; l++) {
                var M = v.series[l];
                var I = M.columnsMaxWidth || v.columnsMaxWidth;
                var C = M.columnsMinWidth || v.columnsMinWidth || 1;
                var z = M.dataField;
                var K = this._getAnimProps(k, l);
                var D = K.enabled && !this._isToggleRefresh && r.xoffsets.length < 100 ? K.duration : 0;
                var L = 0;
                var g = y.columnInfo.width;
                if (Q) {
                    L -= g / 2
                }
                L += g * (b / h);
                g /= h;
                var t = L + g;
                var G = (t - L);
                var p = (!A && v.series.length > 1) ? (G * N / 100) / (v.series.length - 1) : 0;
                var E = (G - p * (v.series.length - 1));
                E = Math.max(E, C);
                if (G < 1) {
                    G = 1
                }
                var m = 0;
                if (!A && v.series.length > 1) {
                    E /= v.series.length;
                    m = l
                }
                var R = L + m * (p + E);
                if (m == v.series.length) {
                    E = G - L + G - x
                }
                if (!isNaN(I)) {
                    var J = Math.min(E, I);
                    R = R + (E - J) / 2;
                    E = J
                }
                var j = this._isSerieVisible(k, l);
                var f = this._getSerieSettings(k, l);
                var B = this._getColors(k, l, NaN, this._getGroupGradientType(k), 4);
                var d = [];
                if (a.isFunction(M.colorFunction) && !c) {
                    for (var O = r.xoffsets.first; O <= r.xoffsets.last; O++) {
                        d.push(this._getColors(k, l, O, u, 4))
                    }
                }
                var P = {
                    seriesIndex: l,
                    serieColors: B,
                    itemsColors: d,
                    settings: f,
                    columnWidth: E,
                    xAdjust: R,
                    isVisible: j
                };
                y.seriesCtx.push(P)
            }
            this._animColumns(y, D == 0 ? 1 : 0);
            var n = this;
            this._enqueueAnimation("series", undefined, undefined, D, function(s, i, S) {
                n._animColumns(i, S)
            }, y)
        },
        _getColumnVOffsets: function(p, e, t, A, k, b) {
            var j = this.seriesGroups[e];
            var g = [];
            for (var z = 0; z < t.length; z++) {
                var w = t[z];
                var u = w.seriesIndex;
                var n = j.series[u];
                var v = p.offsets[u][A].from;
                var c = p.offsets[u][A].to;
                var B = p.xoffsets.data[A];
                var d;
                var r = w.isVisible;
                if (!r) {
                    c = v
                }
                if (r && this._elementRenderInfo && this._elementRenderInfo.length > e) {
                    var l = p.xoffsets.xvalues[A];
                    d = this._elementRenderInfo[e].series[u][l];
                    if (d && !isNaN(d.from) && !isNaN(d.to)) {
                        v = d.from + (v - d.from) * b;
                        c = d.to + (c - d.to) * b;
                        B = d.xoffset + (B - d.xoffset) * b
                    }
                }
                if (!d) {
                    c = v + (c - v) * (k ? 1 : b)
                }
                if (isNaN(v)) {
                    v = 0
                }
                if (isNaN(c)) {
                    c = isNaN(v) ? 0 : v
                }
                g.push({
                    from: v,
                    to: c,
                    xOffset: B
                })
            }
            if (k && g.length > 1 && !(this._elementRenderInfo && this._elementRenderInfo.length > e)) {
                var f = 0,
                    h = 0;
                for (var y = 0; y < g.length; y++) {
                    if (g[y].to >= g[y].from) {
                        h += g[y].to - g[y].from
                    } else {
                        f += g[y].from - g[y].to
                    }
                }
                f *= b;
                h *= b;
                var o = 0,
                    q = 0;
                for (var y = 0; y < g.length; y++) {
                    if (g[y].to >= g[y].from) {
                        var m = g[y].to - g[y].from;
                        if (m + q > h) {
                            m = Math.max(0, h - q);
                            g[y].to = g[y].from + m
                        }
                        q += m
                    } else {
                        var m = g[y].from - g[y].to;
                        if (m + o > f) {
                            m = Math.max(0, f - o);
                            g[y].to = g[y].from - m
                        }
                        o += m
                    }
                }
            }
            return g
        },
        _columnAsPieSlice: function(b, f, l, n, o) {
            var e = this._toPolarCoord(n, l, o.x, o.y);
            var g = this._toPolarCoord(n, l, o.x, o.y + o.height);
            var p = this._toPolarCoord(n, l, o.x + o.width, o.y);
            var m = a.jqx._ptdist(n.x, n.y, g.x, g.y);
            var j = a.jqx._ptdist(n.x, n.y, e.x, e.y);
            var d = l.width;
            var c = -((o.x - l.x) * 360) / d;
            var i = -((o.x + o.width - l.x) * 360) / d;
            var k = n.startAngle;
            k = 360 * k / (Math.PI * 2);
            c -= k;
            i -= k;
            if (b[f] != undefined) {
                var h = this.renderer.pieSlicePath(n.x, n.y, m, j, i, c, 0);
                this.renderer.attr(b[f], {
                    d: h
                })
            } else {
                b[f] = this.renderer.pieslice(n.x, n.y, m, j, i, c, 0)
            }
            return {
                fromAngle: i,
                toAngle: c,
                innerRadius: m,
                outerRadius: j
            }
        },
        _animColumns: function(e, b) {
            var H = e.groupIndex;
            var k = this.seriesGroups[H];
            var u = e.renderData;
            var l = k.type.indexOf("stacked") != -1;
            var p = e.polarAxisCoords;
            var f = this._getGroupGradientType(H);
            var g = e.columnInfo.width;
            var r = g;
            if (e.columnInfo.isMin) {
                r = g * (1 + e.columnInfo.columnGap)
            }
            var A = e.renderData.xoffsets;
            var G = -1;
            for (var E = A.first; E <= A.last; E++) {
                var n = A.data[E];
                if (isNaN(n)) {
                    continue
                }
                if (G != -1 && Math.abs(n - G) < r && k.skipOverlappingPoints != false) {
                    continue
                } else {
                    G = n
                }
                var j = this._getColumnVOffsets(u, H, e.seriesCtx, E, l, b);
                for (var D = 0; D < e.seriesCtx.length; D++) {
                    var B = e.seriesCtx[D];
                    var y = B.seriesIndex;
                    var v = k.series[y];
                    var z = j[D].from;
                    var d = j[D].to;
                    var I = j[D].xOffset;
                    if (!B.elements) {
                        B.elements = {}
                    }
                    if (!B.labelElements) {
                        B.labelElements = {}
                    }
                    var q = B.elements;
                    var t = B.labelElements;
                    var C = (e.vertical ? e.rect.x : e.rect.y) + B.xAdjust;
                    var F = B.settings;
                    var m = B.itemsColors.length != 0 ? B.itemsColors[E - u.xoffsets.first] : B.serieColors;
                    var w = this._isSerieVisible(H, y);
                    if (!w && !l) {
                        continue
                    }
                    var n = a.jqx._ptrnd(C + I);
                    var c = {
                        x: n,
                        width: B.columnWidth
                    };
                    var o = true;
                    if (e.vertical) {
                        c.y = z;
                        c.height = d - z;
                        if (c.height < 0) {
                            c.y += c.height;
                            c.height = -c.height;
                            o = false
                        }
                    } else {
                        c.x = z < d ? z : d;
                        c.width = Math.abs(z - d);
                        c.y = n;
                        c.height = B.columnWidth
                    }
                    var s = z - d;
                    if (isNaN(s)) {
                        continue
                    }
                    s = Math.abs(s);
                    if (q[E] == undefined) {
                        if (!p) {
                            q[E] = this.renderer.rect(c.x, c.y, e.vertical ? c.width : 0, e.vertical ? 0 : c.height)
                        } else {
                            this._columnAsPieSlice(q, E, e.rect, p, c)
                        }
                        this.renderer.attr(q[E], {
                            fill: "#517D12",
                            //fill: m.fillColor,
                            "fill-opacity": F.opacity,
                            "stroke-opacity": F.opacity,
                            stroke: m.lineColor,
                            "stroke-width": F.stroke,
                            "stroke-dasharray": F.dashStyle
                        })
                    }
                    if (s < 1 && b != 1) {
                        this.renderer.attr(q[E], {
                            display: "none"
                        })
                    } else {
                        this.renderer.attr(q[E], {
                            display: "block"
                        })
                    }
                    if (p) {
                        var h = this._columnAsPieSlice(q, E, e.rect, p, c);
                        var m = this._getColors(H, y, undefined, "radialGradient", h.outerRadius);
                        this.renderer.attr(q[E], {
                            fill: m.fillColor,
                            "fill-opacity": F.opacity,
                            "stroke-opacity": F.opacity,
                            stroke: m.lineColor,
                            "stroke-width": F.stroke,
                            "stroke-dasharray": F.dashStyle
                        })
                    } else {
                        if (e.vertical == true) {
                            this.renderer.attr(q[E], {
                                x: c.x,
                                y: c.y,
                                height: s
                            })
                        } else {
                            this.renderer.attr(q[E], {
                                x: c.x,
                                y: c.y,
                                width: s
                            })
                        }
                    }
                    this.renderer.removeElement(t[E]);
                    if (!w || (s == 0 && b < 1)) {
                        continue
                    }
                    t[E] = this._showLabel(H, y, E, c, undefined, undefined, false, false, o);
                    if (b == 1) {
                        this._installHandlers(q[E], "column", H, y, E)
                    }
                }
            }
        },
        _renderCandleStickSeries: function(e, c, r) {
            var l = this;
            var h = l.seriesGroups[e];
            if (!h.series || h.series.length == 0) {
                return
            }
            var d = h.orientation == "horizontal";
            var u = c;
            if (d) {
                u = {
                    x: c.y,
                    y: c.x,
                    width: c.height,
                    height: c.width
                }
            }
            var m = l._calcGroupOffsets(e, u);
            if (!m || m.xoffsets.length == 0) {
                return
            }
            var v = u.width;
            var j;
            if (h.polar || h.spider) {
                j = l._getPolarAxisCoords(e, u);
                v = 2 * j.r
            }
            var g = l._alignValuesWithTicks(e);
            var f = l._getGroupGradientType(e);
            for (var o = 0; o < h.series.length; o++) {
                if (!this._isSerieVisible(e, o)) {
                    continue
                }
                var t = l._getSerieSettings(e, o);
                var k = h.series[o];
                var i = a.isFunction(k.colorFunction) ? undefined : l._getColors(e, o, NaN, f);
                var n = {
                    rect: c,
                    inverse: d,
                    groupIndex: e,
                    seriesIndex: o,
                    symbolType: k.symbolType,
                    symbolSize: k.symbolSize,
                    "fill-opacity": t.opacity,
                    "stroke-opacity": t.opacity,
                    "stroke-width": t.stroke,
                    "stroke-dasharray": t.dashStyle,
                    gradientType: f,
                    colors: i,
                    renderData: m,
                    polarAxisCoords: j,
                    columnInfo: l._calcColumnWidth(e, m.xoffsets, d ? u.height : u.width),
                    isOHLC: r,
                    items: [],
                    self: l
                };
                var p = l._getAnimProps(e, o);
                var b = p.enabled && !l._isToggleRefresh && m.xoffsets.length < 5000 ? p.duration : 0;
                l._animCandleStick(n, 0);
                var q;
                l._enqueueAnimation("series", undefined, undefined, b, function(y, s, w) {
                    l._animCandleStick(s, w)
                }, n)
            }
        },
        _animCandleStick: function(q, b) {
            var p = ["Open", "Low", "Close", "High"];
            var d = q.columnInfo.width;
            var l = d;
            if (q.columnInfo.isMin) {
                l = d * (1 + q.columnInfo.columnGap)
            }
            var f = q.self.seriesGroups[q.groupIndex];
            var t = q.renderData.xoffsets;
            var A = -1;
            var m = Math.abs(t.data[t.last] - t.data[t.first]);
            m *= b;
            for (var v = t.first; v <= t.last; v++) {
                var k = t.data[v];
                if (isNaN(k)) {
                    continue
                }
                if (A != -1 && Math.abs(k - A) < l && f.skipOverlappingPoints != false) {
                    continue
                }
                var w = Math.abs(t.data[v] - t.data[t.first]);
                if (w > m) {
                    break
                }
                A = k;
                var z = q.items[v] = q.items[v] || {};
                for (var u in p) {
                    var B = q.self._getDataValueAsNumber(v, f.series[q.seriesIndex]["dataField" + p[u]], q.groupIndex);
                    if (isNaN(B)) {
                        break
                    }
                    var h = q.renderData.offsets[q.seriesIndex][v][p[u]];
                    if (isNaN(h)) {
                        break
                    }
                    z[p[u]] = h
                }
                k += q.inverse ? q.rect.y : q.rect.x;
                if (q.polarAxisCoords) {
                    var r = this._toPolarCoord(q.polarAxisCoords, this._plotRect, k, h);
                    k = r.x;
                    h = r.y
                }
                k = a.jqx._ptrnd(k);
                for (var e in p) {
                    z[e] = a.jqx._ptrnd(z[e])
                }
                var g = q.colors;
                if (!g) {
                    g = q.self._getColors(q.groupIndex, q.seriesIndex, v, q.gradientType)
                }
                if (!q.isOHLC) {
                    var s = z.lineElement;
                    if (!s) {
                        s = q.inverse ? this.renderer.line(z.Low, k, z.High, k) : this.renderer.line(k, z.Low, k, z.High);
                        this.renderer.attr(s, {
                            fill: g.fillColor,
                            "fill-opacity": q["fill-opacity"],
                            "stroke-opacity": q["fill-opacity"],
                            stroke: g.lineColor,
                            "stroke-width": q["stroke-width"],
                            "stroke-dasharray": q["stroke-dasharray"]
                        });
                        z.lineElement = s
                    }
                    var o = z.stickElement;
                    k -= d / 2;
                    if (!o) {
                        var c = g.fillColor;
                        if (z.Close <= z.Open && g.fillColorAlt) {
                            c = g.fillColorAlt
                        }
                        o = q.inverse ? this.renderer.rect(Math.min(z.Open, z.Close), k, Math.abs(z.Close - z.Open), d) : this.renderer.rect(k, Math.min(z.Open, z.Close), d, Math.abs(z.Close - z.Open));
                        this.renderer.attr(o, {
                            fill: "#517D12",
                            "fill-opacity": q["fill-opacity"],
                            "stroke-opacity": q["fill-opacity"],
                            stroke: g.lineColor,
                            "stroke-width": q["stroke-width"],
                            "stroke-dasharray": q["stroke-dasharray"]
                        });
                        z.stickElement = o
                    }
                    if (b == 1) {
                        this._installHandlers(o, "column", q.groupIndex, q.seriesIndex, v)
                    }
                } else {
                    var n = "M" + k + "," + z.Low + " L" + k + "," + z.High + " M" + (k - d / 2) + "," + z.Open + " L" + k + "," + z.Open + " M" + (k + d / 2) + "," + z.Close + " L" + k + "," + z.Close;
                    if (q.inverse) {
                        n = "M" + z.Low + "," + k + " L" + z.High + "," + k + " M" + z.Open + "," + (k - d / 2) + " L" + z.Open + "," + k + " M" + z.Close + "," + k + " L" + z.Close + "," + (k + d / 2)
                    }
                    var s = z.lineElement;
                    if (!s) {
                        s = this.renderer.path(n, {});
                        this.renderer.attr(s, {
                            fill: g.fillColor,
                            "fill-opacity": q["fill-opacity"],
                            "stroke-opacity": q["fill-opacity"],
                            stroke: g.lineColor,
                            "stroke-width": q["stroke-width"],
                            "stroke-dasharray": q["stroke-dasharray"]
                        });
                        z.lineElement = s
                    }
                    if (b == 1) {
                        this._installHandlers(s, "column", q.groupIndex, q.seriesIndex, v)
                    }
                }
            }
        },
        _renderScatterSeries: function(d, B, D) {
            var q = this.seriesGroups[d];
            if (!q.series || q.series.length == 0) {
                return
            }
            var e = q.type.indexOf("bubble") != -1;
            var t = q.orientation == "horizontal";
            var l = B;
            if (t) {
                l = {
                    x: B.y,
                    y: B.x,
                    width: B.height,
                    height: B.width
                }
            }
            var m = this._calcGroupOffsets(d, l);
            if (!m || m.xoffsets.length == 0) {
                return
            }
            var L = l.width;
            var b;
            if (q.polar || q.spider) {
                b = this._getPolarAxisCoords(d, l);
                L = 2 * b.r
            }
            var T = this._alignValuesWithTicks(d);
            var p = this._getGroupGradientType(d);
            if (!D) {
                D = "to"
            }
            for (var f = 0; f < q.series.length; f++) {
                var R = this._getSerieSettings(d, f);
                var I = q.series[f];
                var w = I.dataField;
                var k = a.isFunction(I.colorFunction);
                var J = this._getColors(d, f, NaN, p);
                var S = NaN,
                    v = NaN;
                if (e) {
                    for (var Q = m.xoffsets.first; Q <= m.xoffsets.last; Q++) {
                        var A = this._getDataValueAsNumber(Q, (I.radiusDataField || I.sizeDataField), d);
                        if (typeof(A) != "number") {
                            throw "Invalid radiusDataField value at [" + Q + "]"
                        }
                        if (!isNaN(A)) {
                            if (isNaN(S) || A < S) {
                                S = A
                            }
                            if (isNaN(v) || A > v) {
                                v = A
                            }
                        }
                    }
                }
                var h = I.minRadius || I.minSymbolSize;
                if (isNaN(h)) {
                    h = L / 50
                }
                var C = I.maxRadius || I.maxSymbolSize;
                if (isNaN(C)) {
                    C = L / 25
                }
                if (h > C) {
                    C = h
                }
                var K = I.radius;
                if (isNaN(K) && !isNaN(I.symbolSize)) {
                    K = (I.symbolType == "circle") ? I.symbolSize / 2 : I.symbolSize
                } else {
                    K = 5
                }
                var E = this._getAnimProps(d, f);
                var z = E.enabled && !this._isToggleRefresh && m.xoffsets.length < 5000 ? E.duration : 0;
                var u = {
                    groupIndex: d,
                    seriesIndex: f,
                    symbolType: I.symbolType,
                    symbolSize: I.symbolSize,
                    "fill-opacity": R.opacity,
                    "stroke-opacity": R.opacity,
                    "stroke-width": R.stroke,
                    "stroke-dasharray": R.dashStyle,
                    items: [],
                    polarAxisCoords: b
                };
                for (var Q = m.xoffsets.first; Q <= m.xoffsets.last; Q++) {
                    var A = this._getDataValueAsNumber(Q, w, d);
                    if (typeof(A) != "number") {
                        continue
                    }
                    var H = m.xoffsets.data[Q];
                    var F = m.xoffsets.xvalues[Q];
                    var G = m.offsets[f][Q][D];
                    if (isNaN(H) || isNaN(G)) {
                        continue
                    }
                    if (t) {
                        var O = H;
                        H = G;
                        G = O + B.y
                    } else {
                        H += B.x
                    }
                    var M = K;
                    if (e) {
                        var n = this._getDataValueAsNumber(Q, (I.radiusDataField || I.sizeDataField), d);
                        if (typeof(n) != "number") {
                            continue
                        }
                        M = h + (C - h) * (n - S) / Math.max(1, v - S);
                        if (isNaN(M)) {
                            M = h
                        }
                    }
                    var j = NaN,
                        N = NaN;
                    var o = 0;
                    if (F != undefined && this._elementRenderInfo && this._elementRenderInfo.length > d) {
                        var c = this._elementRenderInfo[d].series[f][F];
                        if (c && !isNaN(c.to)) {
                            j = c.to;
                            N = c.xoffset;
                            o = K;
                            if (t) {
                                var O = N;
                                N = j;
                                j = O + B.y
                            } else {
                                N += B.x
                            }
                            if (e) {
                                o = h + (C - h) * (c.valueRadius - S) / Math.max(1, v - S);
                                if (isNaN(o)) {
                                    o = h
                                }
                            }
                        }
                    }
                    if (k) {
                        J = this._getColors(d, f, Q, p)
                    }
                    u.items.push({
                        from: o,
                        to: M,
                        itemIndex: Q,
                        fill: J.fillColor,
                        stroke: J.lineColor,
                        x: H,
                        y: G,
                        xFrom: N,
                        yFrom: j
                    })
                }
                this._animR(u, 0);
                var g = this;
                var P;
                this._enqueueAnimation("series", undefined, undefined, z, function(s, i, r) {
                    g._animR(i, r)
                }, u)
            }
        },
        _animR: function(m, f) {
            var g = m.items;
            var n = m.symbolType || "circle";
            var c = m.symbolSize;
            for (var e = 0; e < g.length; e++) {
                var l = g[e];
                var j = l.x;
                var h = l.y;
                var b = Math.round((l.to - l.from) * f + l.from);
                if (!isNaN(l.yFrom)) {
                    h = l.yFrom + (h - l.yFrom) * f
                }
                if (!isNaN(l.xFrom)) {
                    j = l.xFrom + (j - l.xFrom) * f
                }
                if (m.polarAxisCoords) {
                    var k = this._toPolarCoord(m.polarAxisCoords, this._plotRect, j, h);
                    j = k.x;
                    h = k.y
                }
                j = a.jqx._ptrnd(j);
                h = a.jqx._ptrnd(h);
                b = a.jqx._ptrnd(b);
                var d = l.element;
                if (n == "circle") {
                    if (!d) {
                        d = this.renderer.circle(j, h, b);
                        this.renderer.attr(d, {
                            fill: l.fill,
                            "fill-opacity": m["fill-opacity"],
                            "stroke-opacity": m["fill-opacity"],
                            stroke: l.stroke,
                            "stroke-width": m["stroke-width"],
                            "stroke-dasharray": m["stroke-dasharray"]
                        });
                        l.element = d
                    }
                    if (this._isVML) {
                        this.renderer.updateCircle(d, undefined, undefined, b)
                    } else {
                        this.renderer.attr(d, {
                            r: b,
                            cy: h,
                            cx: j
                        })
                    }
                } else {
                    if (d) {
                        this.renderer.removeElement(d)
                    }
                    l.element = d = this._drawSymbol(n, j, h, l.fill, m["fill-opacity"], l.stroke, m["stroke-opacity"] || m["fill-opacity"], m["stroke-width"], m["stroke-dasharray"], c || b)
                }
                if (l.labelElement) {
                    this.renderer.removeElement(l.labelElement)
                }
                l.labelElement = this._showLabel(m.groupIndex, m.seriesIndex, l.itemIndex, {
                    x: j - b,
                    y: h - b,
                    width: 2 * b,
                    height: 2 * b
                });
                if (f >= 1) {
                    this._installHandlers(d, "circle", m.groupIndex, m.seriesIndex, l.itemIndex)
                }
            }
        },
        _showToolTip: function(D, B, j, d, c) {
            var g = this;
            var p = g._getCategoryAxis(j);
            if (g._ttEl && j == g._ttEl.gidx && d == g._ttEl.sidx && c == g._ttEl.iidx) {
                return
            }
            var m = g.seriesGroups[j];
            var e = m.series[d];
            var z = g.enableCrosshairs && !(m.polar || m.spider);
            if (g._pointMarker) {
                D = parseInt(g._pointMarker.x + 5);
                B = parseInt(g._pointMarker.y - 5)
            } else {
                z = false
            }
            var N = z && g.showToolTips == false;
            D = a.jqx._ptrnd(D);
            B = a.jqx._ptrnd(B);
            var i = g._ttEl == undefined;
            if (m.showToolTips == false || e.showToolTips == false) {
                return
            }
            var q = e.toolTipFormatSettings || m.toolTipFormatSettings;
            var w = e.toolTipFormatFunction || m.toolTipFormatFunction || g.toolTipFormatFunction;
            var H = g._getColors(j, d, c);
            var v = g._getDataValue(c, p.dataField, j);
            if (p.dataField == undefined || p.dataField == "") {
                v = c
            }
            if (p.type == "date") {
                v = g._castAsDate(v)
            }
            var s = "";
            if (a.isFunction(w)) {
                var F = {};
                var o = 0;
                for (var h in e) {
                    if (h.indexOf("dataField") == 0) {
                        F[h.substring(9, h.length).toLowerCase()] = g._getDataValue(c, e[h], j);
                        o++
                    }
                }
                if (o == 0) {
                    F = g._getDataValue(c, undefined, j)
                } else {
                    if (o == 1) {
                        F = F[""]
                    }
                }
                s = w(F, c, e, m, v, p)
            } else {
                s = g._getFormattedValue(j, d, c, q, w);
                var I = p.toolTipFormatSettings || p.formatSettings;
                var M = p.toolTipFormatFunction || p.formatFunction;
                if (!M && !I && p.type == "date") {
                    M = this._getDefaultDTFormatFn(p.baseUnit || "day")
                }
                var k = g._formatValue(v, I, M);
                if (m.type != "pie" && m.type != "donut") {
                    var G = (p.displayText || p.dataField || "");
                    if (G.length > 0) {
                        s = G + ": " + k + "<br>" + s
                    } else {
                        s = k + "<br>" + s
                    }
                } else {
                    v = g._getDataValue(c, e.displayText || e.dataField, j);
                    k = g._formatValue(v, I, M);
                    s = k + ": " + s
                }
            }
            var K = e.toolTipClass || m.toolTipClass || this.toThemeProperty("jqx-chart-tooltip-text", null);
            var n = e.toolTipBackground || m.toolTipBackground || "#FFFFFF";
            var l = e.toolTipLineColor || m.toolTipLineColor || H.lineColor;
            if (!g._ttEl) {
                g._ttEl = {}
            }
            g._ttEl.sidx = d;
            g._ttEl.gidx = j;
            g._ttEl.iidx = c;
            rect = g.renderer.getRect();
            if (z) {
                var C = a.jqx._ptrnd(g._pointMarker.x);
                var A = a.jqx._ptrnd(g._pointMarker.y);
                if (g._ttEl.vLine && g._ttEl.hLine) {
                    g.renderer.attr(g._ttEl.vLine, {
                        x1: C,
                        x2: C
                    });
                    g.renderer.attr(g._ttEl.hLine, {
                        y1: A,
                        y2: A
                    })
                } else {
                    var r = g.crosshairsColor || g._defaultLineColor;
                    g._ttEl.vLine = g.renderer.line(C, g._plotRect.y, C, g._plotRect.y + g._plotRect.height, {
                        stroke: r,
                        "stroke-width": g.crosshairsLineWidth || 1,
                        "stroke-dasharray": g.crosshairsDashStyle || ""
                    });
                    g._ttEl.hLine = g.renderer.line(g._plotRect.x, A, g._plotRect.x + g._plotRect.width, A, {
                        stroke: r,
                        "stroke-width": g.crosshairsLineWidth || 1,
                        "stroke-dasharray": g.crosshairsDashStyle || ""
                    })
                }
            }
            if (!N && g.showToolTips != false) {
                var L = !i ? g._ttEl.box : document.createElement("div");
                var E = {
                    left: 0,
                    top: 0
                };
                if (i) {
                    L.style.position = "absolute";
                    L.style.cursor = "default";
                    L.style.overflow = "hidden";
                    a(L).addClass("jqx-rc-all jqx-button");
                    a(L).css("z-index", 9999999);
                    a(document.body).append(L)
                }
                L.style.backgroundColor = n;
                L.style.borderColor = l;
                g._ttEl.box = L;
                g._ttEl.txt = s;
                var u = "<span class='" + K + "'>" + s + "</span>";
                var J = g._ttEl.tmp;
                if (i) {
                    g._ttEl.tmp = J = document.createElement("div");
                    J.style.position = "absolute";
                    J.style.cursor = "default";
                    J.style.overflow = "hidden";
                    J.style.display = "none";
                    J.style.zIndex = 999999;
                    J.style.backgroundColor = n;
                    J.style.borderColor = l;
                    a(J).addClass("jqx-rc-all jqx-button");
                    g.host.append(J)
                }
                a(J).html(u);
                if (!s || s.length == 0) {
                    a(L).fadeTo(0, 0);
                    return
                }
                var f = {
                    width: a(J).width(),
                    height: a(J).height()
                };
                f.width = f.width + 5;
                f.height = f.height + 6;
                D = Math.max(D, rect.x);
                B = Math.max(B - f.height, rect.y);
                if (f.width > rect.width || f.height > rect.height) {
                    return
                }
                if (D + E.left + f.width > rect.x + rect.width - 5) {
                    D = rect.x + rect.width - f.width - E.left - 5
                }
                if (B + E.top + f.height > rect.y + rect.height - 5) {
                    B = rect.y + rect.height - f.height - 5
                }
                var b = g.host.coord();
                if (i) {
                    a(L).fadeOut(0, 0);
                    L.style.left = E.left + D + b.left + "px";
                    L.style.top = E.top + B + b.top + "px"
                }
                a(L).html(u);
                a(L).clearQueue();
                a(L).animate({
                    left: E.left + D + b.left,
                    top: E.top + B + b.top,
                    opacity: 1
                }, 300, "easeInOutCirc");
                a(L).fadeTo(400, 1)
            }
        },
        _hideToolTip: function(b) {
            if (!this._ttEl) {
                return
            }
            if (this._ttEl.box) {
                if (b == 0) {
                    a(this._ttEl.box).hide()
                } else {
                    a(this._ttEl.box).fadeOut()
                }
            }
            this._hideCrosshairs();
            this._ttEl.gidx = undefined
        },
        _hideCrosshairs: function() {
            if (!this._ttEl) {
                return
            }
            if (this._ttEl.vLine) {
                this.renderer.removeElement(this._ttEl.vLine);
                this._ttEl.vLine = undefined
            }
            if (this._ttEl.hLine) {
                this.renderer.removeElement(this._ttEl.hLine);
                this._ttEl.hLine = undefined
            }
        },
        _showLabel: function(D, z, e, b, r, g, d, j, c, A) {
            var l = this.seriesGroups[D];
            var p = l.series[z];
            var u = {
                width: 0,
                height: 0
            };
            if (p.showLabels == false || (!p.showLabels && !l.showLabels)) {
                return d ? u : undefined
            }
            if (b.width < 0 || b.height < 0) {
                return d ? u : undefined
            }
            var v = p.labelClass || l.labelClass || this.toThemeProperty("jqx-chart-label-text", null);
            var f = p.labelAngle || p.labelsAngle || l.labelAngle || l.labelsAngle || 0;
            if (!isNaN(A)) {
                f = A
            }
            var i = p.labelOffset || p.labelsOffset || l.labelOffset || l.labelsOffset || {};
            var B = {
                x: i.x,
                y: i.y
            };
            if (isNaN(B.x)) {
                B.x = 0
            }
            if (isNaN(B.y)) {
                B.y = 0
            }
            r = r || p.labelsHorizontalAlignment || l.labelsHorizontalAlignment || "center";
            g = g || p.labelsVerticalAlignment || l.labelsVerticalAlignment || "center";
            var t = this._getFormattedValue(D, z, e, undefined, undefined, true);
            var q = b.width;
            var C = b.height;
            if (j == true && r != "center") {
                r = r == "right" ? "left" : "right"
            }
            if (c == true && g != "center" && g != "middle") {
                g = g == "top" ? "bottom" : "top";
                B.y *= -1
            }
            u = this.renderer.measureText(t, f, {
                "class": v
            });
            if (d) {
                return u
            }
            var o = 0;
            if (q > 0) {
                if (r == "" || r == "center") {
                    o += (q - u.width) / 2
                } else {
                    if (r == "right") {
                        o += (q - u.width)
                    }
                }
            }
            var m = 0;
            if (C > 0) {
                if (g == "" || g == "center") {
                    m += (C - u.height) / 2
                } else {
                    if (g == "bottom") {
                        m += (C - u.height)
                    }
                }
            }
            o += b.x + B.x;
            m += b.y + B.y;
            var n = this._plotRect;
            if (o <= n.x) {
                o = n.x + 2
            }
            if (m <= n.y) {
                m = n.y + 2
            }
            var k = {
                width: Math.max(u.width, 1),
                height: Math.max(u.height, 1)
            };
            if (m + k.height >= n.y + n.height) {
                m = n.y + n.height - k.height - 2
            }
            if (o + k.width >= n.x + n.width) {
                o = n.x + n.width - k.width - 2
            }
            var s = this.renderer.text(t, o, m, u.width, u.height, f, {
                "class": v
            }, false, "center", "center");
            this.renderer.attr(s, {
                "class": v
            });
            if (this._isVML) {
                this.renderer.removeElement(s);
                this.renderer.getContainer()[0].appendChild(s)
            }
            return s
        },
        _getAnimProps: function(j, f) {
            var e = this.seriesGroups[j];
            var c = !isNaN(f) ? e.series[f] : undefined;
            var b = this.enableAnimations == true;
            if (e.enableAnimations) {
                b = e.enableAnimations == true
            }
            if (c && c.enableAnimations) {
                b = c.enableAnimations == true
            }
            var i = this.animationDuration;
            if (isNaN(i)) {
                i = 1000
            }
            var d = e.animationDuration;
            if (!isNaN(d)) {
                i = d
            }
            if (c) {
                var h = c.animationDuration;
                if (!isNaN(h)) {
                    i = h
                }
            }
            if (i > 5000) {
                i = 1000
            }
            return {
                enabled: b,
                duration: i
            }
        },
        _isColorTransition: function(f, d, e, g) {
            if (g - 1 < e.xoffsets.first) {
                return false
            }
            var b = this._getColors(f, d, g, this._getGroupGradientType(f));
            var c = this._getColors(f, d, g - 1, this._getGroupGradientType(f));
            return (b.fillColor != c.fillColor)
        },
        _renderLineSeries: function(j, O) {
            var F = this.seriesGroups[j];
            if (!F.series || F.series.length == 0) {
                return
            }
            var r = F.type.indexOf("area") != -1;
            var I = F.type.indexOf("stacked") != -1;
            var d = I && F.type.indexOf("100") != -1;
            var ac = F.type.indexOf("spline") != -1;
            var s = F.type.indexOf("step") != -1;
            var M = F.type.indexOf("range") != -1;
            var ad = F.polar == true || F.spider == true;
            if (ad) {
                s = false
            }
            if (s && ac) {
                return
            }
            var y = this._getDataLen(j);
            var aa = O.width / y;
            var ah = F.orientation == "horizontal";
            var A = this._getCategoryAxis(j).flip == true;
            var w = O;
            if (ah) {
                w = {
                    x: O.y,
                    y: O.x,
                    width: O.height,
                    height: O.width
                }
            }
            var B = this._calcGroupOffsets(j, w);
            if (!B || B.xoffsets.length == 0) {
                return
            }
            if (!this._linesRenderInfo) {
                this._linesRenderInfo = {}
            }
            this._linesRenderInfo[j] = {};
            for (var m = F.series.length - 1; m >= 0; m--) {
                var f = this._getSerieSettings(j, m);
                var af = {
                    groupIndex: j,
                    serieIndex: m,
                    swapXY: ah,
                    isArea: r,
                    isSpline: ac,
                    isRange: M,
                    isPolar: ad,
                    settings: f,
                    segments: [],
                    pointsLength: 0
                };
                var h = this._isSerieVisible(j, m);
                if (!h) {
                    this._linesRenderInfo[j][m] = af;
                    continue
                }
                var H = F.series[m];
                var v = a.isFunction(H.colorFunction);
                var S = B.xoffsets.first;
                var E = S;
                var L = this._getColors(j, m, NaN, this._getGroupGradientType(j));
                var Z = false;
                var t;
                do {
                    var U = [];
                    var R = [];
                    var q = [];
                    var N = -1;
                    var o = 0,
                        n = 0;
                    var P = NaN;
                    var C = NaN;
                    var ag = NaN;
                    if (B.xoffsets.length < 1) {
                        continue
                    }
                    var Q = this._getAnimProps(j, m);
                    var J = Q.enabled && !this._isToggleRefresh && B.xoffsets.length < 10000 && this._isVML != true ? Q.duration : 0;
                    var u = S;
                    t = false;
                    var c = this._getColors(j, m, S, this._getGroupGradientType(j));
                    for (var ab = S; ab <= B.xoffsets.last; ab++) {
                        S = ab;
                        var V = B.xoffsets.data[ab];
                        var T = B.xoffsets.xvalues[ab];
                        if (isNaN(V)) {
                            continue
                        }
                        V = Math.max(V, 1);
                        o = V;
                        n = B.offsets[m][ab].to;
                        var Y = B.offsets[m][ab].from;
                        if (isNaN(n) || isNaN(Y)) {
                            if (H.emptyPointsDisplay == "connect") {
                                continue
                            } else {
                                if (H.emptyPointsDisplay == "zero") {
                                    if (isNaN(n)) {
                                        n = B.baseOffset
                                    }
                                    if (isNaN(Y)) {
                                        Y = B.baseOffset
                                    }
                                } else {
                                    t = true;
                                    break
                                }
                            }
                        }
                        if (v && this._isColorTransition(j, m, B, S)) {
                            if (U.length > 1) {
                                S--;
                                break
                            }
                        }
                        if (this._elementRenderInfo && this._elementRenderInfo.length > j && this._elementRenderInfo[j].series.length > m) {
                            var e = this._elementRenderInfo[j].series[m][T];
                            var ag = a.jqx._ptrnd(e ? e.to : undefined);
                            var G = a.jqx._ptrnd(w.x + (e ? e.xoffset : undefined));
                            q.push(ah ? {
                                y: G,
                                x: ag,
                                index: ab
                            } : {
                                x: G,
                                y: ag,
                                index: ab
                            })
                        }
                        E = ab;
                        if (f.stroke < 2) {
                            if (n - w.y <= 1) {
                                n = w.y + 1
                            }
                            if (Y - w.y <= 1) {
                                Y = w.y + 1
                            }
                            if (w.y + w.height - n <= 1) {
                                n = w.y + w.height - 1
                            }
                            if (w.y + w.height - n <= 1) {
                                Y = w.y + w.height - 1
                            }
                        }
                        if (!r && d) {
                            if (n <= w.y) {
                                n = w.y + 1
                            }
                            if (n >= w.y + w.height) {
                                n = w.y + w.height - 1
                            }
                            if (Y <= w.y) {
                                Y = w.y + 1
                            }
                            if (Y >= w.y + w.height) {
                                Y = w.y + w.height - 1
                            }
                        }
                        V = Math.max(V, 1);
                        o = V + w.x;
                        if (s && !isNaN(P) && !isNaN(C)) {
                            if (C != n) {
                                U.push(ah ? {
                                    y: o,
                                    x: a.jqx._ptrnd(C)
                                } : {
                                    x: o,
                                    y: a.jqx._ptrnd(C)
                                })
                            }
                        }
                        U.push(ah ? {
                            y: o,
                            x: a.jqx._ptrnd(n),
                            index: ab
                        } : {
                            x: o,
                            y: a.jqx._ptrnd(n),
                            index: ab
                        });
                        R.push(ah ? {
                            y: o,
                            x: a.jqx._ptrnd(Y),
                            index: ab
                        } : {
                            x: o,
                            y: a.jqx._ptrnd(Y),
                            index: ab
                        });
                        P = o;
                        C = n;
                        if (isNaN(ag)) {
                            ag = n
                        }
                    }
                    if (U.length == 0) {
                        S++;
                        continue
                    }
                    var D = U[U.length - 1].index;
                    if (v) {
                        L = this._getColors(j, m, D, this._getGroupGradientType(j))
                    }
                    var k = w.x + B.xoffsets.data[u];
                    var X = w.x + B.xoffsets.data[E];
                    if (r && F.alignEndPointsWithIntervals == true) {
                        var z = A ? -1 : 1;
                        if (k > w.x) {
                            k = w.x
                        }
                        if (X < w.x + w.width) {
                            X = w.x + w.width
                        }
                        if (A) {
                            var W = k;
                            k = X;
                            X = W
                        }
                    }
                    X = a.jqx._ptrnd(X);
                    k = a.jqx._ptrnd(k);
                    var l = B.baseOffset;
                    ag = a.jqx._ptrnd(ag);
                    var g = a.jqx._ptrnd(n) || l;
                    if (M) {
                        U = U.concat(R.reverse())
                    }
                    af.pointsLength += U.length;
                    var b = {
                        lastItemIndex: D,
                        colorSettings: L,
                        pointsArray: U,
                        pointsStart: q,
                        left: k,
                        right: X,
                        pyStart: ag,
                        pyEnd: g,
                        yBase: l,
                        labelElements: [],
                        symbolElements: []
                    };
                    af.segments.push(b)
                } while (S < B.xoffsets.length - 1 || t);
                this._linesRenderInfo[j][m] = af
            }
            var K = this._linesRenderInfo[j];
            var ae = [];
            for (var ab in K) {
                ae.push(K[ab])
            }
            ae = ae.sort(function(ai, i) {
                return ai.serieIndex - i.serieIndex
            });
            if (r && I) {
                ae.reverse()
            }
            for (var ab = 0; ab < ae.length; ab++) {
                var af = ae[ab];
                this._animateLine(af, J == 0 ? 1 : 0);
                var p = this;
                this._enqueueAnimation("series", undefined, undefined, J, function(ai, i, aj) {
                    p._animateLine(i, aj)
                }, af)
            }
        },
        _animateLine: function(v, b) {
            var A = v.settings;
            var f = v.groupIndex;
            var g = v.serieIndex;
            var j = this.seriesGroups[f];
            var r = j.series[g];
            var u = this._getSymbol(f, g);
            var o = r.showLabels == true || (j.showLabels && r.showLabels != false);
            var p = 0;
            for (var d = 0; d < v.segments.length; d++) {
                var t = v.segments[d];
                var w = this._calculateLine(f, v.pointsLength, p, t.pointsArray, t.pointsStart, t.yBase, b, v.isArea, v.swapXY);
                p += t.pointsArray.length;
                if (w == "") {
                    continue
                }
                var q = w.split(" ");
                var y = q.length;
                var h = w;
                if (h != "") {
                    h = this._buildLineCmd(w, v.isRange, t.left, t.right, t.pyStart, t.pyEnd, t.yBase, v.isArea, v.isPolar, v.isSpline, v.swapXY)
                } else {
                    h = "M 0 0"
                }
                var l = t.colorSettings;
                if (!t.pathElement) {
                    t.pathElement = this.renderer.path(h, {
                        "stroke-width": A.stroke,
                        stroke: l.lineColor,
                        "stroke-opacity": A.opacity,
                        "fill-opacity": A.opacity,
                        "stroke-dasharray": A.dashStyle,
                        fill: v.isArea ? l.fillColor : "none"
                    });
                    this._installHandlers(t.pathElement, "path", f, g, t.lastItemIndex)
                } else {
                    this.renderer.attr(t.pathElement, {
                        d: h
                    })
                }
                if (t.labelElements) {
                    for (var z = 0; z < t.labelElements.length; z++) {
                        this.renderer.removeElement(t.labelElements[z])
                    }
                    t.labelElements = []
                }
                if (t.symbolElements) {
                    for (var z = 0; z < t.symbolElements.length; z++) {
                        this.renderer.removeElement(t.symbolElements[z])
                    }
                    t.symbolElements = []
                }
                if (t.pointsArray.length == q.length) {
                    if (u != "none" || o) {
                        var B = r.symbolSize;
                        for (var z = 0; z < q.length; z++) {
                            var s = q[z].split(",");
                            s = {
                                x: parseFloat(s[0]),
                                y: parseFloat(s[1])
                            };
                            if (u != "none") {
                                var n = this._getColors(f, g, t.pointsArray[z].index, this._getGroupGradientType(f));
                                var e = this._drawSymbol(u, s.x, s.y, n.fillColorSymbol, A.opacity, n.lineColorSymbol, A.opacity, 1, undefined, B);
                                t.symbolElements.push(e)
                            }
                            if (o) {
                                var k = (z > 0 ? q[z - 1] : q[z]).split(",");
                                k = {
                                    x: parseFloat(k[0]),
                                    y: parseFloat(k[1])
                                };
                                var m = (z < q.length - 1 ? q[z + 1] : q[z]).split(",");
                                m = {
                                    x: parseFloat(m[0]),
                                    y: parseFloat(m[1])
                                };
                                s = this._adjustLineLabelPosition(f, g, t.pointsArray[z].index, s, k, m);
                                var c = this._showLabel(f, g, t.pointsArray[z].index, {
                                    x: s.x,
                                    y: s.y,
                                    width: 0,
                                    height: 0
                                });
                                t.labelElements.push(c)
                            }
                        }
                    }
                }
                if (b == 1 && u != "none") {
                    for (var z = 0; z < t.symbolElements.length; z++) {
                        if (!t.pointsArray[z].index) {
                            continue
                        }
                        this._installHandlers(t.symbolElements[z], "symbol", f, g, t.pointsArray[z].index)
                    }
                }
            }
        },
        _adjustLineLabelPosition: function(i, g, d, h, f, e) {
            var b = this._showLabel(i, g, d, {
                width: 0,
                height: 0
            }, "", "", true);
            var c = {
                x: 0,
                y: 0
            };
            if (h.y == f.y && h.x == f.x) {
                if (e.y < h.y) {
                    c = {
                        x: h.x,
                        y: h.y + b.height
                    }
                } else {
                    c = {
                        x: h.x,
                        y: h.y - b.height
                    }
                }
            } else {
                if (h.y == e.y && h.x == e.x) {
                    if (f.y < h.y) {
                        c = {
                            x: h.x,
                            y: h.y + b.height
                        }
                    } else {
                        c = {
                            x: h.x,
                            y: h.y - b.height
                        }
                    }
                }
            }
            if (h.y > f.y && h.y > e.y) {
                c = {
                    x: h.x,
                    y: h.y + b.height
                }
            } else {
                c = {
                    x: h.x,
                    y: h.y - b.height
                }
            }
            return c
        },
        _calculateLine: function(h, v, p, o, n, f, e, z, c) {
            var w = this.seriesGroups[h];
            var m;
            if (w.polar == true || w.spider == true) {
                m = this._getPolarAxisCoords(h, this._plotRect)
            }
            var s = "";
            var t = o.length;
            if (!z && n.length == 0) {
                var r = v * e;
                t = r - p
            }
            var j = NaN;
            for (var u = 0; u < t + 1 && u < o.length; u++) {
                if (u > 0) {
                    s += " "
                }
                var k = o[u].y;
                var l = o[u].x;
                var b = !z ? k : f;
                var d = l;
                if (n && n.length > u) {
                    b = n[u].y;
                    d = n[u].x;
                    if (isNaN(b) || isNaN(d)) {
                        b = k;
                        d = l
                    }
                }
                j = d;
                if (t <= o.length && u > 0 && u == t) {
                    d = o[u - 1].x;
                    b = o[u - 1].y
                }
                if (c) {
                    l = a.jqx._ptrnd((l - b) * (z ? e : 1) + b);
                    k = a.jqx._ptrnd(k)
                } else {
                    l = a.jqx._ptrnd((l - d) * e + d);
                    k = a.jqx._ptrnd((k - b) * e + b)
                }
                if (m) {
                    var q = this._toPolarCoord(m, this._plotRect, l, k);
                    l = q.x;
                    k = q.y
                }
                s += l + "," + k;
                if (o.length == 1 && !z) {
                    s += " " + (l + 2) + "," + (k + 2)
                }
            }
            return s
        },
        _buildLineCmd: function(k, i, f, o, n, b, p, m, q, d, j) {
            var e = k;
            var c = j ? p + "," + f : f + "," + p;
            var h = j ? p + "," + o : o + "," + p;
            if (m && !q && !i) {
                e = c + " " + k + " " + h
            }
            if (d) {
                e = this._getBezierPoints(e)
            }
            var l = e.split(" ");
            var g = l[0].replace("M", "");
            if (m && !q) {
                if (!i) {
                    e = "M " + c + " L " + g + " " + e
                } else {
                    e = "M " + g + " L " + g + (d ? "" : (" L " + g + " ")) + e
                }
            } else {
                if (!d) {
                    e = "M " + g + " L " + g + " " + e
                }
            }
            if (q) {
                e += " Z"
            }
            return e
        },
        _getSerieSettings: function(h, b) {
            var g = this.seriesGroups[h];
            var f = g.type.indexOf("area") != -1;
            var e = g.type.indexOf("line") != -1;
            var c = g.series[b];
            var j = c.dashStyle || g.dashStyle || "";
            var d = c.opacity || g.opacity;
            if (isNaN(d) || d < 0 || d > 1) {
                d = 1
            }
            var i = c.lineWidth;
            if (isNaN(i) && i != "auto") {
                i = g.lineWidth
            }
            if (i == "auto" || isNaN(i) || i < 0 || i > 15) {
                if (f) {
                    i = 2
                } else {
                    if (e) {
                        i = 3
                    } else {
                        i = 1
                    }
                }
            }
            return {
                stroke: i,
                opacity: d,
                dashStyle: j
            }
        },
        _getColors: function(t, p, d, e, b) {
            var k = this.seriesGroups[t];
            var o = k.series[p];
            var c = o.useGradient;
            if (c == undefined) {
                c = o.useGradientColors
            }
            if (c == undefined) {
                c = k.useGradient
            }
            if (c == undefined) {
                c = k.useGradientColors
            }
            if (c == undefined) {
                c = true
            }
            var l = this._getSeriesColors(t, p, d);
            if (!l.fillColor) {
                l.fillColor = color;
                l.fillColorSelected = a.jqx.adjustColor(color, 1.1);
                l.fillColorAlt = a.jqx.adjustColor(color, 4);
                l.fillColorAltSelected = a.jqx.adjustColor(color, 3);
                l.lineColor = l.symbolColor = a.jqx.adjustColor(color, 0.9);
                l.lineColorSelected = l.symbolColorSelected = a.jqx.adjustColor(color, 0.9)
            }
            var h = [
                [0, 1.4],
                [100, 1]
            ];
            var f = [
                [0, 1],
                [25, 1.1],
                [50, 1.4],
                [100, 1]
            ];
            var n = [
                [0, 1.3],
                [90, 1.2],
                [100, 1]
            ];
            var j = NaN;
            if (!isNaN(b)) {
                j = b == 2 ? h : f
            }
            if (c) {
                var q = {};
                for (var r in l) {
                    q[r] = l[r]
                }
                l = q;
                if (e == "verticalLinearGradient" || e == "horizontalLinearGradient") {
                    var g = e == "verticalLinearGradient" ? j || h : j || f;
                    var m = ["fillColor", "fillColorSelected", "fillColorAlt", "fillColorAltSelected"];
                    for (var r in m) {
                        l[m[r]] = this.renderer._toLinearGradient(l[m[r]], e == "verticalLinearGradient", g)
                    }
                } else {
                    if (e == "radialGradient") {
                        var s;
                        var j = h;
                        if ((k.type == "pie" || k.type == "donut" || k.polar) && d != undefined && this._renderData[t] && this._renderData[t].offsets[p]) {
                            s = this._renderData[t].offsets[p][d];
                            j = n
                        }
                        l.fillColor = this.renderer._toRadialGradient(l.fillColor, j, s);
                        l.fillColorSelected = this.renderer._toRadialGradient(l.fillColorSelected, j, s)
                    }
                }
            }
            return l
        },
        _installHandlers: function(c, f, i, h, d) {
            if (!this.enableEvents) {
                return false
            }
            var j = this;
            var e = this.seriesGroups[i];
            var k = this.seriesGroups[i].series[h];
            var b = e.type.indexOf("line") != -1 || e.type.indexOf("area") != -1;
            if (!b) {
                this.renderer.addHandler(c, "mousemove", function(m) {
                    var l = j._selected;
                    if (l && l.isLineType && l.linesUnselectMode == "click" && !(l.group == i && l.series == h)) {
                        return
                    }
                    m.preventDefault();
                    var g = m.pageX || m.clientX || m.screenX;
                    var o = m.pageY || m.clientY || m.screenY;
                    var n = j.host.offset();
                    g -= n.left;
                    o -= n.top;
                    if (j._mouseX == g && j._mouseY == o) {
                        return
                    }
                    if (j._ttEl) {
                        if (j._ttEl.gidx == i && j._ttEl.sidx == h && j._ttEl.iidx == d) {
                            return
                        }
                    }
                    j._startTooltipTimer(i, h, d)
                });
                this.renderer.addHandler(c, "mouseout", function(l) {
                    if (!isNaN(j._lastClickTs) && (new Date()).valueOf() - j._lastClickTs < 100) {
                        return
                    }
                    l.preventDefault();
                    if (d != undefined) {
                        j._cancelTooltipTimer()
                    }
                    if (b) {
                        return
                    }
                    var g = j._selected;
                    if (g && g.isLineType && g.linesUnselectMode == "click" && !(g.group == i && g.series == h)) {
                        return
                    }
                    j._unselect()
                })
            }
            this.renderer.addHandler(c, "mouseover", function(l) {
                l.preventDefault();
                var g = j._selected;
                if (g && g.isLineType && g.linesUnselectMode == "click" && !(g.group == i && g.series == h)) {
                    return
                }
                j._select(c, f, i, h, d, d)
            });
            this.renderer.addHandler(c, "click", function(g) {
                clearTimeout(j._hostClickTimer);
                j._lastClickTs = (new Date()).valueOf();
                if (b && (f != "symbol" && f != "pointMarker")) {
                    return
                }
                if (e.type.indexOf("column") != -1) {
                    j._unselect()
                }
                if (isNaN(d)) {
                    return
                }
                j._raiseItemEvent("click", e, k, d)
            })
        },
        _getHorizontalOffset: function(A, s, k, j) {
            var c = this._plotRect;
            var h = this._getDataLen(A);
            if (h == 0) {
                return {
                    index: undefined,
                    value: k
                }
            }
            var p = this._calcGroupOffsets(A, this._plotRect);
            if (p.xoffsets.length == 0) {
                return {
                    index: undefined,
                    value: undefined
                }
            }
            var n = k;
            var m = j;
            var w = this.seriesGroups[A];
            var l;
            if (w.polar || w.spider) {
                l = this._getPolarAxisCoords(A, c)
            }
            if (w.orientation == "horizontal" && !l) {
                var z = n;
                n = m;
                m = z
            }
            var e = this._getCategoryAxis(A).flip == true;
            var b, o, v, f;
            for (var t = p.xoffsets.first; t <= p.xoffsets.last; t++) {
                var u = p.xoffsets.data[t];
                var d = p.offsets[s][t].to;
                var q = 0;
                if (l) {
                    var r = this._toPolarCoord(l, c, u + c.x, d);
                    u = r.x;
                    d = r.y;
                    q = a.jqx._ptdist(n, m, u, d)
                } else {
                    u += c.x;
                    d += c.y;
                    q = Math.abs(n - u)
                }
                if (isNaN(b) || b > q) {
                    b = q;
                    o = t;
                    v = u;
                    f = d
                }
            }
            return {
                index: o,
                value: p.xoffsets.data[o],
                polarAxisCoords: l,
                x: v,
                y: f
            }
        },
        onmousemove: function(l, k) {
            if (this._mouseX == l && this._mouseY == k) {
                return
            }
            this._mouseX = l;
            this._mouseY = k;
            if (!this._selected) {
                return
            }
            var B = this._selected.group;
            var r = this._selected.series;
            var w = this.seriesGroups[B];
            var o = w.series[r];
            var b = this._plotRect;
            if (this.renderer) {
                b = this.renderer.getRect();
                b.x += 5;
                b.y += 5;
                b.width -= 10;
                b.height -= 10
            }
            if (l < b.x || l > b.x + b.width || k < b.y || k > b.y + b.height) {
                this._hideToolTip();
                this._unselect();
                return
            }
            var e = w.orientation == "horizontal";
            var b = this._plotRect;
            if (w.type.indexOf("line") != -1 || w.type.indexOf("area") != -1) {
                var h = this._getHorizontalOffset(B, this._selected.series, l, k);
                var v = h.index;
                if (v == undefined) {
                    return
                }
                if (this._selected.item != v) {
                    var q = this._linesRenderInfo[B][r].segments;
                    var t = 0;
                    while (v > q[t].lastItemIndex) {
                        t++;
                        if (t >= q.length) {
                            return
                        }
                    }
                    var c = q[t].pathElement;
                    var C = q[t].lastItemIndex;
                    this._unselect(false);
                    this._select(c, "path", B, r, v, C)
                } else {
                    return
                }
                var n = this._getSymbol(this._selected.group, this._selected.series);
                if (n == "none") {
                    n = "circle"
                }
                var p = this._calcGroupOffsets(B, b);
                var d = p.offsets[this._selected.series][v].to;
                var u = d;
                if (w.type.indexOf("range") != -1) {
                    u = p.offsets[this._selected.series][v].from
                }
                var m = e ? l : k;
                if (!isNaN(u) && Math.abs(m - u) < Math.abs(m - d)) {
                    k = u
                } else {
                    k = d
                }
                if (isNaN(k)) {
                    return
                }
                l = h.value;
                if (e) {
                    var z = l;
                    l = k;
                    k = z + b.y
                } else {
                    l += b.x
                }
                if (h.polarAxisCoords) {
                    l = h.x;
                    k = h.y
                }
                k = a.jqx._ptrnd(k);
                l = a.jqx._ptrnd(l);
                if (this._pointMarker && this._pointMarker.element) {
                    this.renderer.removeElement(this._pointMarker.element);
                    this._pointMarker.element = undefined
                }
                if (isNaN(l) || isNaN(k)) {
                    return
                }
                var j = this._getSeriesColors(B, r, v);
                var f = o.opacity;
                if (isNaN(f) || f < 0 || f > 1) {
                    f = w.opacity
                }
                if (isNaN(f) || f < 0 || f > 1) {
                    f = 1
                }
                var A = o.symbolSizeSelected;
                if (isNaN(A)) {
                    A = o.symbolSize
                }
                if (isNaN(A) || A > 50 || A < 0) {
                    A = w.symbolSize
                }
                if (isNaN(A) || A > 50 || A < 0) {
                    A = 6
                }
                this._pointMarker = {
                    type: n,
                    x: l,
                    y: k,
                    gidx: B,
                    sidx: r,
                    iidx: v
                };
                this._pointMarker.element = this._drawSymbol(n, l, k, j.fillColorSymbolSelected, f, j.lineColorSymbolSelected, f, 1, undefined, A);
                this._installHandlers(this._pointMarker.element, "pointMarker", B, r, v);
                this._startTooltipTimer(B, this._selected.series, v)
            }
        },
        _drawSymbol: function(i, l, j, c, m, k, f, g, b, o) {
            var e;
            var h = o || 6;
            var d = h / 2;
            switch (i) {
                case "none":
                    return undefined;
                case "circle":
                    e = this.renderer.circle(l, j, h / 2);
                    break;
                case "square":
                    h = h - 1;
                    d = h / 2;
                    e = this.renderer.rect(l - d, j - d, h, h);
                    break;
                case "diamond":
                    var n = "M " + (l - d) + "," + (j) + " L" + (l) + "," + (j - d) + " L" + (l + d) + "," + (j) + " L" + (l) + "," + (j + d) + " Z";
                    e = this.renderer.path(n);
                    break;
                case "triangle_up":
                case "triangle":
                    var n = "M " + (l - d) + "," + (j + d) + " L " + (l + d) + "," + (j + d) + " L " + (l) + "," + (j - d) + " Z";
                    e = this.renderer.path(n);
                    break;
                case "triangle_down":
                    var n = "M " + (l - d) + "," + (j - d) + " L " + (l) + "," + (j + d) + " L " + (l + d) + "," + (j - d) + " Z";
                    e = this.renderer.path(n);
                    break;
                case "triangle_left":
                    var n = "M " + (l - d) + "," + (j) + " L " + (l + d) + "," + (j + d) + " L " + (l + d) + "," + (j - d) + " Z";
                    e = this.renderer.path(n);
                    break;
                case "triangle_right":
                    var n = "M " + (l - d) + "," + (j - d) + " L " + (l - d) + "," + (j + d) + " L " + (l + d) + "," + (j) + " Z";
                    e = this.renderer.path(n);
                    break;
                default:
                    e = this.renderer.circle(l, j, h)
            }
            this.renderer.attr(e, {
                fill: "#517D12",
                "fill-opacity": m,
                stroke: k,
                "stroke-width": g,
                "stroke-opacity": f,
                "stroke-dasharray": b || ""
            });
            return e
        },
        _getSymbol: function(f, b) {
            var c = ["circle", "square", "diamond", "triangle_up", "triangle_down", "triangle_left", "triangle_right"];
            var e = this.seriesGroups[f];
            var d = e.series[b];
            var h;
            if (d.symbolType != undefined) {
                h = d.symbolType
            }
            if (h == undefined) {
                h = e.symbolType
            }
            if (h == "default") {
                return c[b % c.length]
            } else {
                if (h != undefined) {
                    return h
                }
            }
            return "none"
        },
        _startTooltipTimer: function(h, f, d) {
            this._cancelTooltipTimer();
            var b = this;
            var e = b.seriesGroups[h];
            var c = this.toolTipShowDelay || this.toolTipDelay;
            if (isNaN(c) || c > 10000 || c < 0) {
                c = 500
            }
            if (this._ttEl || (true == this.enableCrosshairs && false == this.showToolTips)) {
                c = 0
            }
            clearTimeout(this._tttimerHide);
            if (c == 0) {
                b._showToolTip(b._mouseX, b._mouseY - 3, h, f, d)
            }
            this._tttimer = setTimeout(function() {
                if (c != 0) {
                    b._showToolTip(b._mouseX, b._mouseY - 3, h, f, d)
                }
                var g = b.toolTipHideDelay;
                if (isNaN(g)) {
                    g = 4000
                }
                b._tttimerHide = setTimeout(function() {
                    b._hideToolTip();
                    b._unselect()
                }, g)
            }, c)
        },
        _cancelTooltipTimer: function() {
            clearTimeout(this._tttimer)
        },
        _getGroupGradientType: function(c) {
            var b = this.seriesGroups[c];
            if (b.type.indexOf("area") != -1) {
                return b.orientation == "horizontal" ? "horizontalLinearGradient" : "verticalLinearGradient"
            } else {
                if (b.type.indexOf("column") != -1 || b.type.indexOf("candle") != -1) {
                    if (b.polar) {
                        return "radialGradient"
                    }
                    return b.orientation == "horizontal" ? "verticalLinearGradient" : "horizontalLinearGradient"
                } else {
                    if (b.type.indexOf("scatter") != -1 || b.type.indexOf("bubble") != -1 || b.type.indexOf("pie") != -1 || b.type.indexOf("donut") != -1) {
                        return "radialGradient"
                    }
                }
            }
            return undefined
        },
        _select: function(h, l, o, n, i, m) {
            if (this._selected) {
                if ((this._selected.item != i || this._selected.series != n || this._selected.group != o)) {
                    this._unselect()
                } else {
                    return
                }
            }
            var k = this.seriesGroups[o];
            var p = k.series[n];
            var f = k.type.indexOf("line") != -1 && k.type.indexOf("area") == -1;
            this._selected = {
                element: h,
                type: l,
                group: o,
                series: n,
                item: i,
                iidxBase: m,
                isLineType: f,
                linesUnselectMode: p.linesUnselectMode || k.linesUnselectMode
            };
            var b = this._getColors(o, n, m || i, this._getGroupGradientType(o));
            var c = b.fillColorSelected;
            if (f) {
                c = "none"
            }
            var e = this._getSerieSettings(o, n);
            var d = l == "symbol" ? b.lineColorSymbolSelected : b.lineColorSelected;
            c = l == "symbol" ? b.fillColorSymbolSelected : c;
            var j = e.stroke;
            if (this.renderer.getAttr(h, "fill") == b.fillColorAlt) {
                c = b.fillColorAltSelected
            }
            this.renderer.attr(h, {
                stroke: d,
                fill: "#517D12",
                "stroke-width": j
            });
            this._raiseItemEvent("mouseover", k, p, i)
        },
        _unselect: function() {
            var o = this;
            if (o._selected) {
                var n = o._selected.group;
                var m = o._selected.series;
                var f = o._selected.item;
                var k = o._selected.iidxBase;
                var j = o._selected.type;
                var i = o.seriesGroups[n];
                var p = i.series[m];
                var e = i.type.indexOf("line") != -1 && i.type.indexOf("area") == -1;
                var b = o._getColors(n, m, k || f, o._getGroupGradientType(n));
                var c = b.fillColor;
                if (e) {
                    c = "none"
                }
                var d = o._getSerieSettings(n, m);
                var l = j == "symbol" ? b.lineColorSymbol : b.lineColor;
                c = j == "symbol" ? b.fillColorSymbol : c;
                if (this.renderer.getAttr(o._selected.element, "fill") == b.fillColorAltSelected) {
                    c = b.fillColorAlt
                }
//-------------------------------------M�u column
                var h = d.stroke;
                this.renderer.attr(o._selected.element, {
                    stroke: l,
                    fill: "#517D12",
                    "stroke-width": h
                });
                o._selected = undefined;
                if (!isNaN(f)) {
                    o._raiseItemEvent("mouseout", i, p, f)
                }
            }
            if (o._pointMarker) {
                if (o._pointMarker.element) {
                    o.renderer.removeElement(o._pointMarker.element);
                    o._pointMarker.element = undefined
                }
                o._pointMarker = undefined;
                o._hideCrosshairs()
            }
        },
        _raiseItemEvent: function(f, g, e, c) {
            var d = e[f] || g[f];
            var h = 0;
            for (; h < this.seriesGroups.length; h++) {
                if (this.seriesGroups[h] == g) {
                    break
                }
            }
            if (h == this.seriesGroups.length) {
                return
            }
            var b = {
                event: f,
                seriesGroup: g,
                serie: e,
                elementIndex: c,
                elementValue: this._getDataValue(c, e.dataField, h)
            };
            if (d && a.isFunction(d)) {
                d(b)
            }
            this._raiseEvent(f, b)
        },
        _raiseEvent: function(d, c) {
            var e = new a.Event(d);
            e.owner = this;
            e.args = c;
            var b = this.host.trigger(e);
            return b
        },
        _calcInterval: function(d, j, h) {
            var m = Math.abs(j - d);
            var k = m / h;
            var f = [1, 2, 3, 4, 5, 10, 15, 20, 25, 50, 100];
            var b = [0.5, 0.25, 0.125, 0.1];
            var c = 0.1;
            var g = f;
            if (k < 1) {
                g = b;
                c = 10
            }
            var l = 0;
            do {
                l = 0;
                if (k >= 1) {
                    c *= 10
                } else {
                    c /= 10
                }
                for (var e = 1; e < g.length; e++) {
                    if (Math.abs(g[l] * c - k) > Math.abs(g[e] * c - k)) {
                        l = e
                    } else {
                        break
                    }
                }
            } while (l == g.length - 1);
            return g[l] * c
        },
        _renderDataClone: function() {
            if (!this._renderData || this._isToggleRefresh) {
                return
            }
            var d = this._elementRenderInfo = [];
            if (this._isSelectorRefresh) {
                return
            }
            for (var h = 0; h < this._renderData.length; h++) {
                var c = this._getCategoryAxis(h).dataField;
                while (d.length <= h) {
                    d.push({})
                }
                var b = d[h];
                var f = this._renderData[h];
                if (!f.offsets) {
                    continue
                }
                if (f.valueAxis) {
                    b.valueAxis = {
                        itemOffsets: {}
                    };
                    for (var k in f.valueAxis.itemOffsets) {
                        b.valueAxis.itemOffsets[k] = f.valueAxis.itemOffsets[k]
                    }
                }
                if (f.xAxis) {
                    b.xAxis = {
                        itemOffsets: {}
                    };
                    for (var k in f.xAxis.itemOffsets) {
                        b.xAxis.itemOffsets[k] = f.xAxis.itemOffsets[k]
                    }
                }
                b.series = [];
                var g = b.series;
                var j = this.seriesGroups[h].type;
                var m = j.indexOf("pie") != -1 || j.indexOf("donut") != -1;
                for (var n = 0; n < f.offsets.length; n++) {
                    g.push({});
                    for (var e = 0; e < f.offsets[n].length; e++) {
                        if (!m) {
                            g[n][f.xoffsets.xvalues[e]] = {
                                value: f.offsets[n][e].value,
                                valueFrom: f.offsets[n][e].valueFrom,
                                valueRadius: f.offsets[n][e].valueRadius,
                                xoffset: f.xoffsets.data[e],
                                from: f.offsets[n][e].from,
                                to: f.offsets[n][e].to
                            }
                        } else {
                            var l = f.offsets[n][e];
                            g[n][l.displayValue] = {
                                value: l.value,
                                x: l.x,
                                y: l.y,
                                fromAngle: l.fromAngle,
                                toAngle: l.toAngle
                            }
                        }
                    }
                }
            }
        },
        _getDataPointOffset: function(f, c, d, h, e, b) {
            var g;
            if (isNaN(f)) {
                f = c
            }
            if (!isNaN(d)) {
                g = (a.jqx.log(f, d) - a.jqx.log(c, d)) * h
            } else {
                g = (f - c) * h
            }
            if (this._isVML) {
                g = Math.round(g)
            }
            if (b) {
                g = e + g
            } else {
                g = e - g
            }
            return g
        },
        _calcGroupOffsets: function(l, O) {
            var A = this.seriesGroups[l];
            while (this._renderData.length < l + 1) {
                this._renderData.push({})
            }
            if (this._renderData[l] != null && this._renderData[l].offsets != undefined) {
                return this._renderData[l]
            }
            if (A.type.indexOf("pie") != -1 || A.type.indexOf("donut") != -1) {
                return this._calcPieSeriesGroupOffsets(l, O)
            }
            if (!A.valueAxis || !A.series || A.series.length == 0) {
                return this._renderData[l]
            }
            var B = A.valueAxis.flip == true;
            var R = A.valueAxis.logarithmicScale == true;
            var Q = A.valueAxis.logarithmicScaleBase || 10;
            var W = [];
            var H = A.type.indexOf("stacked") != -1;
            var d = H && A.type.indexOf("100") != -1;
            var N = A.type.indexOf("range") != -1;
            var X = A.type.indexOf("column") != -1;
            var r = this._getDataLen(l);
            var q = A.baselineValue || A.valueAxis.baselineValue || 0;
            if (d) {
                q = 0
            }
            var ai = this._stats.seriesGroups[l];
            if (!ai || !ai.isValid) {
                return
            }
            if (q > ai.max) {
                q = ai.max
            }
            if (q < ai.min) {
                q = ai.min
            }
            var p = (d || R) ? ai.maxRange : ai.max - ai.min;
            var an = ai.min;
            var E = ai.max;
            var P = O.height / (R ? ai.intervals : p);
            var ak = 0;
            if (d) {
                if (an * E < 0) {
                    p /= 2;
                    ak = -(p + q) * P
                } else {
                    ak = -q * P
                }
            } else {
                ak = -(q - an) * P
            }
            if (B) {
                ak = O.y - ak
            } else {
                ak += O.y + O.height
            }
            var aj = [];
            var af = [];
            var V = [];
            var am, J;
            if (R) {
                am = a.jqx.log(E, Q) - a.jqx.log(q, Q);
                if (H) {
                    am = ai.intervals;
                    q = d ? 0 : an
                }
                J = ai.intervals - am;
                if (!B) {
                    ak = O.y + am / ai.intervals * O.height
                }
            }
            ak = a.jqx._ptrnd(ak);
            var c = (an * E < 0) ? O.height / 2 : O.height;
            var m = [];
            var D = [];
            if (A.bands) {
                for (var ad = 0; ad < A.bands.length; ad++) {
                    var u = A.bands[ad].minValue;
                    var ar = A.bands[ad].maxValue;
                    var v = this._getDataPointOffset(u, q, R ? Q : NaN, P, ak, B);
                    var M = this._getDataPointOffset(ar, q, R ? Q : NaN, P, ak, B);
                    D.push({
                        from: v,
                        to: M
                    })
                }
            }
            var Z = [];
            var ao = X || (!X && !H) || d || R;
            for (var ad = 0; ad < A.series.length; ad++) {
                if (!H && R) {
                    m = []
                }
                var F = A.series[ad];
                var G = F.dataField;
                var aq = F.dataFieldFrom;
                var S = F.dataFieldTo;
                var ab = F.radiusDataField || F.sizeDataField;
                W.push([]);
                var g = this._isSerieVisible(l, ad);
                for (var ae = 0; ae < r; ae++) {
                    if (A.type.indexOf("candle") == -1 && A.type.indexOf("ohlc") == -1) {
                        while (Z.length <= ae) {
                            Z.push(0)
                        }
                        var ap = NaN;
                        if (N) {
                            ap = this._getDataValueAsNumber(ae, aq, l);
                            if (isNaN(ap)) {
                                ap = q
                            }
                        }
                        var L = NaN;
                        if (N) {
                            L = this._getDataValueAsNumber(ae, S, l)
                        } else {
                            L = this._getDataValueAsNumber(ae, G, l)
                        }
                        var e = this._getDataValueAsNumber(ae, ab, l);
                        if (!g) {
                            L = NaN
                        }
                        if (isNaN(L) || (R && L <= 0)) {
                            W[ad].push({
                                from: undefined,
                                to: undefined
                            });
                            continue
                        }
                        var K;
                        if (ao) {
                            K = (L >= q) ? aj : af
                        } else {
                            Z[ae] = L = Z[ae] + L
                        }
                        var ah = P * (L - q);
                        if (N) {
                            ah = P * (L - ap)
                        }
                        if (R) {
                            while (m.length <= ae) {
                                m.push({
                                    p: {
                                        value: 0,
                                        height: 0
                                    },
                                    n: {
                                        value: 0,
                                        height: 0
                                    }
                                })
                            }
                            var C = N ? ap : q;
                            var ac = L > C ? m[ae].p : m[ae].n;
                            ac.value += L;
                            if (d) {
                                L = ac.value / (ai.psums[ae] + ai.nsums[ae]) * 100;
                                ah = (a.jqx.log(L, Q) - ai.minPow) * P
                            } else {
                                ah = a.jqx.log(ac.value, Q) - a.jqx.log(C, Q);
                                ah *= P
                            }
                            ah -= ac.height;
                            ac.height += ah
                        }
                        var U = ak;
                        if (N) {
                            var s = 0;
                            if (R) {
                                s = (a.jqx.log(ap, Q) - a.jqx.log(q, Q)) * P
                            } else {
                                s = (ap - q) * P
                            }
                            U += B ? s : -s
                        }
                        if (H) {
                            if (d && !R) {
                                var z = (ai.psums[ae] - ai.nsums[ae]);
                                if (L > q) {
                                    ah = (ai.psums[ae] / z) * c;
                                    if (ai.psums[ae] != 0) {
                                        ah *= L / ai.psums[ae]
                                    }
                                } else {
                                    ah = (ai.nsums[ae] / z) * c;
                                    if (ai.nsums[ae] != 0) {
                                        ah *= L / ai.nsums[ae]
                                    }
                                }
                            }
                            if (ao) {
                                if (isNaN(K[ae])) {
                                    K[ae] = U
                                }
                                U = K[ae]
                            }
                        }
                        if (isNaN(V[ae])) {
                            V[ae] = 0
                        }
                        var ag = V[ae];
                        ah = Math.abs(ah);
                        var Y = ah;
                        h_new = this._isVML ? Math.round(ah) : a.jqx._ptrnd(ah) - 1;
                        if (Math.abs(ah - h_new) > 0.5) {
                            ah = Math.round(ah)
                        } else {
                            ah = h_new
                        }
                        ag += ah - Y;
                        if (!H) {
                            ag = 0
                        }
                        if (Math.abs(ag) > 0.5) {
                            if (ag > 0) {
                                ah -= 1;
                                ag -= 1
                            } else {
                                ah += 1;
                                ag += 1
                            }
                        }
                        V[ae] = ag;
                        if (ad == A.series.length - 1 && d) {
                            var w = 0;
                            for (var aa = 0; aa < ad; aa++) {
                                w += Math.abs(W[aa][ae].to - W[aa][ae].from)
                            }
                            w += ah;
                            if (w < c) {
                                if (ah > 0.5) {
                                    ah = a.jqx._ptrnd(ah + c - w)
                                } else {
                                    var aa = ad - 1;
                                    while (aa >= 0) {
                                        var I = Math.abs(W[aa][ae].to - W[aa][ae].from);
                                        if (I > 1) {
                                            if (W[aa][ae].from > W[aa][ae].to) {
                                                W[aa][ae].from += c - w
                                            }
                                            break
                                        }
                                        aa--
                                    }
                                }
                            }
                        }
                        if (B) {
                            ah *= -1
                        }
                        var T = L < q;
                        if (N) {
                            T = ap > L
                        }
                        var n = isNaN(ap) ? L : {
                            from: ap,
                            to: L
                        };
                        if (T) {
                            if (ao) {
                                K[ae] += ah
                            }
                            W[ad].push({
                                from: U,
                                to: U + ah,
                                value: n,
                                valueFrom: ap,
                                valueRadius: e
                            })
                        } else {
                            if (ao) {
                                K[ae] -= ah
                            }
                            W[ad].push({
                                from: U,
                                to: U - ah,
                                value: n,
                                valueFrom: ap,
                                valueRadius: e
                            })
                        }
                    } else {
                        W[ad].push({});
                        var b = ["Open", "Close", "High", "Low"];
                        for (var al in b) {
                            var o = "dataField" + b[al];
                            if (F[o]) {
                                W[ad][W[ad].length - 1][b[al]] = this._getDataPointOffset(this._getDataValueAsNumber(ae, F[o], l), q, R ? Q : NaN, P, ak, B)
                            }
                        }
                    }
                }
            }
            var t = this._renderData[l];
            t.baseOffset = ak;
            t.offsets = W;
            t.bands = D;
            t.xoffsets = this._calculateXOffsets(l, O.width);
            return this._renderData[l]
        },
        _calcPieSeriesGroupOffsets: function(d, b) {
            var l = this._getDataLen(d);
            var m = this.seriesGroups[d];
            var v = this._renderData[d] = {};
            var D = v.offsets = [];
            for (var z = 0; z < m.series.length; z++) {
                var r = m.series[z];
                var B = r.minAngle;
                if (isNaN(B) || B < 0 || B > 360) {
                    B = 0
                }
                var J = r.maxAngle;
                if (isNaN(J) || J < 0 || J > 360) {
                    J = 360
                }
                var e = J - B;
                var n = r.initialAngle || 0;
                if (n < B) {
                    n = B
                }
                if (n > J) {
                    n = J
                }
                var u = n;
                var f = r.radius || Math.min(b.width, b.height) * 0.4;
                if (isNaN(f)) {
                    f = 1
                }
                var k = r.innerRadius || 0;
                if (isNaN(k) || k >= f) {
                    k = 0
                }
                var c = r.centerOffset || 0;
                var H = a.jqx.getNum([r.offsetX, m.offsetX, b.width / 2]);
                var G = a.jqx.getNum([r.offsetY, m.offsetY, b.height / 2]);
                D.push([]);
                var g = 0;
                var h = 0;
                for (var C = 0; C < l; C++) {
                    var I = this._getDataValueAsNumber(C, r.dataField, d);
                    if (isNaN(I)) {
                        continue
                    }
                    if (!this._isSerieVisible(d, z, C) && r.hiddenPointsDisplay != true) {
                        continue
                    }
                    if (I > 0) {
                        g += I
                    } else {
                        h += I
                    }
                }
                var q = g - h;
                if (q == 0) {
                    q = 1
                }
                for (var C = 0; C < l; C++) {
                    var I = this._getDataValueAsNumber(C, r.dataField, d);
                    if (isNaN(I)) {
                        D[z].push({});
                        continue
                    }
                    var A = r.displayText || r.displayField;
                    var j = this._getDataValue(C, A, d);
                    if (j == undefined) {
                        j = C
                    }
                    var F = 0;
                    var w = this._isSerieVisible(d, z, C);
                    if (w || r.hiddenPointsDisplay == true) {
                        F = Math.abs(I) / q * e
                    }
                    var p = b.x + H;
                    var o = b.y + G;
                    var E = c;
                    if (a.isFunction(c)) {
                        E = c({
                            seriesIndex: z,
                            seriesGroupIndex: d,
                            itemIndex: C
                        })
                    }
                    if (isNaN(E)) {
                        E = 0
                    }
                    var t = {
                        key: d + "_" + z + "_" + C,
                        value: I,
                        displayValue: j,
                        x: p,
                        y: o,
                        fromAngle: u,
                        toAngle: u + F,
                        centerOffset: E,
                        innerRadius: k,
                        outerRadius: f,
                        visible: w
                    };
                    D[z].push(t);
                    u += F
                }
            }
            return v
        },
        _isPointSeriesOnly: function() {
            for (var b = 0; b < this.seriesGroups.length; b++) {
                var c = this.seriesGroups[b];
                if (c.type.indexOf("line") == -1 && c.type.indexOf("area") == -1 && c.type.indexOf("scatter") == -1 && c.type.indexOf("bubble") == -1) {
                    return false
                }
            }
            return true
        },
        _hasColumnSeries: function() {
            var d = ["column", "ohlc", "candlestick"];
            for (var c = 0; c < this.seriesGroups.length; c++) {
                var e = this.seriesGroups[c];
                for (var b in d) {
                    if (e.type.indexOf(d[b]) != -1) {
                        return true
                    }
                }
            }
            return false
        },
        _alignValuesWithTicks: function(f) {
            var b = this._isPointSeriesOnly();
            var c = this.seriesGroups[f];
            var e = this._getCategoryAxis(f);
            var d = e.valuesOnTicks == undefined ? b : e.valuesOnTicks != false;
            if (f == undefined) {
                return d
            }
            if (c.valuesOnTicks == undefined) {
                return d
            }
            return c.valuesOnTicks
        },
        _getYearsDiff: function(c, b) {
            return b.getFullYear() - c.getFullYear()
        },
        _getMonthsDiff: function(c, b) {
            return 12 * (b.getFullYear() - c.getFullYear()) + b.getMonth() - c.getMonth()
        },
        _getDateDiff: function(f, e, d, b) {
            var c = 0;
            if (d != "year" && d != "month") {
                c = e.valueOf() - f.valueOf()
            }
            switch (d) {
                case "year":
                    c = this._getYearsDiff(f, e);
                    break;
                case "month":
                    c = this._getMonthsDiff(f, e);
                    break;
                case "day":
                    c /= (24 * 3600 * 1000);
                    break;
                case "hour":
                    c /= (3600 * 1000);
                    break;
                case "minute":
                    c /= (60 * 1000);
                    break;
                case "second":
                    c /= (1000);
                    break;
                case "millisecond":
                    break
            }
            if (d != "year" && d != "month" && b != false) {
                c = a.jqx._rnd(c, 1, true)
            }
            return c
        },
        _getAsDate: function(b, c) {
            b = this._castAsDate(b);
            if (c == "month") {
                return new Date(b.getFullYear(), b.getMonth(), 1)
            }
            if (c == "year") {
                return new Date(b.getFullYear(), 0, 1)
            }
            if (c == "day") {
                return new Date(b.getFullYear(), b.getMonth(), b.getDate())
            }
            return b
        },
        _getBestDTUnit: function(k, p, q, d, g) {
            var f = "day";
            var m = p.valueOf() - k.valueOf();
            if (m < 1000) {
                f = "second"
            } else {
                if (m < 3600000) {
                    f = "minute"
                } else {
                    if (m < 86400000) {
                        f = "hour"
                    } else {
                        if (m < 2592000000) {
                            f = "day"
                        } else {
                            if (m < 31104000000) {
                                f = "month"
                            } else {
                                f = "year"
                            }
                        }
                    }
                }
            }
            var o = [{
                key: "year",
                cnt: m / (1000 * 60 * 60 * 24 * 365)
            }, {
                key: "month",
                cnt: m / (1000 * 60 * 60 * 24 * 30)
            }, {
                key: "day",
                cnt: m / (1000 * 60 * 60 * 24)
            }, {
                key: "hour",
                cnt: m / (1000 * 60 * 60)
            }, {
                key: "minute",
                cnt: m / (1000 * 60)
            }, {
                key: "second",
                cnt: m / 1000
            }, {
                key: "millisecond",
                cnt: m
            }];
            var l = -1;
            for (var h = 0; h < o.length; h++) {
                if (o[h].key == f) {
                    l = h;
                    break
                }
            }
            var b = -1,
                n = -1;
            for (; l < o.length; l++) {
                if (o[l].cnt / 100 > d) {
                    break
                }
                var c = this._estAxisInterval(k, p, q, d, o[l].key, g);
                var e = this._getDTIntCnt(k, p, c, o[l].key);
                if (b == -1 || b < e) {
                    b = e;
                    n = l
                }
            }
            f = o[n].key;
            return f
        },
        _getCategoryAxisStats: function(f, y, v) {
            var h = this._getDataLen(f);
            var b = y.type == "date" || y.type == "time";
            var j = b ? this._castAsDate(y.minValue) : this._castAsNumber(y.minValue);
            var l = b ? this._castAsDate(y.maxValue) : this._castAsNumber(y.maxValue);
            var r = j,
                t = l;
            var e, k;
            var c = y.type == undefined || y.type == "auto";
            var g = (c || y.type == "basic");
            var s = 0,
                d = 0;
            for (var u = 0; u < h && y.dataField; u++) {
                var q = this._getDataValue(u, y.dataField, f);
                q = b ? this._castAsDate(q) : this._castAsNumber(q);
                if (isNaN(q)) {
                    continue
                }
                if (b) {
                    s++
                } else {
                    d++
                }
                if (isNaN(e) || q < e) {
                    e = q
                }
                if (isNaN(k) || q >= k) {
                    k = q
                }
            }
            if (c && ((!b && d == h) || (b && s == h))) {
                g = false
            }
            if (g) {
                e = 0;
                k = h - 1
            }
            if (isNaN(r)) {
                r = e
            }
            if (isNaN(t)) {
                t = k
            }
            if (b) {
                if (!this._isDate(r)) {
                    r = this._isDate(t) ? t : new Date()
                }
                if (!this._isDate(t)) {
                    t = this._isDate(r) ? r : new Date()
                }
            } else {
                if (isNaN(r)) {
                    r = 0
                }
                if (isNaN(t)) {
                    t = g ? h - 1 : r
                }
            }
            if (e == undefined) {
                e = r
            }
            if (k == undefined) {
                k = t
            }
            var m = y.rangeSelector;
            if (m) {
                var n = m.minValue || r;
                if (n && b) {
                    n = this._castAsDate(n)
                }
                var p = m.maxValue || t;
                if (p && b) {
                    p = this._castAsDate(p)
                }
                if (r < n) {
                    r = n
                }
                if (t < n) {
                    t = p
                }
                if (r > p) {
                    r = n
                }
                if (t > p) {
                    t = p
                }
            }
            var w = y.unitInterval;
            var o, z;
            if (b) {
                o = y.baseUnit;
                if (!o) {
                    o = this._getBestDTUnit(r, t, f, v)
                }
                z = o == "hour" || o == "minute" || o == "second" || o == "millisecond"
            }
            var w = y.unitInterval;
            if (isNaN(w) || w <= 0) {
                w = this._estAxisInterval(r, t, f, v, o)
            }
            return {
                min: r,
                max: t,
                dsRange: {
                    min: e,
                    max: k
                },
                useIndeces: g,
                isDateTime: b,
                isTimeUnit: z,
                dateTimeUnit: o,
                interval: w
            }
        },
        _getDefaultDTFormatFn: function(d) {
            var b = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
            var c;
            if (d == "year" || d == "month" || d == "day") {
                c = function(e) {
                    return e.getDate() + "-" + b[e.getMonth()] + "-" + e.getFullYear()
                }
            } else {
                c = function(e) {
                    return e.getHours() + ":" + e.getMinutes() + ":" + e.getSeconds()
                }
            }
            return c
        },
        _getDTIntCnt: function(f, c, d, i) {
            var e = 0;
            var g = new Date(f);
            var h = new Date(c);
            if (d <= 0) {
                return 1
            }
            while (g.valueOf() < h.valueOf()) {
                if (i == "millisecond") {
                    g.setMilliseconds(g.getMilliseconds() + d)
                } else {
                    if (i == "second") {
                        g.setSeconds(g.getSeconds() + d)
                    } else {
                        if (i == "minute") {
                            g.setMinutes(g.getMinutes() + d)
                        } else {
                            if (i == "hour") {
                                var b = g.valueOf();
                                g.setHours(g.getHours() + d);
                                if (b === g.valueOf()) {
                                    g.setHours(g.getHours() + d + 1)
                                }
                            } else {
                                if (i == "day") {
                                    g.setDate(g.getDate() + d)
                                } else {
                                    if (i == "month") {
                                        g.setMonth(g.getMonth() + d)
                                    } else {
                                        if (i == "year") {
                                            g.setFullYear(g.getFullYear() + d)
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                e++
            }
            return e
        },
        _estAxisInterval: function(e, h, l, b, j, c) {
            var d = [1, 2, 5, 10, 15, 20, 50, 100, 200, 500];
            var g = 0;
            var f = b / ((!isNaN(c) && c > 0) ? c : 50);
            if (this._renderData && this._renderData.length > l && this._renderData[l].xAxis && !isNaN(this._renderData[l].xAxis.avgWidth)) {
                var n = Math.max(1, this._renderData[l].xAxis.avgWidth);
                if (n != 0 && isNaN(c)) {
                    f = 0.9 * b / n
                }
            }
            if (f <= 1) {
                return 1
            }
            var m = 0;
            while (true) {
                var k = g >= d.length ? Math.pow(10, 3 + g - d.length) : d[g];
                if (this._isDate(e) && this._isDate(h)) {
                    m = this._getDTIntCnt(e, h, k, j)
                } else {
                    m = (h - e) / k
                }
                if (m <= f) {
                    return k
                }
                g++
            }
        },
        _getPaddingSize: function(j, e, f, c, l, m) {
            var g = j.min;
            var i = j.max;
            var b = j.interval;
            var d = j.dateTimeUnit;
            if (l) {
                return {
                    left: 0,
                    right: (c / Math.max(1, i - g + 1)) * b
                }
            }
            if (f && !m) {
                return {
                    left: 0,
                    right: 0
                }
            }
            if (this._isDate(g) && this._isDate(i)) {
                var k = this._getDTIntCnt(g, i, Math.min(b, i - g), d);
                var h = c / Math.max(2, k);
                return {
                    left: h / 2,
                    right: h / 2
                }
            }
            var k = Math.max(1, i - g);
            if (k == 1) {
                sz = c / 4;
                return {
                    left: sz,
                    right: sz
                }
            }
            var h = c / (k + 1);
            return {
                left: h / 2,
                right: h / 2
            }
        },
        _calculateXOffsets: function(e, z) {
            var y = this.seriesGroups[e];
            var n = this._getCategoryAxis(e);
            var t = [];
            var l = [];
            var m = this._getDataLen(e);
            var d = this._getCategoryAxisStats(e, n, z);
            var s = d.min;
            var v = d.max;
            var b = d.isDateTime;
            var A = d.isTimeUnit;
            var w = this._hasColumnSeries();
            var c = y.polar || y.spider;
            var k = this._alignValuesWithTicks(e);
            var q = this._getPaddingSize(d, n, k, z, c, w);
            var C = v - s;
            if (C == 0) {
                C = 1
            }
            var B = z - q.left - q.right;
            if (c && k) {
                q.left = q.right = 0
            }
            var h = -1,
                o = -1;
            for (var u = 0; u < m; u++) {
                var r = (n.dataField === undefined) ? u : this._getDataValue(u, n.dataField, e);
                if (d.useIndeces) {
                    if (u < s || u > v) {
                        t.push(NaN);
                        l.push(undefined);
                        continue
                    }
                    t.push(a.jqx._ptrnd(q.left + (u - s) / C * B));
                    l.push(r);
                    if (h == -1) {
                        h = u
                    }
                    if (o == -1 || o < u) {
                        o = u
                    }
                    continue
                }
                r = b ? this._castAsDate(r) : this._castAsNumber(r);
                if (isNaN(r) || r < s || r > v) {
                    t.push(NaN);
                    l.push(undefined);
                    continue
                }
                var p = 0;
                if (!b || (b && A)) {
                    diffFromMin = r - s;
                    p = (r - s) * B / C
                } else {
                    p = (r.valueOf() - s.valueOf()) / (v.valueOf() - s.valueOf()) * B
                }
                p = a.jqx._ptrnd(q.left + p);
                t.push(p);
                l.push(r);
                if (h == -1) {
                    h = u
                }
                if (o == -1 || o < u) {
                    o = u
                }
            }
            if (n.flip == true) {
                for (var u = 0; u < t.length; u++) {
                    if (!isNaN(t[u])) {
                        t[u] = z - t[u]
                    }
                }
            }
            if (A || b) {
                C = this._getDateDiff(s, v, n.baseUnit);
                C = a.jqx._rnd(C, 1, false)
            }
            var j = Math.max(1, C);
            var f = B / j;
            if (h == o) {
                t[h] = q.left + B / 2
            }
            return {
                axisStats: d,
                data: t,
                xvalues: l,
                first: h,
                last: o,
                length: o == -1 ? 0 : o - h + 1,
                itemWidth: f,
                intervalWidth: f * d.interval,
                rangeLength: C,
                useIndeces: d.useIndeces,
                padding: q
            }
        },
        _getCategoryAxis: function(b) {
            if (b == undefined || this.seriesGroups.length <= b) {
                return this.categoryAxis || this.xAxis
            }
            return this.seriesGroups[b].categoryAxis || this.seriesGroups[b].xAxis || this.categoryAxis || this.xAxis
        },
        _isGreyScale: function(e, b) {
            var d = this.seriesGroups[e];
            var c = d.series[b];
            if (c.greyScale == true) {
                return true
            } else {
                if (c.greyScale == false) {
                    return false
                }
            }
            if (d.greyScale == true) {
                return true
            } else {
                if (d.greyScale == false) {
                    return false
                }
            }
            return this.greyScale == true
        },
        _getSeriesColors: function(f, c, e) {
            var b = this._getSeriesColorsInternal(f, c, e);
            if (this._isGreyScale(f, c)) {
                for (var d in b) {
                    b[d] = a.jqx.toGreyScale(b[d])
                }
            }
            return b
        },
        _getColorFromScheme: function(o, l, b) {
            var d = "#000000";
            var n = this.seriesGroups[o];
            var g = n.series[l];
            if (n.type == "pie" || n.type == "donut") {
                var c = this._getDataLen(o);
                d = this._getItemColorFromScheme(g.colorScheme || n.colorScheme || this.colorScheme, l * c + b, o, l)
            } else {
                var m = 0;
                for (var f = 0; f <= o; f++) {
                    for (var e in this.seriesGroups[f].series) {
                        if (f == o && e == l) {
                            break
                        } else {
                            m++
                        }
                    }
                }
                var k = this.colorScheme;
                if (n.colorScheme) {
                    k = n.colorScheme;
                    sidex = seriesIndex
                }
                if (k == undefined || k == "") {
                    k = this.colorSchemes[0].name
                }
                if (!k) {
                    return d
                }
                for (var f = 0; f < this.colorSchemes.length; f++) {
                    var h = this.colorSchemes[f];
                    if (h.name == k) {
                        while (m > h.colors.length) {
                            m -= h.colors.length;
                            if (++f >= this.colorSchemes.length) {
                                f = 0
                            }
                            h = this.colorSchemes[f]
                        }
                        d = h.colors[m % h.colors.length]
                    }
                }
            }
            return d
        },
        _createColorsCache: function() {
            this._colorsCache = {
                get: function(b) {
                    if (this._store[b]) {
                        return this._store[b]
                    }
                },
                set: function(c, b) {
                    if (this._size < 10000) {
                        this._store[c] = b;
                        this._size++
                    }
                },
                clear: function() {
                    this._store = {};
                    this._size = 0
                },
                _size: 0,
                _store: {}
            }
        },
        _getSeriesColorsInternal: function(m, d, b) {
            var h = m + "_" + d + "_" + (isNaN(b) ? "NaN" : b);
            if (this._colorsCache.get(h)) {
                return this._colorsCache.get(h)
            }
            var f = this.seriesGroups[m];
            var o = f.series[d];
            var c = {
                lineColor: "#222222",
                lineColorSelected: "#151515",
                lineColorSymbol: "#222222",
                lineColorSymbolSelected: "#151515",
                fillColor: "#222222",
                fillColorSelected: "#333333",
                fillColorSymbol: "#222222",
                fillColorSymbolSelected: "#333333",
                fillColorAlt: "#222222",
                fillColorAltSelected: "#333333"
            };
            var i;
            if (a.isFunction(o.colorFunction)) {
                var j = !isNaN(b) ? this._getDataValue(b, o.dataField, m) : NaN;
                if (f.type.indexOf("range") != -1) {
                    var e = this._getDataValue(b, o.dataFieldFrom, m);
                    var l = this._getDataValue(b, o.dataFieldTo, m);
                    j = {
                        from: e,
                        to: l
                    }
                }
                i = o.colorFunction(j, b, o, f);
                if (typeof(i) == "object") {
                    for (var k in i) {
                        c[k] = i[k]
                    }
                } else {
                    c.fillColor = i
                }
            } else {
                for (var k in c) {
                    if (o.key) {
                        c[k] = o[k]
                    }
                }
                if (!o.fillColor && !o.color) {
                    c.fillColor = this._getColorFromScheme(m, d, b)
                } else {
                    o.fillColor = o.fillColor || o.color
                }
            }
            var n = {
                fillColor: {
                    baseColor: "fillColor",
                    adjust: 1
                },
                fillColorSelected: {
                    baseColor: "fillColor",
                    adjust: 1.1
                },
                fillColorSymbol: {
                    baseColor: "fillColor",
                    adjust: 1
                },
                fillColorSymbolSelected: {
                    baseColor: "fillColorSymbol",
                    adjust: 2
                },
                fillColorAlt: {
                    baseColor: "fillColor",
                    adjust: 4
                },
                fillColorAltSelected: {
                    baseColor: "fillColor",
                    adjust: 3
                },
                lineColor: {
                    baseColor: "fillColor",
                    adjust: 0.9
                },
                lineColorSelected: {
                    baseColor: "lineColor",
                    adjust: 0.8
                },
                lineColorSymbol: {
                    baseColor: "lineColor",
                    adjust: 1
                },
                lineColorSymbolSelected: {
                    baseColor: "lineColorSelected",
                    adjust: 1
                }
            };
            for (var k in c) {
                if (typeof(i) != "object" || !i[k]) {
                    if (o[k]) {
                        c[k] = o[k]
                    } else {
                        c[k] = a.jqx.adjustColor(c[n[k].baseColor], n[k].adjust)
                    }
                }
            }
            this._colorsCache.set(h, c);
            return c
        },
        _getItemColorFromScheme: function(d, f, k, h) {
            if (d == undefined || d == "") {
                d = this.colorSchemes[0].name
            }
            for (var g = 0; g < this.colorSchemes.length; g++) {
                if (d == this.colorSchemes[g].name) {
                    break
                }
            }
            var e = 0;
            while (e <= f) {
                if (g == this.colorSchemes.length) {
                    g = 0
                }
                var b = this.colorSchemes[g].colors.length;
                if (e + b <= f) {
                    e += b;
                    g++
                } else {
                    var c = this.colorSchemes[g].colors[f - e];
                    if (this._isGreyScale(k, h) && c.indexOf("#") == 0) {
                        c = a.jqx.toGreyScale(c)
                    }
                    return c
                }
            }
        },
        getColorScheme: function(b) {
            for (var c in this.colorSchemes) {
                if (this.colorSchemes[c].name == b) {
                    return this.colorSchemes[c].colors
                }
            }
            return undefined
        },
        addColorScheme: function(c, b) {
            for (var d in this.colorSchemes) {
                if (this.colorSchemes[d].name == c) {
                    this.colorSchemes[d].colors = b;
                    return
                }
            }
            this.colorSchemes.push({
                name: c,
                colors: b
            })
        },
        removeColorScheme: function(b) {
            for (var c in this.colorSchemes) {
                if (this.colorSchemes[c].name == b) {
                    this.colorSchemes.splice(c, 1);
                    break
                }
            }
        },
        colorSchemes: [{
            name: "scheme01",
            colors: ["#307DD7", "#AA4643", "#89A54E", "#71588F", "#4198AF"]
        }, {
            name: "scheme02",
            colors: ["#7FD13B", "#EA157A", "#FEB80A", "#00ADDC", "#738AC8"]
        }, {
            name: "scheme03",
            colors: ["#E8601A", "#FF9639", "#F5BD6A", "#599994", "#115D6E"]
        }, {
            name: "scheme04",
            colors: ["#D02841", "#FF7C41", "#FFC051", "#5B5F4D", "#364651"]
        }, {
            name: "scheme05",
            colors: ["#25A0DA", "#309B46", "#8EBC00", "#FF7515", "#FFAE00"]
        }, {
            name: "scheme06",
            colors: ["#0A3A4A", "#196674", "#33A6B2", "#9AC836", "#D0E64B"]
        }, {
            name: "scheme07",
            colors: ["#CC6B32", "#FFAB48", "#FFE7AD", "#A7C9AE", "#888A63"]
        }, {
            name: "scheme08",
            colors: ["#3F3943", "#01A2A6", "#29D9C2", "#BDF271", "#FFFFA6"]
        }, {
            name: "scheme09",
            colors: ["#1B2B32", "#37646F", "#A3ABAF", "#E1E7E8", "#B22E2F"]
        }, {
            name: "scheme10",
            colors: ["#5A4B53", "#9C3C58", "#DE2B5B", "#D86A41", "#D2A825"]
        }, {
            name: "scheme11",
            colors: ["#993144", "#FFA257", "#CCA56A", "#ADA072", "#949681"]
        }, {
            name: "scheme12",
            colors: ["#105B63", "#EEEAC5", "#FFD34E", "#DB9E36", "#BD4932"]
        }, {
            name: "scheme13",
            colors: ["#BBEBBC", "#F0EE94", "#F5C465", "#FA7642", "#FF1E54"]
        }, {
            name: "scheme14",
            colors: ["#60573E", "#F2EEAC", "#BFA575", "#A63841", "#BFB8A3"]
        }, {
            name: "scheme15",
            colors: ["#444546", "#FFBB6E", "#F28D00", "#D94F00", "#7F203B"]
        }, {
            name: "scheme16",
            colors: ["#583C39", "#674E49", "#948658", "#F0E99A", "#564E49"]
        }, {
            name: "scheme17",
            colors: ["#142D58", "#447F6E", "#E1B65B", "#C8782A", "#9E3E17"]
        }, {
            name: "scheme18",
            colors: ["#4D2B1F", "#635D61", "#7992A2", "#97BFD5", "#BFDCF5"]
        }, {
            name: "scheme19",
            colors: ["#844341", "#D5CC92", "#BBA146", "#897B26", "#55591C"]
        }, {
            name: "scheme20",
            colors: ["#56626B", "#6C9380", "#C0CA55", "#F07C6C", "#AD5472"]
        }, {
            name: "scheme21",
            colors: ["#96003A", "#FF7347", "#FFBC7B", "#FF4154", "#642223"]
        }, {
            name: "scheme22",
            colors: ["#5D7359", "#E0D697", "#D6AA5C", "#8C5430", "#661C0E"]
        }, {
            name: "scheme23",
            colors: ["#16193B", "#35478C", "#4E7AC7", "#7FB2F0", "#ADD5F7"]
        }, {
            name: "scheme24",
            colors: ["#7B1A25", "#BF5322", "#9DA860", "#CEA457", "#B67818"]
        }, {
            name: "scheme25",
            colors: ["#0081DA", "#3AAFFF", "#99C900", "#FFEB3D", "#309B46"]
        }, {
            name: "scheme26",
            colors: ["#0069A5", "#0098EE", "#7BD2F6", "#FFB800", "#FF6800"]
        }, {
            name: "scheme27",
            colors: ["#FF6800", "#A0A700", "#FF8D00", "#678900", "#0069A5"]
        }],
        _formatValue: function(g, i, c, f, b, d) {
            if (g == undefined) {
                return ""
            }
            if (this._isObject(g) && !c) {
                return ""
            }
            if (c) {
                if (!a.isFunction(c)) {
                    return g.toString()
                }
                try {
                    return c(g, d, b, f)
                } catch (h) {
                    return h.message
                }
            }
            if (this._isNumber(g)) {
                return this._formatNumber(g, i)
            }
            if (this._isDate(g)) {
                return this._formatDate(g, i)
            }
            if (i) {
                return (i.prefix || "") + g.toString() + (i.sufix || "")
            }
            return g.toString()
        },
        _getFormattedValue: function(f, h, z, p, d, l) {
            var w = this.seriesGroups[f];
            var n = w.series[h];
            var m = "";
            var j = p,
                k = d;
            if (!k) {
                k = n.formatFunction || w.formatFunction
            }
            if (!j) {
                j = n.formatSettings || w.formatSettings
            }
            if (!n.formatFunction && n.formatSettings) {
                k = undefined
            }
            var o = {},
                t = 0;
            for (var b in n) {
                if (b.indexOf("dataField") == 0) {
                    o[b.substring(9).toLowerCase()] = this._getDataValue(z, n[b], f);
                    t++
                }
            }
            if (t == 0) {
                o = this._getDataValue(z, undefined, f)
            }
            if (k && a.isFunction(k)) {
                try {
                    return k(t == 1 ? o[""] : o, z, n, w)
                } catch (y) {
                    return y.message
                }
            }
            if (t == 1 && (w.type.indexOf("pie") != -1 || w.type.indexOf("donut") != -1)) {
                return this._formatValue(o[""], j, k, f, h, z)
            }
            if (t > 0) {
                var u = 0;
                for (var b in o) {
                    if (u > 0 && m != "") {
                        m += "<br>"
                    }
                    var r = "dataField" + (b.length > 0 ? b.substring(0, 1).toUpperCase() + b.substring(1) : "");
                    var q = "displayText" + (b.length > 0 ? b.substring(0, 1).toUpperCase() + b.substring(1) : "");
                    var v = n[q] || n[r];
                    var c = o[b];
                    if (undefined != c) {
                        c = this._formatValue(c, j, k, f, h, z)
                    }
                    if (l === true) {
                        m += c
                    } else {
                        m += v + ": " + c
                    }
                    u++
                }
            } else {
                if (undefined != o) {
                    m = this._formatValue(o, j, k, f, h, z)
                }
            }
            return m || ""
        },
        _isNumberAsString: function(d) {
            if (typeof(d) != "string") {
                return false
            }
            d = a.trim(d);
            for (var b = 0; b < d.length; b++) {
                var c = d.charAt(b);
                if ((c >= "0" && c <= "9") || c == "," || c == ".") {
                    continue
                }
                if (c == "-" && b == 0) {
                    continue
                }
                if ((c == "(" && b == 0) || (c == ")" && b == d.length - 1)) {
                    continue
                }
                return false
            }
            return true
        },
        _castAsDate: function(d) {
            if (d instanceof Date && !isNaN(d)) {
                return d
            }
            if (typeof(d) == "string") {
                var c = new Date(d);
                if (!isNaN(c)) {
                    if (d.indexOf(":") == -1) {
                        c.setHours(0, 0, 0, 0)
                    }
                } else {
                    if (a.jqx.dataFormat) {
                        var b = a.jqx.dataFormat.tryparsedate(d);
                        if (b) {
                            c = b
                        } else {
                            c = this._parseISO8601Date(d)
                        }
                    } else {
                        c = this._parseISO8601Date(d)
                    }
                }
                if (c != undefined && !isNaN(c)) {
                    return c
                }
            }
            return undefined
        },
        _parseISO8601Date: function(g) {
            var k = g.split(" ");
            if (k.length < 0) {
                return NaN
            }
            var b = k[0].split("-");
            var c = k.length == 2 ? k[1].split(":") : "";
            var f = b[0];
            var h = b.length > 1 ? b[1] - 1 : 0;
            var i = b.length > 2 ? b[2] : 1;
            var d = c[1];
            var e = c.length > 1 ? c[1] : 0;
            var d = c.length > 2 ? c[2] : 0;
            var j = c.length > 3 ? c[3] : 0;
            return new Date(f, h, i, d, e, j)
        },
        _castAsNumber: function(c) {
            if (c instanceof Date && !isNaN(c)) {
                return c.valueOf()
            }
            if (typeof(c) == "string") {
                if (this._isNumber(c)) {
                    c = parseFloat(c)
                } else {
                    if (!/[a-zA-Z]/.test(c)) {
                        var b = new Date(c);
                        if (b != undefined) {
                            c = b.valueOf()
                        }
                    }
                }
            }
            return c
        },
        _isNumber: function(b) {
            if (typeof(b) == "string") {
                if (this._isNumberAsString(b)) {
                    b = parseFloat(b)
                }
            }
            return typeof b === "number" && isFinite(b)
        },
        _isDate: function(b) {
            return b instanceof Date && !isNaN(b.getDate())
        },
        _isBoolean: function(b) {
            return typeof b === "boolean"
        },
        _isObject: function(b) {
            return (b && (typeof b === "object" || a.isFunction(b))) || false
        },
        _formatDate: function(c, b) {
            return c.toString()
        },
        _formatNumber: function(n, e) {
            if (!this._isNumber(n)) {
                return n
            }
            e = e || {};
            var q = e.decimalSeparator || ".";
            var o = e.thousandsSeparator || "";
            var m = e.prefix || "";
            var p = e.sufix || "";
            var h = e.decimalPlaces;
            if (isNaN(h)) {
                h = ((n * 100 != parseInt(n) * 100) ? 2 : 0)
            }
            var l = e.negativeWithBrackets || false;
            var g = (n < 0);
            if (g && l) {
                n *= -1
            }
            var d = n.toString();
            var b;
            var k = Math.pow(10, h);
            d = (Math.round(n * k) / k).toString();
            if (isNaN(d)) {
                d = ""
            }
            b = d.lastIndexOf(".");
            if (h > 0) {
                if (b < 0) {
                    d += q;
                    b = d.length - 1
                } else {
                    if (q !== ".") {
                        d = d.replace(".", q)
                    }
                }
                while ((d.length - 1 - b) < h) {
                    d += "0"
                }
            }
            b = d.lastIndexOf(q);
            b = (b > -1) ? b : d.length;
            var f = d.substring(b);
            var c = 0;
            for (var j = b; j > 0; j--, c++) {
                if ((c % 3 === 0) && (j !== b) && (!g || (j > 1) || (g && l))) {
                    f = o + f
                }
                f = d.charAt(j - 1) + f
            }
            d = f;
            if (g && l) {
                d = "(" + d + ")"
            }
            return m + d + p
        },
        _defaultNumberFormat: {
            prefix: "",
            sufix: "",
            decimalSeparator: ".",
            thousandsSeparator: ",",
            decimalPlaces: 2,
            negativeWithBrackets: false
        },
        _calculateControlPoints: function(g, f) {
            var e = g[f],
                m = g[f + 1],
                d = g[f + 2],
                j = g[f + 3],
                c = g[f + 4],
                i = g[f + 5];
            var l = 0.4;
            var o = Math.sqrt(Math.pow(d - e, 2) + Math.pow(j - m, 2));
            var b = Math.sqrt(Math.pow(c - d, 2) + Math.pow(i - j, 2));
            var h = (o + b);
            if (h == 0) {
                h = 1
            }
            var n = l * o / h;
            var k = l - n;
            return [d + n * (e - c), j + n * (m - i), d - k * (e - c), j - k * (m - i)]
        },
        _getBezierPoints: function(d) {
            var c = "";
            var h = [],
                e = [];
            var g = d.split(" ");
            for (var f = 0; f < g.length; f++) {
                var j = g[f].split(",");
                h.push(parseFloat(j[0]));
                h.push(parseFloat(j[1]))
            }
            var b = h.length;
            for (var f = 0; f < b - 4; f += 2) {
                e = e.concat(this._calculateControlPoints(h, f))
            }
            for (var f = 2; f < b - 5; f += 2) {
                c += " C" + a.jqx._ptrnd(e[2 * f - 2]) + "," + a.jqx._ptrnd(e[2 * f - 1]) + " " + a.jqx._ptrnd(e[2 * f]) + "," + a.jqx._ptrnd(e[2 * f + 1]) + " " + a.jqx._ptrnd(h[f + 2]) + "," + a.jqx._ptrnd(h[f + 3]) + " "
            }
            if (Math.abs(h[0] - h[2]) < 3 || Math.abs(h[1] - h[3]) < 3) {
                c = "M" + a.jqx._ptrnd(h[0]) + "," + a.jqx._ptrnd(h[1]) + " L" + a.jqx._ptrnd(h[2]) + "," + a.jqx._ptrnd(h[3]) + " " + c
            } else {
                c = "M" + a.jqx._ptrnd(h[0]) + "," + a.jqx._ptrnd(h[1]) + " Q" + a.jqx._ptrnd(e[0]) + "," + a.jqx._ptrnd(e[1]) + " " + a.jqx._ptrnd(h[2]) + "," + a.jqx._ptrnd(h[3]) + " " + c
            }
            if (Math.abs(h[b - 2] - h[b - 4]) < 3 || Math.abs(h[b - 1] - h[b - 3]) < 3) {
                c += " L" + a.jqx._ptrnd(h[b - 2]) + "," + a.jqx._ptrnd(h[b - 1]) + " "
            } else {
                c += " Q" + a.jqx._ptrnd(e[b * 2 - 10]) + "," + a.jqx._ptrnd(e[b * 2 - 9]) + " " + a.jqx._ptrnd(h[b - 2]) + "," + a.jqx._ptrnd(h[b - 1]) + " "
            }
            return c
        },
        _animTickInt: 50,
        _createAnimationGroup: function(b) {
            if (!this._animGroups) {
                this._animGroups = {}
            }
            this._animGroups[b] = {
                animations: [],
                startTick: NaN
            }
        },
        _startAnimation: function(c) {
            var e = new Date();
            var b = e.getTime();
            this._animGroups[c].startTick = b;
            this._runAnimation();
            this._enableAnimTimer()
        },
        _enqueueAnimation: function(e, d, c, g, f, b, h) {
            if (g < 0) {
                g = 0
            }
            if (h == undefined) {
                h = "easeInOutSine"
            }
            this._animGroups[e].animations.push({
                key: d,
                properties: c,
                duration: g,
                fn: f,
                context: b,
                easing: h
            })
        },
        _stopAnimations: function() {
            clearTimeout(this._animtimer);
            this._animtimer = undefined;
            this._animGroups = undefined
        },
        _enableAnimTimer: function() {
            if (!this._animtimer) {
                var b = this;
                this._animtimer = setTimeout(function() {
                    b._runAnimation()
                }, this._animTickInt)
            }
        },
        _runAnimation: function(q) {
            if (this._animGroups) {
                var t = new Date();
                var h = t.getTime();
                var o = {};
                for (var l in this._animGroups) {
                    var s = this._animGroups[l].animations;
                    var m = this._animGroups[l].startTick;
                    var g = 0;
                    for (var n = 0; n < s.length; n++) {
                        var u = s[n];
                        var b = (h - m);
                        if (u.duration > g) {
                            g = u.duration
                        }
                        var r = u.duration > 0 ? b / u.duration : 1;
                        var k = r;
                        if (u.easing && u.duration != 0) {
                            k = a.easing[u.easing](r, b, 0, 1, u.duration)
                        }
                        if (r > 1) {
                            r = 1;
                            k = 1
                        }
                        if (u.fn) {
                            u.fn(u.key, u.context, k);
                            continue
                        }
                        var f = {};
                        for (var l = 0; l < u.properties.length; l++) {
                            var c = u.properties[l];
                            var e = 0;
                            if (r == 1) {
                                e = c.to
                            } else {
                                e = easeParecent * (c.to - c.from) + c.from
                            }
                            f[c.key] = e
                        }
                        this.renderer.attr(u.key, f)
                    }
                    if (m + g > h) {
                        o[l] = ({
                            startTick: m,
                            animations: s
                        })
                    }
                }
                this._animGroups = o;
                if (this.renderer instanceof a.jqx.HTML5Renderer) {
                    this.renderer.refresh()
                }
            }
            this._animtimer = null;
            for (var l in this._animGroups) {
                this._enableAnimTimer();
                break
            }
        }
    })
})(jqxBaseFramework);