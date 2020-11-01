using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvisorRegistrationWebApi.Models
{
    public class Advisor
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string FullName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string Mobile { get; set; }

        public int RegistryNumber { get; set; }
    }
}
