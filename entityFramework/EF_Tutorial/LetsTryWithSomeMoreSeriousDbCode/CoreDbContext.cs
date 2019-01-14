using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTryWithSomeMoreSeriousDbCode.Model;

namespace LetsTryWithSomeMoreSeriousDbCode
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext() : base()
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<LevelData> LevelsData { get; set; }
        public DbSet<GameStateData> GameStatesData { get; set; }
        public DbSet<SessionData> SessionsData { get; set; }
    }
}
