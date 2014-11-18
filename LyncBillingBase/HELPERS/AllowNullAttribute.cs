﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyncBillingBase.Helpers
{
    /// <summary>
    /// This attribute tells the Repository that it's associated property resembles a Database Column that is allowed to be set to NULL in the corresponding table.
    /// </summary>
    
    [System.AttributeUsage(System.AttributeTargets.Property)]
    class AllowNullAttribute : Attribute
    {
        public bool Status { private set; public get; }

        public AllowNullAttribute(bool status = true)
        {
            this.Status = status;
        }
    }
}
