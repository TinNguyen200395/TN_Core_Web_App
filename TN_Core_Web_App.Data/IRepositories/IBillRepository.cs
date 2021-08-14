using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_Core_Web_App.Data.Entities;
using TN_Core_Web_App.Infrastructure.Interfaces;

namespace TN_Core_Web_App.Data.IRepositories
{
    public interface IBillRepository: IRepository<Bill, int>
    {
    }
}
