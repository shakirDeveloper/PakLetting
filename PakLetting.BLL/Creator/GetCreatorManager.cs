using PakLetting.DAL.PakLettingDBContext;
using PakLetting.Model.CreatorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.BLL.CreatorManager
{
    public class GetCreatorManager
    {
        public ICollection<Creator> GetAllCreator() 
        {
            using(var context = new PakLettingDALContext())
            {
                IEnumerable<Creator> creators = context.Creator.ToList();
                return creators.ToList();
            }
        }
        public Creator GetAllCreator(int _id, Guid _userSubscriptionID)
        {
            using (var context = new PakLettingDALContext())
            {
                Creator creator = context.Creator.FirstOrDefault(x=>x.Id == _id && x.UserSubscriptionId == _userSubscriptionID);
                return creator;
            }
        }
    }
}
