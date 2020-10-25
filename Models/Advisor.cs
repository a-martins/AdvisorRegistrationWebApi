using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvisorRegistrationWebApi.Models
{
    public class Advisor
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string fullName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string mobile { get; set; }

        public int registryNumber { get; set; }
    }
}
