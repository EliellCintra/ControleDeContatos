using ControleDeContatos.Models;

namespace ControleDeContatos.Repositório
{
    public interface iContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
