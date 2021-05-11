using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Entidades
{
    public class Company
    {
        #region Propiedades Auto Implementadas 
     [Key]
     public int Id { get; set; }
    [Required]
    [StringLength(30)]
    public string Name { get; set; }
    [Required]
    [StringLength(100)]
    public string Address { get; set; }
    [Required]
    [StringLength(10)]
    public string Postalcode { get; set; }
    [Required]
    [StringLength(15)]
    public string Phonenumber { get; set; }
    [Required]
    [StringLength(240)]
    public string Website { get; set; }
    [Required]
    [StringLength(100)]
    public string Email { get; set; }
    [StringLength(240)]
    public string Photo { get; set; }
        #endregion
    }
}
