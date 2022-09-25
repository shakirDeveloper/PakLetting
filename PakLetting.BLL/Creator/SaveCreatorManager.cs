using PakLetting.DAL.PakLettingDBContext;
using PakLetting.Model.CreatorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.BLL.CreatorManager
{
    public class SaveCreatorManager
    {
        public Creator SaveCreator(Guid _userSubscriptionID, string _name, string _address, string _phone, string _email, DateTime _dateOfBirth, PreferredContact _preferredContact, string _bestTimeToContact, string _personalDiscription)
        {
            using (var context = new PakLettingDALContext())
            {
                Creator creator = new Creator()
                {
                    UserSubscriptionId = _userSubscriptionID,
                    Name = _name,
                    Address = _address,
                    Phone = _phone,
                    Email = _email,
                    DateOfBirth = _dateOfBirth,
                    PreferredContact = _preferredContact,
                    BestTimeToContact = _bestTimeToContact,
                    PersonalDiscription = _personalDiscription,
                    CreatedDate = DateTime.Now
                };
                context.Creator.Add(creator);
                context.SaveChanges();
                return creator;
            }
        }
        public Creator SaveCreator(int _id, Guid _userSubscriptionID, string _name, string _address, string _phone, string _email, DateTime _dateOfBirth, PreferredContact _preferredContact, string _bestTimeToContact, string _personalDiscription)
        {
            using (var context = new PakLettingDALContext())
            {
                Creator creator = context.Creator.FirstOrDefault(x => x.Id == _id);
                if (creator == null)
                {
                    return null;
                }

                creator.Name = _name;
                creator.Address = _address;
                creator.Phone = _phone;
                creator.Email = _email;
                creator.DateOfBirth = _dateOfBirth;
                creator.PreferredContact = _preferredContact;
                creator.BestTimeToContact = _bestTimeToContact;
                creator.PersonalDiscription = _personalDiscription;
                creator.ModifiedDate = DateTime.Now;

                context.SaveChanges();
                return creator;
            }
        }
    }
}
