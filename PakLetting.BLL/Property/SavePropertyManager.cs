using PakLetting.DAL.PakLettingDBContext;
using PakLetting.Model.PropertyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.BLL.PropertyManager
{
    public class SavePropertyManager
    {
        public Property SaveCreator(int _creatorId, int _cityId, string _address, int _propertyTypeId, int _numberOfBedroom, int _numberOfWashroom, int _numberOfKitchen, bool _hasLivingRoom, bool _hasDrawingRoom, bool _hasCarParking, int _yearOfConstruction, DateTime _lastRenovated, string _nearBy, string _discription)
        {
            using (var context = new PakLettingDALContext())
            {
                Property property = new Property()
                {
                    CreatorId = _creatorId,
                    CityId = _cityId,
                    Address = _address,
                    PropertyTypeId = _propertyTypeId,
                    NumberOfBedroom = _numberOfBedroom,
                    NumberOfWashroom = _numberOfWashroom,
                    NumberOfKitchen = _numberOfKitchen,
                    HasLivingRoom = _hasLivingRoom,
                    HasDrawingRoom = _hasDrawingRoom,
                    HasCarParking = _hasCarParking,
                    YearOfConstruction = _yearOfConstruction,
                    LastRenovated = _lastRenovated,
                    NearBy = _nearBy,
                    Discription = _discription,
                    CreatedDate = DateTime.Now
                };
                context.Property.Add(property);
                context.SaveChanges();
                return property;
            }
        }
        public Property SaveCreator(int _id, int _creatorId, int _cityId, string _address, int _propertyTypeId, int _numberOfBedroom, int _numberOfWashroom, int _numberOfKitchen, bool _hasLivingRoom, bool _hasDrawingRoom, bool _hasCarParking, int _yearOfConstruction, DateTime _lastRenovated, string _nearBy, string _discription)
        {
            using (var context = new PakLettingDALContext())
            {
                Property property = context.Property.FirstOrDefault(x => x.Id == _id);
                if (property == null)
                {
                    return null;
                }

                property.Id = _id;
                property.CreatorId = _creatorId;
                property.CityId = _cityId;
                property.Address = _address;
                property.PropertyTypeId = _propertyTypeId;
                property.NumberOfBedroom = _numberOfBedroom;
                property.NumberOfWashroom = _numberOfWashroom;
                property.NumberOfKitchen = _numberOfKitchen;
                property.HasLivingRoom = _hasLivingRoom;
                property.HasDrawingRoom = _hasDrawingRoom;
                property.HasCarParking = _hasCarParking;
                property.YearOfConstruction = _yearOfConstruction;
                property.LastRenovated = _lastRenovated;
                property.NearBy = _nearBy;
                property.Discription = _discription;
                property.ModifiedDate = DateTime.Now;

                context.SaveChanges();
                return property;
            }
        }

    }
}
