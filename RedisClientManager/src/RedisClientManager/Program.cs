using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;
//using ServiceStack.Redis;


namespace RedisClientManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Redis Desktop Manager : http://docs.redisdesktop.com/en/latest/quick-start/");
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            IDatabase db = redis.GetDatabase();
            string value = "Core1.0_abcdefg";
            db.StringSet("coreKey", value);
            string getValue = db.StringGet("coreKey");
            Console.WriteLine($"Your Value is {getValue}"); // writes: "abcdefg"
            Console.ReadLine();
        }
    }
}
