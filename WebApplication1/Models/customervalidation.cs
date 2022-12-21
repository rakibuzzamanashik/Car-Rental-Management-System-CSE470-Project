using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public partial class customer
    {
        [MetadataType(typeof(customerMetaData))]
        public class customerMetaData
        {

            [DisplayName("Customer Name")]
            public string Name { get; set; }
            [DisplayName("Mobile")]
            public Nullable<int> Mobile { get; set; }
            [DisplayName("Address")]
            public string Address { get; set; }
        }
        
    }
}