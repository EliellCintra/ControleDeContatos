using ControleDeContatos.Models;

namespace ControleDeContatos.Repositório
{
    public interface iContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
    }
}
