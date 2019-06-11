using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VoyagerYBusiness;

namespace VoyagerYMVC.Areas.Management.ViewModels
{
    public class BusVM
    {
        public Bus Bus { get; set; }
        public IEnumerable<BusType> TypeList{ get; set; }
    }
}