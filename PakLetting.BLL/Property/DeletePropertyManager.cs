using PakLetting.DAL.PakLettingDBContext;
using PakLetting.Model.PropertyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.BLL.PropertyManager
{
    public class DeletePropertyManager
    {
        public bool DeleteCreator(int _id)
        {
            using (var context = new PakLettingDALContext())
            {
                Property property = context.Property.FirstOrDefault(x => x.Id == _id);
                if (property == null)
                {
                    return false;
                }
                context.Property.Remove(property);
                context.SaveChanges();
                return true;
            }
        }
    }
}
