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

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            // adiciona um novo registro (Contato) no banco de dados
            _bancoContext.Contatos.Add(contato);

            // salva as alterações no banco de dados
            _bancoContext.SaveChanges();

            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) throw new Exception("Houve um erro na atualização do contato!");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular= contato.Celular;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }
    }
}
