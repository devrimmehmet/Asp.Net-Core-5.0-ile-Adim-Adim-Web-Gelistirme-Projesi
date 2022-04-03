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
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }

        public List<Skill> GetList()
        {
            return _skillDal.GetList();
        }

        public Skill TGetByID(int id)
        {
            return _skillDal.GetByID(id);
        }

       
    }
}
