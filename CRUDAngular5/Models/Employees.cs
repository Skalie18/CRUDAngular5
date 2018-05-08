namespace CRUDAngular5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpLastName { get; set; }

        [Required]
        [StringLength(10)]
        public string EmpCode { get; set; }

        [Required]
        [StringLength(5)]
        public string EmpDivision { get; set; }

        [Required]
        [StringLength(10)]
        public string EmpDepartment { get; set; }
    }
}
