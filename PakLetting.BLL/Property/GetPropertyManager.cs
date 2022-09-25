using PakLetting.DAL.PakLettingDBContext;
using PakLetting.Model.PropertyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.BLL.PropertyManager
{
    public class GetPropertyManager
    {        
        public ICollection<Property> GetAllProperty() 
        {           
            using (var context = new PakLettingDALContext())
            {
                IEnumerable<Property> properties = context.Property;

                if (properties == null)
                {
                    return null;
                }
                return properties.ToList();
            }           
        }
        
    }
}
