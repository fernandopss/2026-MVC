using Microsoft.AspNetCore.Mvc;

namespace MVC_2026;

public class ProdutosControllers : Controller
{
    private List<Produto> _listaProdutos = new List<Produto>();
    public ProdutosControllers()
    {
        _listaProdutos.Add(new Produto { Id = Guid.NewGuid(), Nome = "Chave de Fenda", Quantidade = 65 });
        _listaProdutos.Add(new Produto { Id = Guid.NewGuid(), Nome = "Alicate", Quantidade = 99 });
        _listaProdutos.Add(new Produto { Id = Guid.NewGuid(), Nome = "Martelo", Quantidade = 37 });
        _listaProdutos.Add(new Produto { Id = Guid.NewGuid(), Nome = "Parafuso", Quantidade = 56 });
        _listaProdutos.Add(new Produto { Id = Guid.NewGuid(), Nome = "Fita Isolante", Quantidade = 82 });
    }

    public IActionResult Index()
    {
        var Produtos = _listaProdutos;
        return View(Produtos);
    }


}
