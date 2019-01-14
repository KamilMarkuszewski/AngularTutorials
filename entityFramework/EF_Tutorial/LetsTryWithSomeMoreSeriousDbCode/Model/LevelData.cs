using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTryWithSomeMoreSeriousDbCode.Model
{
    [Table("LevelsData")]
    public class LevelData
    {
        [Column("ID")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int LevelNumber { get; set; }

        [Column("UserID")]
        [Required]
        [Index("INDEX_LevelsData_UserID", IsClustered = false, IsUnique = true)]
        public int UserId { get; set; }

        public User User { get; set; }

        [Required]
        public bool IsFinnished { get; set; }

        [Required]
        public int DeathsCount { get; set; }

        public int FinnishedLevelSteps { get; set; }


        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
