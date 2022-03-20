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
    public class PortfolioManager:IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            this._portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public Portfolio TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Portfolio> TGetList()
        {
           return _portfolioDal.GetList();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void TUpdate(Portfolio t)
        {
            throw new NotImplementedException();
        }
    }
}
