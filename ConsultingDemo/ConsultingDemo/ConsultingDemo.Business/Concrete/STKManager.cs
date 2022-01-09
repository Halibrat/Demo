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
    public class STKManager : ISTKService
    {
        private ISTKDal _sTKDal;
        public STKManager(ISTKDal sTKDal)
        {
            _sTKDal = sTKDal;
        }
        public IResult Add(STK sTK)
        {
            _sTKDal.Add(sTK);
            return new SuccessResult();
        }

        public IResult Delete(STK sTK)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<STK>> GetAll()
        {
            return new SuccessDataResult<List<STK>>(_sTKDal.GetAll());
        }

        public IDataResult<List<STK>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<STK>> GetGoodsByNameOrCode(string text)
        {
            return new SuccessDataResult<List<STK>>(_sTKDal.GetAll(p => p.MalKodu.ToLower().Contains(text.ToLower()) || p.MalAdi.Contains(text.ToLower())));
        }

        public IResult Update(STK sTK)
        {
            throw new NotImplementedException();
        }
    }
}
