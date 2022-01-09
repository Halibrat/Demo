using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingDemo.Entities.Concrete
{
   public class STI:IEntity
    {
        public int ID { get; set; }
        public short IslemTur { get; set; }
        public string EvrakNo { get; set; }
        public int Tarih { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string MalKodu { get; set; }
        public decimal Miktar { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Tutar { get; set; }
        public string Birim { get; set; }
    }
}
