using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biolink_Api.Models
{
    public class t_ad_column
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int seq { get; set; }
        public string adcolumnm { get; set; }
    }
}