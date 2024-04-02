using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContados.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Digite o nome do contato!!")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage ="Digite o e-mail do contato")]
        [EmailAddress(ErrorMessage ="O email informado é inválido")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Digite o celular do contato")]
        [Phone(ErrorMessage ="O número informado não é válido")]
        public string Celular { get; set; }

    }
}
