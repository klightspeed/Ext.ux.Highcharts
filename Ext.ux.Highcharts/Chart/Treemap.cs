
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Serialization;
using Ext.Net;
using Ext.Net.Utilities;
using Newtonsoft.Json;

namespace Ext.ux.Highcharts.Chart
{
        


        /// <summary>
        /// A treemap series. If the .type">type option is not specified, it is inherited from chart.type.For options that apply to multiple series, it is recommended to add them to the pointOptions.series options structure. To apply to all series of this specific type, apply it to plotOptions.treemap.
        /// </summary>
        public partial class Treemap : Observable
        {

    
            /// <summary>
            /// When enabled the user can click on a point which is a parent and zoom in on its children.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When enabled the user can click on a point which is a parent and zoom in on its children.")]
            public bool? AllowDrillToNode
            {
                get
                {
                    return this.State.Get<bool?>("AllowDrillToNode", false);
                }
                set
                {
                    this.State.Set("AllowDrillToNode", value);
                }
            }

            /// <summary>
            /// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Allow this series' points to be selected by clicking on the markers, bars or pie slices.")]
            public bool? AllowPointSelect
            {
                get
                {
                    return this.State.Get<bool?>("AllowPointSelect", false);
                }
                set
                {
                    this.State.Set("AllowPointSelect", value);
                }
            }

            /// <summary>
            /// Enabling this option will make the treemap alternate the drawing direction between vertical and horizontal.The next levels starting direction will always be the opposite of the previous.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enabling this option will make the treemap alternate the drawing direction between vertical and horizontal.The next levels starting direction will always be the opposite of the previous.")]
            public bool? AlternateStartingDirection
            {
                get
                {
                    return this.State.Get<bool?>("AlternateStartingDirection", false);
                }
                set
                {
                    this.State.Set("AlternateStartingDirection", value);
                }
            }

            /// <summary>
            /// Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see chart.animation and the animation parameter under the API methods.		The following properties are supported:  duration  The duration of the animation in milliseconds.easingWhen using jQuery as the general framework, the easing can be set to linear or	swing. More easing functions are available with the use of jQuery plug-ins, most notably				the jQuery UI suite. See the jQuery docs. When using MooTools as the general framework, use the property name transition instead of easing.Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see chart.animation and the animation parameter under the API methods.		The following properties are supported:  duration  The duration of the animation in milliseconds.easingWhen using jQuery as the general framework, the easing can be set to linear or	swing. More easing functions are available with the use of jQuery plug-ins, most notably				the jQuery UI suite. See the jQuery docs. When using MooTools as the general framework, use the property name transition instead of easing.Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.")]
            public bool? Animation
            {
                get
                {
                    return this.State.Get<bool?>("Animation", true);
                }
                set
                {
                    this.State.Set("Animation", value);
                }
            }

            /// <summary>
            /// The color of the border surrounding each tree map item.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#E0E0E0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the border surrounding each tree map item.")]
            public string BorderColor
            {
                get
                {
                    return this.State.Get<string>("BorderColor", @"#E0E0E0");
                }
                set
                {
                    this.State.Set("BorderColor", value);
                }
            }

            /// <summary>
            /// The width of the border surrounding each column or bar.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the border surrounding each column or bar.")]
            public double? BorderWidth
            {
                get
                {
                    return this.State.Get<double?>("BorderWidth", 1);
                }
                set
                {
                    this.State.Set("BorderWidth", value);
                }
            }

            /// <summary>
            /// The main color of the series. In heat maps this color is rarely used, as we mostly use the color to denote the value of each point. Unless options are set in the colorAxis, the default value is pulled from the options.colors array.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The main color of the series. In heat maps this color is rarely used, as we mostly use the color to denote the value of each point. Unless options are set in the colorAxis, the default value is pulled from the options.colors array.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", @"null");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// When using automatic point colors pulled from the options.colors collection, this option determines whether the chart should receive  one color per series or one color per point.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When using automatic point colors pulled from the options.colors collection, this option determines whether the chart should receive  one color per series or one color per point.")]
            public bool? ColorByPoint
            {
                get
                {
                    return this.State.Get<bool?>("ColorByPoint", false);
                }
                set
                {
                    this.State.Set("ColorByPoint", value);
                }
            }

