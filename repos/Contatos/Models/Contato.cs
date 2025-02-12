using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [EmailAddress(ErrorMessage ="E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string  Endereco{ get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string  NomeMae { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomePai { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public float CPF { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public float RG{ get; set; }

    }
}
