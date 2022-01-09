using ConsultingDemo.Entities.Concrete;
using Core.Utilities.Resluts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingDemo.Business.Abstract
{
   public interface ISTIService
    {
        IResult Add(STI sTI);
        IResult Delete(STI sTI);
        IResult Update(STI sTI);
        IDataResult<List<STI>> GetAll();
        IDataResult<List<STI>> GetById(int id);
        IDataResult<List<STI>> GetGoodsByName(string text);
    }
}
