using Dominio.Enum.Perfil;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidade
{
    [Table("Usuario")]
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }

        public PerfilEnum PerfilEnum { get; set; }
        [ForeignKey(nameof(PerfilEnum))]
        public Perfil Perfil { get; set; }
    }
}
