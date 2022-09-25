using PakLetting.DAL.PakLettingDBContext;
using PakLetting.Model.SeekerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.BLL.SeekerManager
{
    public class DeleteSeekerManager
    {
        public bool DeleteSeeker(int _id)
        {
            using (var context = new PakLettingDALContext())
            {
                Seeker seeker = context.Seeker.FirstOrDefault(x => x.Id == _id);
                if (seeker == null)
                {
                    return false;
                }
                context.Seeker.Remove(seeker);
                context.SaveChanges();
                return true;
            }
        }
    }
}
