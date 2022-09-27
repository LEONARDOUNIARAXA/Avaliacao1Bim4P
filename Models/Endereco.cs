using System.ComponentModel.DataAnnotations;

namespace Avaliacao.Models;

public class Endereco
{

    public Endereco(string rua, int numero, string bairro, string cidade, string estado)
    {
        Rua = rua;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
    }

    [Required]
    public string Rua { get; set; }
    
    [Required]
    public int Numero { get; set; }
    
    [Required]
    public string Bairro { get; set; }
    
    [Required]
    public string Cidade { get; set; }
    
    [Required]
    public string Estado { get; set; }
}
