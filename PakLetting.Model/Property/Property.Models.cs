using PakLetting.Model.CreatorModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakLetting.Model.PropertyModels
{
    [Table("Property")]
    public class Property
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Creator")]
        public int CreatorId { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        [ForeignKey("PropertyType")]
        public int PropertyTypeId { get; set; }
        [ForeignKey("MeasurmentType")]
        public int MeasurmentId { get; set; }
        public string Address { get; set; }
        public int NumberOfBedroom { get; set; }
        public int NumberOfWashroom { get; set; }
        public int NumberOfKitchen { get; set; }
        public bool HasLivingRoom { get; set; }
        public bool HasDrawingRoom { get; set; }
        public bool HasCarParking { get; set; }
        public int YearOfConstruction { get; set; }
        public DateTime LastRenovated { get; set; }
        public string NearBy { get; set; }
        public string Discription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Creator Creator { get; set; }
        public virtual City City { get; set; }
        public virtual PropertyType PropertyType { get; set; }
        public virtual MeasurmentType MeasurmentType { get; set; }
    }
    /// <summary>
    /// Apartment, house, 1st floor, 2nd floor
    /// </summary>
    [Table("PropertyType")]
    public class PropertyType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
    [Table("Rent")]
    public class Rent
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        [ForeignKey("TypeOfRent")]
        public int TypeOfRentId { get; set; }
        [ForeignKey("Availability")]
        public int AvailabilityId { get; set; }
        public decimal MonthlyRent { get; set; }
        public decimal Leasing { get; set; }

        public virtual Availability Availability { get; set; }
        public virtual TypesOfRent TypeOfRent { get; set; }
        public virtual Property Property { get; set; }
    }
    /// <summary>
    /// Immidiately, 1 month notice, 
    /// </summary>
    [Table("Availability")]
    public class Availability
    {
        [Key]
        public int Id { get; set; }
        public string Available { get; set; }
    }
    /// <summary>
    /// Room, 1st floor, house, 
    /// </summary>
    [Table("TypeOfRent")]
    public class TypesOfRent
    {
        [Key]
        public int Id { get; set; }
        public string Discription { get; set; }
    }
    [Table("Sale")]
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        public decimal Price { get; set; }
        public string MeasurmentDescription { get; set; }
        public int NumberOfFloor { get; set; }

        public Property Property { get; set; }
    }
    [Table("City")]
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
    [Table("CityArea")]
    public class Area
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public string Part { get; set; }

        public virtual City City { get; set; }
    }
    /// <summary>
    /// 80 yards, 100 yards, house, 
    /// </summary>
    [Table("PropertyMeasurment")]
    public class MeasurmentType
    {
        [Key]
        public int Id { get; set; }
        public string Measurment { get; set; }
    }
}
