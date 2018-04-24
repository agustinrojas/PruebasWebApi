using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebasWebApi.Common.Logic;
using PruebasWebApi.DataAcces.Dao.Interfaces;

namespace PruebasWebApi.Buseniess.Logc
{
    public class UserBL : IUserBL
    {
     

        private readonly IDao _idao =null;

       public UserBL(IDao idao)
       {
            this._idao = idao;
            
       }

        public User Get()
        {
            return this._idao.Get();
        }

        public User Set(User user)
        {
            return this._idao.Set(user);
        }
    }
}