            /// <summary>
            /// A series specific or series type specific color set to apply instead of the global colors when colorByPoint is true.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A series specific or series type specific color set to apply instead of the global colors when colorByPoint is true.")]
            public string[] Colors
            {
                get
                {
                    return this.State.Get<string[]>("Colors", null);
                }
                set
                {
                    this.State.Set("Colors", value);
                }
            }

            /// <summary>
            /// When the series contains less points than the crop threshold, all points are drawn, event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(300)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When the series contains less points than the crop threshold, all points are drawn, event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.")]
            public double? CropThreshold
            {
                get
                {
                    return this.State.Get<double?>("CropThreshold", 300);
                }
                set
                {
                    this.State.Set("CropThreshold", value);
                }
            }

            /// <summary>
            /// You can set the cursor to ""pointer"" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"You can set the cursor to ""pointer"" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.")]
            public string Cursor
            {
                get
                {
                    return this.State.Get<string>("Cursor", "");
                }
                set
                {
                    this.State.Set("Cursor", value);
                }
            }

            /// <summary>
            /// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.")]
            public bool? EnableMouseTracking
            {
                get
                {
                    return this.State.Get<bool?>("EnableMouseTracking", true);
                }
                set
                {
                    this.State.Set("EnableMouseTracking", value);
                }
            }

            /// <summary>
            /// Whether to use the Y extremes of the total chart width or only the zoomed area when zooming in on parts of the X axis. By default, the Y axis adjusts to the min and max of the visible data. Cartesian series only.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to use the Y extremes of the total chart width or only the zoomed area when zooming in on parts of the X axis. By default, the Y axis adjusts to the min and max of the visible data. Cartesian series only.")]
            public bool? GetExtremesFromAll
            {
                get
                {
                    return this.State.Get<bool?>("GetExtremesFromAll", false);
                }
                set
                {
                    this.State.Set("GetExtremesFromAll", value);
                }
            }

            /// <summary>
            /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get().
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An id for the series. This can be used after render time to get a pointer to the series object through chart.get().")]
            public string Id
            {
                get
                {
                    return this.State.Get<string>("Id", "");
                }
                set
                {
                    this.State.Set("Id", value);
                }
            }

            /// <summary>
            /// The index of the series in the chart, affecting the internal index in the chart.series array, the visible Z index as well as the order in the legend.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The index of the series in the chart, affecting the internal index in the chart.series array, the visible Z index as well as the order in the legend.")]
            public double? Index
            {
                get
                {
                    return this.State.Get<double?>("Index", null);
                }
                set
                {
                    this.State.Set("Index", value);
                }
            }

            /// <summary>
            /// This option decides if the user can interact with the parent nodes or just the leaf nodes. When this option is undefined, it will be true by default. However when allowDrillToNode is true, then it will be false by default.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"This option decides if the user can interact with the parent nodes or just the leaf nodes. When this option is undefined, it will be true by default. However when allowDrillToNode is true, then it will be false by default.")]
            public bool? InteractByLeaf
            {
                get
                {
                    return this.State.Get<bool?>("InteractByLeaf", null);
                }
                set
                {
                    this.State.Set("InteractByLeaf", value);
                }
            }

            /// <summary>
            /// An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.")]
            public string[] Keys
            {
                get
                {
                    return this.State.Get<string[]>("Keys", null);
                }
                set
                {
                    this.State.Set("Keys", value);
                }
            }

