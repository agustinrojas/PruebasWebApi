using Newtonsoft.Json;
using PruebasWebApi.Common.Logic;
using PruebasWebApi.DataAcces.Dao.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PruebasWebApi.DataAcces.Dao
{
    public class RedisDao : IDao
    {

        private readonly IDatabase _redis;

        public RedisDao()
        {
            _redis = RedisConfig.RedisCache;
        }

        public User Get()
        {
            var key = ConfigurationTools.GetRedisKey();
            return JsonConvert.DeserializeObject<User>( this._redis.StringGet(key));
        }

        public User Set(User user)
        {
            var key = ConfigurationTools.GetRedisKey();
             _redis.StringSet(key, JsonConvert.SerializeObject(user));
            return Get();
        }
    }
}
