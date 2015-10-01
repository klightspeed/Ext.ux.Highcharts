﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ext.Net;

namespace Ext.ux.Highcharts
{
    public abstract partial class ColumnSerieBase : Serie
    {
        [ConfigOption]
        [DefaultValue("column")]
        [NotifyParentProperty(true)]
        [Description("Highcharts series type name. This field must be specified. Line, area, scatter and column series are the simplest form of charts (includes Polar) which has the simple data mappings: dataIndex or yField for y-axis values and xField for either x-axis category field or data point's x-axis coordinate.")]
        public virtual string Type
        {
            get
            {
                object obj = this.ViewState["Type"];
                return obj != null ? (string)obj : "column";
            }
            set
            {
                this.ViewState["Type"] = value;
            }
        }

    }
}
