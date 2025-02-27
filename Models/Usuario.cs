using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Mysqlx;
using Org.BouncyCastle.Asn1.X509;

namespace GStore.Models;

[Table("Usuario")]
public class Usuario : IdentityUser
{
    [Required(ErrorMessage = "Coloca o nome, eu te amo")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no maximo 60 caracteres, calabreso")]
    public string Nome { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data De Nascimento")]
    public DateTime DataNascimento {get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
}
