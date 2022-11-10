using Dominio.Model.Usuario;
using Microsoft.EntityFrameworkCore;
using Repositorio;

namespace Services
{
    public class UsuarioService
    {
        private readonly BdContexto _contexto;

        public UsuarioService(BdContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IList<UsuarioListaModel>> ListarUsuarios()
        {
            //var usuarios = await _contexto.Usuario
            //    .Select(u => new UsuarioListaModel
            //    {
            //        UsuarioId = u.UsuarioId,
            //        Nome = u.Nome
            //    })
            //    .ToListAsync();

            var usuarios = new List<UsuarioListaModel>();

            usuarios.Add(new UsuarioListaModel
            {
                UsuarioId = 1,
                Nome = "João"
            });

            return usuarios;
        }

        public async Task<UsuarioDetalheModel> ObterUsuario(int usuarioId)
        {
            // Validação
            if (usuarioId == 0)
                throw new Exception("Usuário não encontrado");

            //var usuario = await _contexto.Usuario
            //    .Include(u => u.Perfil)
            //    .Where(u => u.UsuarioId == usuarioId)
            //    .Select(u => new UsuarioDetalheModel
            //    {
            //        UsuarioId = u.UsuarioId,
            //        Nome = u.Nome,
            //        Perfil = u.Perfil.Descricao
            //    })
            //    .FirstOrDefaultAsync();

            var usuario = new UsuarioDetalheModel
            {
                UsuarioId = 1,
                Nome = "João",
                Perfil = "Administrador"
            };

            if (usuario == null)
                throw new Exception("Usuário não encontrado");

            return usuario;
        }
    }
}
