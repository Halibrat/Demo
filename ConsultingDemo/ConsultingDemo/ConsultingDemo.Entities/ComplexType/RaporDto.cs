using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingDemo.Entities.ComplexType
{
    public class RaporDto
    {
        public int SiraNo { get; set; } 
        public string IslemTur { get; set; } 
        public string EvrakNo { get; set; } 
        public DateTime Tarih { get; set; } 
        public decimal GirisMiktar { get; set; }
        public decimal CikisMiktar { get; set; }
        public string StokMiktar { get; set; }
    }
}
