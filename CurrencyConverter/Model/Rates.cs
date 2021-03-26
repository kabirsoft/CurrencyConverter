using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CurrencyConverter.Model
{
    public class Rates
    {
        [Key]
        public int timestamp { get; set; }

        [Column(TypeName = "decimal(18, 6)")]
        public decimal AED { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal AFN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ALL { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal AMD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ANG { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal AOA { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ARS { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal AUD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal AWG { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal AZN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BAM { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BBD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BDT { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BGN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BHD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BIF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BMD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BND { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BOB { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BRL { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BSD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BTC { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BTN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BWP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BYN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BYR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal BZD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CAD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CDF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CHF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CLF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CLP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CNY { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal COP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CRC { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CUC { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CUP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CVE { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal CZK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal DJF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal DKK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal DOP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal DZD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal EGP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ERN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ETB { get; set; }        
        public int EUR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal FJD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal FKP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal GBP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal GEL { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal GGP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal GHS { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal GIP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal GMD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal GNF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal GTQ { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal GYD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal HKD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal HNL { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal HRK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal HTG { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal HUF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal IDR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ILS { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal IMP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal INR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal IQD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal IRR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ISK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal JEP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal JMD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal JOD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal JPY { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal KES { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal KGS { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal KHR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal KMF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal KPW { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal KRW { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal KWD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal KYD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal KZT { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LAK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LBP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LKR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LRD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LSL { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LTL { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LVL { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LYD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MAD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MDL { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MGA { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MKD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MMK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MNT { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MOP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MRO { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MUR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MVR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MWK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MXN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MYR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal MZN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal NAD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal NGN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal NIO { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal NOK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal NPR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal NZD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal OMR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal PAB { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal PEN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal PGK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal PHP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal PKR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal PLN { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal PYG { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal QAR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal RON { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal RSD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal RUB { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal RWF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SAR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SBD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SCR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SDG { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SEK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SGD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SHP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SLL { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SOS { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SRD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal STD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SVC { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SYP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal SZL { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal THB { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TJS { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TMT { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TND { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TOP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TRY { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TTD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TWD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TZS { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal UAH { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal UGX { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal USD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal UYU { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal UZS { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal VEF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal VND { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal VUV { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal WST { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal XAF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal XAG { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal XAU { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal XCD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal XDR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal XOF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal XPF { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal YER { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ZAR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal ZMK { get; set; }

        [Column(TypeName = "decimal(18, 6)")]
        public decimal ZMW { get; set; }

        [Column(TypeName = "decimal(18, 6)")]
        public decimal ZWL { get; set; }
    }
}
