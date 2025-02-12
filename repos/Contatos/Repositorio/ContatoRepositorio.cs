using Contatos.Data;
using Contatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos.Repositorio
{
    public class ContatoRepositorio : Icontato
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public Contato Adicionar(Contato contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public List<Contato> ListarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
    }
}