            /// <summary>
            /// This option decides which algorithm is used for setting position and dimensions of the points. Can be one of sliceAndDice, stripes, squarified or strip. 
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"sliceAndDice")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"This option decides which algorithm is used for setting position and dimensions of the points. Can be one of sliceAndDice, stripes, squarified or strip. ")]
            public string LayoutAlgorithm
            {
                get
                {
                    return this.State.Get<string>("LayoutAlgorithm", @"sliceAndDice");
                }
                set
                {
                    this.State.Set("LayoutAlgorithm", value);
                }
            }

            /// <summary>
            /// Defines which direction the layout algorithm will start drawing. Possible values are ""vertical"" and ""horizontal"".
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"vertical")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Defines which direction the layout algorithm will start drawing. Possible values are ""vertical"" and ""horizontal"".")]
            public string LayoutStartingDirection
            {
                get
                {
                    return this.State.Get<string>("LayoutStartingDirection", @"vertical");
                }
                set
                {
                    this.State.Set("LayoutStartingDirection", value);
                }
            }

            /// <summary>
            /// The sequential index of the series in the legend.  Try it:  	Legend in opposite order .
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The sequential index of the series in the legend.  Try it:  	Legend in opposite order .")]
            public double? LegendIndex
            {
                get
                {
                    return this.State.Get<double?>("LegendIndex", null);
                }
                set
                {
                    this.State.Set("LegendIndex", value);
                }
            }

            /// <summary>
            /// Used together with the levels and allowDrillToNode options. When set to false the first level visible when drilling is considered to be level one. Otherwise the level will be the same as the tree structure.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Used together with the levels and allowDrillToNode options. When set to false the first level visible when drilling is considered to be level one. Otherwise the level will be the same as the tree structure.")]
            public bool? LevelIsConstant
            {
                get
                {
                    return this.State.Get<bool?>("LevelIsConstant", true);
                }
                set
                {
                    this.State.Set("LevelIsConstant", value);
                }
            }

            /// <summary>
            /// The id of another series to link to. Additionally, the value can be "":previous"" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The id of another series to link to. Additionally, the value can be "":previous"" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.")]
            public string LinkedTo
            {
                get
                {
                    return this.State.Get<string>("LinkedTo", "");
                }
                set
                {
                    this.State.Set("LinkedTo", value);
                }
            }

            /// <summary>
            /// The maximum allowed pixel width for a column, translated to the height of a bar in a bar chart. This prevents the columns from becoming too wide when there is a small number of points in the chart.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The maximum allowed pixel width for a column, translated to the height of a bar in a bar chart. This prevents the columns from becoming too wide when there is a small number of points in the chart.")]
            public double? MaxPointWidth
            {
                get
                {
                    return this.State.Get<double?>("MaxPointWidth", null);
                }
                set
                {
                    this.State.Set("MaxPointWidth", value);
                }
            }

            /// <summary>
            /// The name of the series as shown in the legend, tooltip etc.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The name of the series as shown in the legend, tooltip etc.")]
            public string Name
            {
                get
                {
                    return this.State.Get<string>("Name", "");
                }
                set
                {
                    this.State.Set("Name", value);
                }
            }

            /// <summary>
            /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series.")]
            public bool? Selected
            {
                get
                {
                    return this.State.Get<bool?>("Selected", false);
                }
                set
                {
                    this.State.Set("Selected", value);
                }
            }

            /// <summary>
            /// Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.")]
            public object Shadow
            {
                get
                {
                    return this.State.Get<object>("Shadow", null);
                }
                set
                {
                    this.State.Set("Shadow", value);
                }
            }

            /// <summary>
            /// If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the selected option.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the selected option.")]
            public bool? ShowCheckbox
            {
                get
                {
                    return this.State.Get<bool?>("ShowCheckbox", false);
                }
                set
                {
                    this.State.Set("ShowCheckbox", value);
                }
            }

            /// <summary>
            /// Whether to display this series type or specific series item in the legend.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to display this series type or specific series item in the legend.")]
            public bool? ShowInLegend
            {
                get
                {
                    return this.State.Get<bool?>("ShowInLegend", false);
                }
                set
                {
                    this.State.Set("ShowInLegend", value);
                }
            }

            /// <summary>
            /// Sticky tracking of mouse events. When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When stickyTracking is false and tooltip.shared is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Sticky tracking of mouse events. When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When stickyTracking is false and tooltip.shared is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.")]
            public bool? StickyTracking
            {
                get
                {
                    return this.State.Get<bool?>("StickyTracking", true);
                }
                set
                {
                    this.State.Set("StickyTracking", value);
                }
            }

            /// <summary>
            /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to 0 disable.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1000)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to 0 disable.")]
            public double? TurboThreshold
            {
                get
                {
                    return this.State.Get<double?>("TurboThreshold", 1000);
                }
                set
                {
                    this.State.Set("TurboThreshold", value);
                }
            }

            /// <summary>
            /// The type of series. Can be one of area, areaspline, bar, column, line, pie, scatter or spline. From version 2.3, arearange, areasplinerange and columnrange are supported with the highcharts-more.js component.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The type of series. Can be one of area, areaspline, bar, column, line, pie, scatter or spline. From version 2.3, arearange, areasplinerange and columnrange are supported with the highcharts-more.js component.")]
            public string Type
            {
                get
                {
                    return this.State.Get<string>("Type", "");
                }
                set
                {
                    this.State.Set("Type", value);
                }
            }

            /// <summary>
            /// Set the initial visibility of the series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Set the initial visibility of the series.")]
            public bool? Visible
            {
                get
                {
                    return this.State.Get<bool?>("Visible", true);
                }
                set
                {
                    this.State.Set("Visible", value);
                }
            }

            /// <summary>
            /// When using dual or multiple x axes, this number defines which xAxis the particular series is connected to. It refers to either the axis id or the index of the axis in the xAxis array, with 0 being the first.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When using dual or multiple x axes, this number defines which xAxis the particular series is connected to. It refers to either the axis id or the index of the axis in the xAxis array, with 0 being the first.")]
            public object XAxis
            {
                get
                {
                    return this.State.Get<object>("XAxis", null);
                }
                set
                {
                    this.State.Set("XAxis", value);
                }
            }

            /// <summary>
            /// When using dual or multiple y axes, this number defines which yAxis the particular series is connected to. It refers to either the axis id or the index of the axis in the yAxis array, with 0 being the first.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When using dual or multiple y axes, this number defines which yAxis the particular series is connected to. It refers to either the axis id or the index of the axis in the yAxis array, with 0 being the first.")]
            public object YAxis
            {
                get
                {
                    return this.State.Get<object>("YAxis", null);
                }
                set
                {
                    this.State.Set("YAxis", value);
                }
            }

            /// <summary>
            /// Define the visual z index of the series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Define the visual z index of the series.")]
            public double? ZIndex
            {
                get
                {
                    return this.State.Get<double?>("ZIndex", null);
                }
                set
                {
                    this.State.Set("ZIndex", value);
                }
            }

            /// <summary>
            /// Defines the Axis on which the zones are applied.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"y")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Defines the Axis on which the zones are applied.")]
            public string ZoneAxis
            {
                get
                {
                    return this.State.Get<string>("ZoneAxis", @"y");
                }
                set
                {
                    this.State.Set("ZoneAxis", value);
                }
            }


    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                list.Add("allowDrillToNode", new ConfigOption("allowDrillToNode", null, false, this.AllowDrillToNode));

                list.Add("allowPointSelect", new ConfigOption("allowPointSelect", null, false, this.AllowPointSelect));

                list.Add("alternateStartingDirection", new ConfigOption("alternateStartingDirection", null, false, this.AlternateStartingDirection));

                list.Add("animation", new ConfigOption("animation", null, true, this.Animation));

                list.Add("borderColor", new ConfigOption("borderColor", null, @"#E0E0E0", this.BorderColor));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 1, this.BorderWidth));

                list.Add("color", new ConfigOption("color", null, @"null", this.Color));

                list.Add("colorByPoint", new ConfigOption("colorByPoint", null, false, this.ColorByPoint));

                list.Add("colors", new ConfigOption("colors", null, null, this.Colors));

                list.Add("cropThreshold", new ConfigOption("cropThreshold", null, 300, this.CropThreshold));

                list.Add("cursor", new ConfigOption("cursor", null, "", this.Cursor));

                list.Add("enableMouseTracking", new ConfigOption("enableMouseTracking", null, true, this.EnableMouseTracking));

                list.Add("getExtremesFromAll", new ConfigOption("getExtremesFromAll", null, false, this.GetExtremesFromAll));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("index", new ConfigOption("index", null, null, this.Index));

                list.Add("interactByLeaf", new ConfigOption("interactByLeaf", null, null, this.InteractByLeaf));

                list.Add("keys", new ConfigOption("keys", null, null, this.Keys));

                list.Add("layoutAlgorithm", new ConfigOption("layoutAlgorithm", null, @"sliceAndDice", this.LayoutAlgorithm));

                list.Add("layoutStartingDirection", new ConfigOption("layoutStartingDirection", null, @"vertical", this.LayoutStartingDirection));

                list.Add("legendIndex", new ConfigOption("legendIndex", null, null, this.LegendIndex));

                list.Add("levelIsConstant", new ConfigOption("levelIsConstant", null, true, this.LevelIsConstant));

                list.Add("linkedTo", new ConfigOption("linkedTo", null, "", this.LinkedTo));

                list.Add("maxPointWidth", new ConfigOption("maxPointWidth", null, null, this.MaxPointWidth));

                list.Add("name", new ConfigOption("name", null, "", this.Name));

                list.Add("selected", new ConfigOption("selected", null, false, this.Selected));

                list.Add("shadow", new ConfigOption("shadow", null, null, this.Shadow));

                list.Add("showCheckbox", new ConfigOption("showCheckbox", null, false, this.ShowCheckbox));

                list.Add("showInLegend", new ConfigOption("showInLegend", null, false, this.ShowInLegend));

                list.Add("stickyTracking", new ConfigOption("stickyTracking", null, true, this.StickyTracking));

                list.Add("turboThreshold", new ConfigOption("turboThreshold", null, 1000, this.TurboThreshold));

                list.Add("type", new ConfigOption("type", null, "", this.Type));

                list.Add("visible", new ConfigOption("visible", null, true, this.Visible));

                list.Add("xAxis", new ConfigOption("xAxis", null, null, this.XAxis));

                list.Add("yAxis", new ConfigOption("yAxis", null, null, this.YAxis));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                list.Add("zoneAxis", new ConfigOption("zoneAxis", null, @"y", this.ZoneAxis));

                return list;
            }
        }


    

        /// <summary>
        /// An array of data points for the series. For the treemap series type, points can be given in the following ways:  	An array of numerical values. In this case, the numerical values will  	be interpreted as value options.  Example:data: [0, 5, 3, 5] 	 An array of objects with named values. The objects are 	point configuration objects as seen below. If the total number of data points exceeds the series' .turboThreshold'>turboThreshold, this option is not available.data: [{    value: 7,    name: "Point2",    color: "#00FF00"}, {    value: 2,    name: "Point1",    color: "#FF00FF"}] 
        /// </summary>
        public partial class Data : Observable
        {

    

    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                return list;
            }
        }


    

        }


        /// <summary>
        /// 
        /// </summary>
        public partial class DataLabels : Observable
        {

    

    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                return list;
            }
        }


    

        }


        /// <summary>
        /// 
        /// </summary>
        public partial class Events : Observable
        {

    

    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                return list;
            }
        }


    

        }


        /// <summary>
        /// Set options on specific levels. Takes precedence over series options, but not point options.
        /// </summary>
        public partial class Levels : Observable
        {

    

    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                return list;
            }
        }


    

        }


        /// <summary>
        /// Properties for each single point
        /// </summary>
        public partial class Point : Observable
        {

    

    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                return list;
            }
        }


    

        }


        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public partial class States : Observable
        {

    

    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                return list;
            }
        }


    

        }


        /// <summary>
        /// 
        /// </summary>
        public partial class Tooltip : Observable
        {

    

    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                return list;
            }
        }


    

        }


        /// <summary>
        /// An array defining zones within a series. Zones can be applied to the X axis, Y axis or Z axis for bubbles, according to the zoneAxis option.
        /// </summary>
        public partial class Zones : Observable
        {

    

    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                return list;
            }
        }


    

        }


        }

        
}
            