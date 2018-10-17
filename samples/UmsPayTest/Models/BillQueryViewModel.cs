using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UmsPayTest.Models
{
    public class BillQueryViewModel
    {
        [Required]
        public string billNo { get; set; }

        public string billDate { get; set; }

        public string requestTimestamp { get; set; }
    }
}
