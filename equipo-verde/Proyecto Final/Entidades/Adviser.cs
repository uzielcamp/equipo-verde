using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class Adviser
    {
        #region
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(30)]
        public string PhoneNumber { get; set; }
        [StringLength(30)]
        public string Cellphone { get; set; }
        [StringLength(30)]
        public string email { get; set; }
        [StringLength(30)]
        public string Department { get; set; }
        [StringLength(30)]
        public string FullName { get { return $"{FirstName}{LastName}"; } }
        #endregion
    }
}
