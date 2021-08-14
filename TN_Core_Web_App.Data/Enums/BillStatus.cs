using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_Core_Web_App.Data.Enums
{
    public enum BillStatus
    {
        [Description("New bill")]

        New,
        [Description("InProgress")]

        InProgress,
        [Description("Returned")]

        Returned,
        [Description("Cancelled")]

        Cancelled,
        [Description("Completed")]

        Completed
    }
}
