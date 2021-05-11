using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class Major
    {
        #region Propiedades Auto implementadas 
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength (30)]
        public string Name { get; set; }
        [StringLength (30)]
        public string PhoneNomber { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength (250)]
        public string Photo { get; set; }
        [Required]
        [StringLength (300)]
        public string Description { get; set; }
        #endregion
    }
}
