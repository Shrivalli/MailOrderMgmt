using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class RefillOrderLineItem
    {
        [Key]
        public int Policy_ID { get; set; }
        public int Member_ID { get; set; }
        public int Subscription_ID { get; set; }
        public string Location { get; set; }
    }
}
