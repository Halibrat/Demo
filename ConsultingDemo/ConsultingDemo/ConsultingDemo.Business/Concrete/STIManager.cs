using ConsultingDemo.Business.Abstract;
using ConsultingDemo.DataAccess.Abstract;
using ConsultingDemo.Entities.Concrete;
using Core.Utilities.Resluts;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingDemo.Business.Concrete
{
    public class STIManager : ISTIService
    {
       private ISTIDal _sTIDal;

        

        public STIManager(ISTIDal sTIDal)
        {
            _sTIDal = sTIDal;
        }
        public IResult Add(STI sTI)
        {
            _sTIDal.Add(sTI);
            return new SuccessResult();
        }

        public IResult Delete(STI sTI)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<STI>> GetAll()
        {
            return new SuccessDataResult<List<STI>>(_sTIDal.GetAll());
        }

        public IDataResult<List<STI>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<STI>> GetGoodsByName(string text)
        {
            return new SuccessDataResult<List<STI>>( _sTIDal.GetAll(p => p.MalKodu.ToLower().Contains(text.ToLower())));
        }

        public IResult Update(STI sTI)
        {
            throw new NotImplementedException();
        }
    }
}
