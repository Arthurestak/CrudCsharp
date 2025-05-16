using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int Id); // READ
        Task<UsuarioModel> Adicionar(UsuarioModel usuario); // CREATE
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id); // UPDATE
        Task<bool> ApagarPorId(int Id); // DELETE
    }
}
