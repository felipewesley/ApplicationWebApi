using Dominio.Enum.Perfil;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidade
{
    [Table("Perfil")]
    public class Perfil
    {
        [Key]
        [Column("PerfilId")]
        public PerfilEnum PerfilEnum { get; set; }
        public string Descricao { get; set; }
    }
}
