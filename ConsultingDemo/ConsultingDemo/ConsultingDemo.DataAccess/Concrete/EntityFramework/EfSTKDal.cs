using ConsultingDemo.DataAccess.Abstract;
using ConsultingDemo.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingDemo.DataAccess.Concrete.EntityFramework
{
   public class EfSTKDal:EfEntityRepositoryBase<STK,TestContext>,ISTKDal
    {
    }
}
