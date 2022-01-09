
using ConsultingDemo.DataAccess.Abstract;
using ConsultingDemo.Entities.ComplexType;
using ConsultingDemo.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingDemo.DataAccess.Concrete.EntityFramework
{
    public class EfSTIDal : EfEntityRepositoryBase<STI, TestContext>, ISTIDal
    {

        public List<RaporDto> GetListGroupBy(string Malkodu, int Baslangictarihi, int BitisTarihi)
        {
            using (TestContext context = new TestContext())
            {
                //return context.Database.
                 List <RaporDto> rr = new List<RaporDto>();

                return rr;
            }
        }

    }
}
