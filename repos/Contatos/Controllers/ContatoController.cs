using Contatos.Models;
using Contatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Contatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly Icontato _icontato;

        public ContatoController(Icontato icontato)
        {
            _icontato = icontato;
        }
        public IActionResult Index(int? pagina)
        {
            const int itensPorPagina = 5;
            int numeroPagina = (pagina ?? 1);
            List<Contato> contatos = _icontato.ListarTodos();

            return View(contatos.ToPagedList(numeroPagina, itensPorPagina));
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adicionar(Contato contato)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    _icontato.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato Cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(contato);

            } catch(System.Exception e)
            {
                TempData["MensagemErro"] = $"Erro no cadastro; {e.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Detalhe()
        {
            return View();
        }
    }
}
