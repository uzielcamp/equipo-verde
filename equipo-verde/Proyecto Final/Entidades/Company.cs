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
    [StringLength(30)]
    public string Address { get; set; }
    [Required]
    [StringLength(30)]
    public string postalCode { get; set; }
    [Required]
    [StringLength(30)]
    public string phoneNumberc { get; set; }
    [Required]
    [StringLength(30)]
    public string website { get; set; }
    [Required]
    [StringLength(30)]
    public string email { get; set; }
    [StringLength(30)]
    public string Photo { get; set; }
        #endregion
    }
}
