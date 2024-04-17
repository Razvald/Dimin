using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogProject.Database
{
    public class GeologicalObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string? Name { get; set; }
        public ObjectType Type { get; set; }
        public int Depth { get; set; }
        public int XCoordinates { get; set; }
        public int YCoordinates { get; set; }
    }

    public enum ObjectType
    {
        Rock,
        Mineral,
        Fossil,
        Other
    }

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin,
        Worker
    }

    public class Equipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string? Name { get; set; }
        public ObjectType Availability { get; set; }
    }

    public class MeasurementProtocol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime MeasurementDate { get; set; }
        public int Parameter { get; set; }

        [ForeignKey("Equipment")]
        public int EquipmentID { get; set; }

        public virtual Equipment Equipment { get; set; }
    }

    public enum Status
    {
        Complete,
        Waining
    }

    public class Measurement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("MeasurementProtocol")]
        public int MeasurementProtocolID { get; set; }

        [ForeignKey("GeologicalObject")]
        public int GeologicalObjectID { get; set; }

        public virtual MeasurementProtocol MeasurementProtocol { get; set; }
        public virtual GeologicalObject GeologicalObject { get; set; }
    }

    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("MeasurementProtocol")]
        public int MeasurementProtocolID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public virtual MeasurementProtocol MeasurementProtocol { get; set; }
        public virtual User User { get; set; }
    }
}
