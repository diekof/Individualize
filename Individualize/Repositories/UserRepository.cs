using System;
using System.Collections.Generic;
using System.Linq;
using Individualize.Models;

namespace Individualize.Repositories
{
    public static class UserRepository
    {
        public static Usuario Get(string username, string password)
        {
            var users = new List<Usuario>();
            users.Add(new Usuario { UsuarioId = 1, UsuarioLogin = "batman", UsuarioSenha = "batman", PerfilId = 1 });
            users.Add(new Usuario { UsuarioId = 2, UsuarioLogin = "robin", UsuarioSenha = "robin", PerfilId = 2 });
            return users.Where(x => x.UsuarioLogin.ToLower() == username.ToLower() && x.UsuarioSenha == password).FirstOrDefault();
        }
    }
}
