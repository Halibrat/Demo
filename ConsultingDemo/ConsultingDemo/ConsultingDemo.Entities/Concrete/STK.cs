using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingDemo.Entities.Concrete
{
    public class STK:IEntity
    {
        public int ID { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
    }
}
