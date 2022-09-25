using PakLetting.Model.PropertyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.Model.CreatorModels
{
    [Table("Creator")]
    public class Creator
    {
        [Key]
        public int Id { get; set; }
        public Guid UserSubscriptionId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PreferredContact? PreferredContact { get; set; }
        public string BestTimeToContact { get; set; }
        public string PersonalDiscription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Property> AllProperties { get; set; }
    }
    public enum PreferredContact
    {
        Mobile = 1,
        Landline = 2,
        Email = 3
    }
}
