namespace WpfStudentManagementSysWithDbFirstApproach.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInfo")]
    public partial class tblInfo
    {
        public int id { get; set; }

        [StringLength(50)]
        public string StudentName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        public bool? Gender { get; set; }

        [StringLength(50)]
        public string Class { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        [StringLength(50)]
        public string FatherName { get; set; }

        public int? CaliberRate { get; set; }

        [StringLength(50)]
        public string Address { get; set; }
    }
}
