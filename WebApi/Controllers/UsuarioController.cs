using Dominio.Model.Usuario;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("lista")]
        public async Task<IList<UsuarioListaModel>> ListarUsuarios()
        {
            return await _usuarioService.ListarUsuarios();
        }

        [HttpGet("{usuarioId}")]
        public async Task<UsuarioDetalheModel> ObterUsuario(int usuarioId)
        {
            return await _usuarioService.ObterUsuario(usuarioId);
        }
    }
}