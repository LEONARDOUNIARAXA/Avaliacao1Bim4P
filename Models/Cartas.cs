using System.ComponentModel.DataAnnotations;

namespace Avaliacao.Models;
public class CartaModel
{

    public CartaModel(string nomeCrianca, Endereco endereco, int idade, string textoCarta)
    {
        NomeCrianca = nomeCrianca;
        Endereco = endereco;
        Idade = idade;
        TextoCarta = textoCarta;
    }

    [Required]
    public string NomeCrianca { get; set; }

    [Required]
    public Endereco Endereco { get; set; }

    [Required]
    [Range(0, 15)]
    public int Idade { get; set; }

    [Required]
    [StringLength(500, MinimumLength = 0)]
    public string TextoCarta { get; set; }
}
