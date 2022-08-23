using System.ComponentModel.DataAnnotations;

namespace Clientes.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Complemento { get; set; }
    }
}
