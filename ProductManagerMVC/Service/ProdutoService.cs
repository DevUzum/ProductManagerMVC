using ProductManagerMVC.Models;

namespace ProductManagerMVC.Service
{
    public class ProdutoService
    {
        List<Produto> produtos = new List<Produto>();        

        public List<Produto> Obter()
        {
            return produtos;
        }

        public void Inserir(Produto produto)
        {
            produtos.Add(new Produto()
            {
                Id = produtos.Count,
                Nome = produto.Nome,
                Preco = produto.Preco,
                Categoria = produto.Categoria,
                Estoque = produto.Estoque
            });
        }

        public void Remover(int id)
        {
            produtos.RemoveAt(id);
        }

        public void Alterar(Produto produto)
        {
            var produtoObtido = produtos.FirstOrDefault(x => x.Id == produto.Id);
            produtoObtido.Nome = produto.Nome;
            produtoObtido.Preco = produto.Preco;
            produtoObtido.Categoria = produto.Categoria;
            produtoObtido.Estoque = produto.Estoque;
        }

        public Produto ObterPorId(int id)
        {
            return produtos.First(x => x.Id == id);
        }
    }
}
