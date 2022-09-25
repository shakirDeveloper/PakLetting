using PakLetting.DAL.PakLettingDBContext;
using PakLetting.Model.SeekerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.BLL.SeekerManager
{
    public class GetSeekerManager
    {
        public ICollection<Seeker> GetAllCreator()
        {
            using (var context = new PakLettingDALContext())
            {
                IEnumerable<Seeker> seekers = context.Seeker.ToList();
                return seekers.ToList();
            }
        }
        public Seeker GetAllCreator(int _id, Guid _userSubscriptionID)
        {
            using (var context = new PakLettingDALContext())
            {
                Seeker seeker = context.Seeker.FirstOrDefault(x => x.Id == _id && x.UserSubscriptionId == _userSubscriptionID);
                return seeker;
            }
        }
    }
}
