using System;
using System.Threading.Tasks;
using MongoDB.Entities;

namespace infrastructure
{
    public class Values : Entity
    {
        public string stuff { get; set; }
    }

    public class Class1
    {
        public static async Task<string> GrabTestData()
        {
            var Result = "";

            await DB.InitAsync("jac_test", "localhost", 27017);
            var values = await DB.Find<Values>().ManyAsync(v => v.stuff == "other");
            foreach (var OneVal in values)
            {
                Result += "," + OneVal;
            }
            if (!string.IsNullOrEmpty(Result)) { Result.Substring(1); }

            return Result;
        }
    }
}
