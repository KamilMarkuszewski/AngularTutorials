using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsTryWithSomeMoreSeriousDbCode.Model
{
    [Table("GameStatesData")]
    public class GameStateData
    {
        [Column("ID")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("UserID")]
        [Required]
        [Index("INDEX_GameStatesData_USerID", IsClustered = false, IsUnique = true)]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int TotalSteps { get; set; }

        [Required]
        public int CurrentLevelNumber { get; set; }


        [Timestamp]
        public byte[] RowVersion { get; set; }

        public GameStateData(int userId, User user, int totalSteps, int currentLevelNumber)
        {
            UserId = userId;
            User = user;
            TotalSteps = totalSteps;
            CurrentLevelNumber = currentLevelNumber;
        }
    }
}
