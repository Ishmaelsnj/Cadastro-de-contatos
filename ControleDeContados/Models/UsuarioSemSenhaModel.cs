﻿using ControleDeContados.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContados.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do usuário!!")]

        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o login do usuário!!")]

        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do usuário")]
        [EmailAddress(ErrorMessage = "O email informado é inválido")]
        
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o perfil do usuário")]

        public PerfilEnum? Perfil { get; set; }
      
    }
}
