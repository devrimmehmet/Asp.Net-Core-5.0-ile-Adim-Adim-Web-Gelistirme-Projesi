using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager:ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal) 
        {
        _skillDal = skillDal;
        }
        public void TAdd(Skill t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Skill t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public Skill TGetByID(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
