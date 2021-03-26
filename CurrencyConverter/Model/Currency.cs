using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CurrencyConverter.Model
{
    public class Currency
    {
        [Key]
        public int timestamp { get; set; }
        public string @base { get; set; }
        public string date { get; set; }

        [NotMapped]
        public Rates Rates { get; set; }
    }    
}
