using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GStore.Models;


    [Table("categoria")]
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id { get; set; } 
       
        [Required(ErrorMessage = "toma no cu, pare de ser um ímbecil e escreva seu nome")]
        [StringLength(30, ErrorMessage = "máximo de 30 caracteres, seu animal")]
       public string Nome { get; set; }

        [StringLength(300)]
       public string Foto { get; set; }
    }
