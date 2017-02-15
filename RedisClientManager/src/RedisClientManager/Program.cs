﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;
using System.Threading;
//using ServiceStack.Redis;


namespace RedisClientManager
{
    public class Program
    {
        /// <summary>
        /// https://redis.io/commands
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Redis Desktop Manager : http://docs.redisdesktop.com/en/latest/quick-start/");
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            IDatabase db = redis.GetDatabase();

            GetValuesAsync(db);
            GetValues(db);


            Console.WriteLine( "Done");
            Console.ReadLine();
           
        }

        public static async void GetValuesAsync(IDatabase db)
        {
            string asyncValue = "Async_abcdefg";
            await db.StringSetAsync(asyncValue, "Asynchronous Access Test");
            Task<int> something = LongRunning();
            Task<RedisValue> result = db.StringGetAsync(asyncValue);

            Console.WriteLine($"Result : {result.Result}");
        }

        public static void GetValues(IDatabase db)
        {
            string value = "Core1.0_abcdefg";
            db.StringSet("coreKey", value);
            string getValue = db.StringGet("coreKey");
            Console.WriteLine($"Your Value is {getValue}"); // writes: "abcdefg"
        }

        public static async Task<int> LongRunning()
        {
            Thread.Sleep(1000);
            Console.WriteLine( "DOne waiting");
            return 1;
        }
    }
}
