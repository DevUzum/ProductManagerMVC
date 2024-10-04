using Microsoft.AspNetCore.Mvc;
using ProductManagerMVC.Models;
using ProductManagerMVC.Service;

namespace ProductManagerMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public IActionResult Index()
        {
            var produtos = _produtoService.Obter();
            return View(produtos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            _produtoService.Inserir(produto);
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Produto produto)
        {
            _produtoService.Alterar(produto);
            return View();
        }

        public IActionResult Details(int id)
        {
            var produto = _produtoService.ObterPorId(id);
            return View(produto);
        }

        public IActionResult Delete(int id)
        {
            var produto = _produtoService.ObterPorId(id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult Delete(Produto produto)
        {
            _produtoService.Remover(produto.Id);
            return RedirectToAction("Index");
        }
    }
}
