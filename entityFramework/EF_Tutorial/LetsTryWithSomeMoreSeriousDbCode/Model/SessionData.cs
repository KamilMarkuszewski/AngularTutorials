using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTryWithSomeMoreSeriousDbCode.Model
{
    public class SessionData
    {
        [Column("ID")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("UserID")]
        [Required]
        [Index("INDEX_SessionsData_UserID", IsClustered = false, IsUnique = true)]
        public int UserId { get; set; }

        public User User { get; set; }

        [Required]
        public DateTime LoginDateTime { get; set; }

        public DateTime LogoutDateTime { get; set; }


        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
