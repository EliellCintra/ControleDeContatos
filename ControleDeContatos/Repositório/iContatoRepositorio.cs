using ControleDeContatos.Models;

namespace ControleDeContatos.Repositório
{
    public interface iContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();

        ContatoModel Adicionar(ContatoModel contato);
    }
}
