using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_Core_Web_App.Data.Enums
{
    public enum PaymentMethod
    {
        [Description("Cash on delivery")]
        CashOnDelivery,
        [Description("Online Banking")]

        OnlinBanking,
        [Description("Payment Gateway")]

        PaymentGateway,
        [Description("Visa")]

        Visa,
        [Description("MasterCard")]

        MasterCard,
        [Description("PayPal")]

        PayPal,
        [Description("Atm")]

        Atm
    }
}
