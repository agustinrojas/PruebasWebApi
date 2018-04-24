using PruebasWebApi.Buseniess.Logc;
using PruebasWebApi.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebasWebApi.Business.Facade.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserBL _iuserBL = null;

        public UserController(IUserBL iuserBL)
        {
            _iuserBL = iuserBL;
        }

        /// <summary>
        /// Muestras un usuario con Get.
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public IHttpActionResult Get()
        {
            return Ok(_iuserBL.Get());
        }

        /// <summary>
        /// Introduces un usuario y lo guardas en redis.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost()]
        public IHttpActionResult Set(User user)
        {
            
            return Ok(_iuserBL.Set(user));
        }



    }
}
