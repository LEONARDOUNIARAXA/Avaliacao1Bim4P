using Avaliacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avaliacao.Models;

namespace Avaliacao.Repositories;

public class CartasRepository
{
    public List<CartaModel> cartasList;
    public CartasRepository()
    {
        cartasList = new List<CartaModel>();
        cartasList.Add(
            new CartaModel("Leonardo Lemos", new Endereco("Rua Limírio Flávio da Silva", 515, "Fertiza", "Araxá", "MG"), 14, "Quero um PC Gamer de presente!")
        );
        cartasList.Add(
            new CartaModel("Humberto Melo", new Endereco("Avenida Paulista", 91, "Centro", "São Paulo", "SP"), 13, "Quero um carro de formula 1!")
        );
    }

    public void Adicionar(CartaModel carta)
    {
        cartasList.Add(carta);
    }

    public IEnumerable<CartaModel> Listar()
    {
        return cartasList;
    }

    public IEnumerable<CartaModel> ListarPorCidade(string cidade)
    {
        var pesquisa = cartasList.FindAll(carta => carta.Endereco.Cidade == cidade);

        return pesquisa;
    }

}

