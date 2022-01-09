using ConsultingDemo.Entities.Concrete;
using Core.Utilities.Resluts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingDemo.Business.Abstract
{
   public interface ISTKService
    {
        IResult Add(STK sTK);
        IResult Delete(STK sTK);
        IResult Update(STK sTK);
        IDataResult<List<STK>> GetAll();
        IDataResult<List<STK>> GetById(int id);
        IDataResult<List<STK>> GetGoodsByNameOrCode(string text);
    }
}
