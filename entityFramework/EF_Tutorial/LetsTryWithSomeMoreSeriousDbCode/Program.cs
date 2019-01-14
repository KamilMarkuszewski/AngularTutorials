using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTryWithSomeMoreSeriousDbCode.Model;

namespace LetsTryWithSomeMoreSeriousDbCode
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTestData();



            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void AddTestData()
        {
            using (var context = new CoreDbContext())
            {
                var testUser = new User(DateTime.Now, "STEAM_0:1:23234345", "loginExample");
                context.Users.Add(testUser);

                context.SaveChanges();

                var testGameStatsData = new GameStateData(testUser.Id, testUser, 0, 1);
                context.GameStatesData.Add(testGameStatsData);

                context.SaveChanges();
            }
        }
    }
}
