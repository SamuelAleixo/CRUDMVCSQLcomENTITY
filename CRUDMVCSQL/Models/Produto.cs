using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDMVCSQL.Models
{

 [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]

        public int Id { get; set; }


        [Column("Nome")]
        [Display(Name = "Nome")]

        public String Nome { get; set; }
    }
}
