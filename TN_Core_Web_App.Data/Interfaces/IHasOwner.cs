﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TN_Core_Web_App.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }


    }
}
