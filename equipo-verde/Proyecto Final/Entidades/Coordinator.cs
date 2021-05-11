using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class Coordinator
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
        public string Cellphone { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(30)]
        public string Photo { get; set; }
        public string FullName { get { return $"{FirstName}{LastName}"; } }
        #endregion
    }
}
