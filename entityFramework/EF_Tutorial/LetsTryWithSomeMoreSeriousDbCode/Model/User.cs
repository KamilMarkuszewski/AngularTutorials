using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTryWithSomeMoreSeriousDbCode.Model
{
    [Table("Users")]
    public class User
    {
        [Column("ID")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime RegistrationDateTime { get; set; }

        [Column("SteamID")]
        [Required]
        [StringLength(250)]
        [Index("INDEX_Users_SteamID", IsClustered = false, IsUnique = true)]
        public string SteamId { get; set; }

        [Index("INDEX_Users_SteamLogin", IsClustered = false, IsUnique = true)]
        [Required]
        [StringLength(250)]
        public string SteamLogin { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public User(DateTime registrationDateTime, string steamId, string steamLogin)
        {
            RegistrationDateTime = registrationDateTime;
            SteamId = steamId;
            SteamLogin = steamLogin;
        }
    }
}
