using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SortingProject.Models
{
    public class Numbers
    {
        public int Value { get; set; }
        public bool Changed { get; set; }
        public string barColor
        {
            get
            {
                if(Changed)
                {
                    return "red";
                }
                return "black";
            }
        }
        public string textColor
        {
            get
            {
                if (Changed)
                {
                    return "black";
                }
                return "white";
            }
        }
    }
}