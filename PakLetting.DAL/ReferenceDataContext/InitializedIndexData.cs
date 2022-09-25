using PakLetting.DAL.PakLettingDBContext;
using PakLetting.Model.PropertyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.DAL.ReferenceDataContext
{
    public class InitializedIndexData : System.Data.Entity.DropCreateDatabaseIfModelChanges<PakLettingDALContext>
    {
        protected override void Seed(PakLettingDALContext context)
        {
            var propertyType = new List<PropertyType>
            {
            new PropertyType{Type="House"},
            new PropertyType{Type="Apartment"},
            new PropertyType{Type="Flat"},
            new PropertyType{Type="Studio Apartment"},
            new PropertyType{Type="Single Floor"},
            new PropertyType{Type="Double Floor"},
            new PropertyType{Type="Commercial Building"},
            new PropertyType{Type="Nino"}
            };

            propertyType.ForEach(s => context.PropertyType.Add(s));
            context.SaveChanges();


            var city = new List<City>
            {
            new City{Name="Karachi "},
            new City{Name="Lahore"},
            new City{Name="Islamabad"},
            new City{Name="Quetta"},
            new City{Name="Pishawar"},
            new City{Name="Sukkar"},
            new City{Name="Hadrabad"},
            new City{Name="Multan"}
            };

            city.ForEach(s => context.City.Add(s));
            context.SaveChanges();


            var availability = new List<Availability>
            {
            new Availability{Available="Immediately"},
            new Availability{Available="One Month"},
            new Availability{Available="More than a month"},
            new Availability{Available="2 weeks"},
            new Availability{Available="Less than month"},
            new Availability{Available="Other"}
            };

            availability.ForEach(s => context.Availability.Add(s));
            context.SaveChanges();


            var typesOfRent = new List<TypesOfRent>
            {
            new TypesOfRent{Discription="House"},
            new TypesOfRent{Discription="1st floor"},
            new TypesOfRent{Discription="2nd floor"},
            new TypesOfRent{Discription="Apartment"},
            new TypesOfRent{Discription="Flat"},
            new TypesOfRent{Discription="Single room"},
            new TypesOfRent{Discription="Double rooms"},
            new TypesOfRent{Discription="Other"}
            };

            propertyType.ForEach(s => context.PropertyType.Add(s));
            context.SaveChanges();


            var measurmentType = new List<MeasurmentType>
            {
            new MeasurmentType{Measurment="60Yards"},
            new MeasurmentType{Measurment="80Yards"},
            new MeasurmentType{Measurment="100Yards"},
            new MeasurmentType{Measurment="120Yards"},
            new MeasurmentType{Measurment="160Yards"},
            new MeasurmentType{Measurment="200Yards"},
            new MeasurmentType{Measurment="240Yards"},
            new MeasurmentType{Measurment="280Yards"},
            new MeasurmentType{Measurment="300Yards"},
            new MeasurmentType{Measurment="320Yards"},
            new MeasurmentType{Measurment="360Yards"},
            new MeasurmentType{Measurment="400Yards"},
            new MeasurmentType{Measurment="450Yards"},
            new MeasurmentType{Measurment="500Yards"},
            new MeasurmentType{Measurment="600Yards"},
            new MeasurmentType{Measurment="600Yards+"}
            };

            measurmentType.ForEach(s => context.MeasurementType.Add(s));
            context.SaveChanges();
        }
    }
}
