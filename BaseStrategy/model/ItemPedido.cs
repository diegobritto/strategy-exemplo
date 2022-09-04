using System.ComponentModel.DataAnnotations;

namespace BaseStrategy.model
{
    public class ItemPedido
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public int CodigoPedido { get; set; }
        
        [MaxLength(100)]
        [Required]
        [MinLength(3)]
        public string Nome { get; set; }
        
        [MaxLength(100)]
        [Required]
        [MinLength(10)]
        public string Descricao { get; set; }
    }
}
