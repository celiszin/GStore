
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GStore.Models;
[Table("produto_foto")]
public class ProdutoFoto
{

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O produto precisa ser informado.") ]
        public int ProdutoId { get; set; }

        [ForeignKey(nameof(ProdutoId))]
        public Produto Produto { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "Arquivo da Foto")]    
        public string ArquivoFoto { get; set; }


        [Display(Name = "Descrição")]    
        [StringLength(60, ErrorMessage = "A Descrição deve possuir no máximo")]
        public string Descricao { get; set; }
}
