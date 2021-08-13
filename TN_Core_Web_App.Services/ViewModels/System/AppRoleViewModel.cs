using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_Core_Web_App.Services.ViewModels.System
{
    public class AppRoleViewModel
    {
        public Guid? Id { set; get; }
        public string Name { set; get; }

        public string Description { set; get; }
    }
}
