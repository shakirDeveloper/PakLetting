using PakLetting.DAL.PakLettingDBContext;
using PakLetting.Model.CreatorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.BLL.CreatorManager
{
    public class DeleteCreatorManager
    {
        public bool DeleteCreator(int _id)
        {
            using(var context = new PakLettingDALContext())
            {
                Creator creator = context.Creator.FirstOrDefault(x => x.Id == _id);
                if (creator == null)
                {
                    return false;
                }
                context.Creator.Remove(creator);
                context.SaveChanges();
                return true;
            }
        }
    }
}
