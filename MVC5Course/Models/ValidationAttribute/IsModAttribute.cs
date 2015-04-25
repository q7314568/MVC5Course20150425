using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models.ValidationAttribute
{
    public class IsModAttribute : DataTypeAttribute
    {
        public IsModAttribute():base("IsMod")
        {

        }
        public override bool IsValid(object value)
        {
            int i = Int32.Parse(value.ToString());
            if (i % 2 == 0)
                return true;
            else
                return false;
        }
    }
}