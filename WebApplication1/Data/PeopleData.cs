using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    [Table("People", Schema = "Application")]
    public class PeopleData
    {
        [Key]
        public int PersonID { get; set; }

        public string FullName { get; set; }

        public string PreferredName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }
    }
}
