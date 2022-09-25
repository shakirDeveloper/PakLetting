using PakLetting.DAL.PakLettingDBContext;
using PakLetting.Model.SeekerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.BLL.SeekerManager
{
    public class SaveSeekerManager
    {
        public Seeker SaveSeeker(Guid _userSubscriptionID, string _name, string _phone, string _email, DateTime _dateOfBirth, string _personalDiscription)
        {
            using (var context = new PakLettingDALContext())
            {
                Seeker seeker = new Seeker()
                {
                    UserSubscriptionId = _userSubscriptionID,
                    Name = _name,
                    Phone = _phone,
                    Email = _email,
                    DateOfBirth = _dateOfBirth,
                    PersonalDiscription = _personalDiscription,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = null
                };
                context.Seeker.Add(seeker);
                context.SaveChanges();
                return seeker;
            }
        }
        public Seeker SaveSeeker(int _id, Guid _userSubscriptionID, string _name, string _phone, string _email, DateTime _dateOfBirth, string _personalDiscription)
        {
            using (var context = new PakLettingDALContext())
            {
                Seeker seeker = context.Seeker.FirstOrDefault(x => x.Id == _id);
                if (seeker == null)
                {
                    return null;
                }
                seeker.UserSubscriptionId = _userSubscriptionID;
                seeker.Name = _name;
                seeker.Phone = _phone;
                seeker.Email = _email;
                seeker.DateOfBirth = _dateOfBirth;
                seeker.PersonalDiscription = _personalDiscription;
                seeker.ModifiedDate = DateTime.Now;

                context.SaveChanges();
                return seeker;
            }
        }

    }
}
