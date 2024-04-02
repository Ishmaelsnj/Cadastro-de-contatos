using ControleDeContados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContados.Helper
{
   public interface ISessao
    {
        void CriarSessaoDoUsuario(UsuarioModel usuario );

        void RemoverSessaoDoUsuario();

        UsuarioModel BuscarSessaoDoUsuario();
    }
}
