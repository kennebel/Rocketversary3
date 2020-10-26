using System;
using System.Threading.Tasks;
using MongoDB.Entities;
using src.infrastructure.Data.Models;

namespace infrastructure
{
    public class Test : Entity
    {
        public string stuff { get; set; }
    }

    public class Class1
    {
        public static async Task<string> GrabTestData()
        {
            var Result = "";

            await DB.InitAsync("jac_test");
            var test_values = await DB.Find<Test>().ManyAsync(v => true);
            foreach (var OneVal in test_values)
            {
                Result += "," + OneVal.stuff;
            }
            if (!string.IsNullOrEmpty(Result)) { Result = Result.Substring(1); }

            return Result;
        }

        public static async Task SaveTestRecord()
        {
            await DB.InitAsync("jac_test");
            var siteConfig = new SiteConfig()
            {
                ContactDescription = "Jeremy",
                ContactEmail = "rocketversary@kennebel.com"
            };
            await siteConfig.SaveAsync();
        }
    }
}
