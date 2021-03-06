using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YConnectBackend.Domain.Commons.Models
{
    [Table("Member")]
    public class Member
    {
        [Key]
        public uint Id { get; set; }
        
        [ForeignKey("User")]
        public uint MemberId { get; set; }
        
        [ForeignKey("Group")]
        public uint GroupId { get; set; }
    }
}