using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.Repositório
{
    public class ContatoRepositorio : iContatoRepositorio
    {
        // variável criada para instanciar o bancoContext
        private readonly BancoContext _bancoContext;

        // injeção de dependencias no construtor
        public ContatoRepositorio(BancoContext bancoContex) 
        {
            _bancoContext = bancoContex;    
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            // adiciona um novo registro (Contato) no banco de dados
            _bancoContext.Contatos.Add(contato);

            // salva as alterações no banco de dados
            _bancoContext.SaveChanges();

            return contato;
        }
    }
}
