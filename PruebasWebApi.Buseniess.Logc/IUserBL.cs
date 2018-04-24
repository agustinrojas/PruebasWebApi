using PruebasWebApi.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasWebApi.Buseniess.Logc
{
    public interface IUserBL
    {
        User Set(User user);
        User Get();


    }
}
