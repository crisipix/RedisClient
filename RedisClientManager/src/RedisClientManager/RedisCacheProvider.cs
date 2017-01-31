using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;


namespace RedisClientManager
{
    public interface ICacheProvider
    {
        void Set<T>(string key, T value);

        void Set<T>(string key, T value, TimeSpan timeout);

        T Get<T>(string key);

        bool Remove(string key);

        bool IsInCache(string key);
    }

    public class RedisCacheProvider : ICacheProvider
    {
        //RedisEndpoint _endPoint;
        //ConnectionMultiplexer redis;

        public RedisCacheProvider()
        {
            //_endPoint = new RedisEndpoint("localhost", "6379", null, "Chris");
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
        }

        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public bool IsInCache(string key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T value)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T value, TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        //public void Set<T>(string key, T value)
        //{
        //    this.Set(key, value, TimeSpan.Zero);
        //}

        //public void Set<T>(string key, T value, TimeSpan timeout)
        //{

        //    //using (RedisClient client = new RedisClient("localhost", 6379))
        //    //{
        //    //    client.As<T>().SetValue(key, value, timeout);
        //    //}
        //}

        //public T Get<T>(string key)
        //{
        //    T result = default(T);

        //    using (RedisClient client = new RedisClient("localhost", 6379))
        //    {
        //        var wrapper = client.As<T>();

        //        result = wrapper.GetValue(key);
        //    }

        //    return result;
        //}

        //public bool Remove(string key)
        //{
        //    bool removed = false;

        //    using (RedisClient client = new RedisClient("localhost", 6379))
        //    {
        //        removed = client.Remove(key);
        //    }

        //    return removed;
        //}

        //public bool IsInCache(string key)
        //{
        //    bool isInCache = false;

        //    using (RedisClient client = new RedisClient("localhost", 6379))
        //    {
        //        isInCache = client.ContainsKey(key);
        //    }

        //    return isInCache;
        //}
    }
}
