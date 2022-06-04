using System.Linq;
using System.Collections.Generic;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace ProjetoBiblioteca.Models
{
    public class UsuarioService
    {
        //LISTAR
        public List<Usuario> Listar()
        {
            using(BibliotecaContext bc = new BibliotecaContext()){
                return bc.Usuarios.ToList();
            }
        }
        public Usuario Listar(int Id)
        {
            using(BibliotecaContext bc = new BibliotecaContext()){
                return bc.Usuarios.Find(Id);
            }
        }
        //INCLUIR
        public void incluirUser(Usuario novoUser)
        {
            using(BibliotecaContext bc = new BibliotecaContext()){
                bc.Usuarios.Add(novoUser);
                bc.SaveChanges();
        }
        }
        //EDITAR
        public void editarUser(Usuario editUser)
        {
            using(BibliotecaContext bc = new BibliotecaContext()){
                
                Usuario u = Listar(editarUser.Id);

                u.Nome = editarUser.Nome;
                u.Login = editarUser.Login;
                u.Senha = editarUser.Senha;
                u.Tipo = editUser.Tipo;

                bc.SaveChanges();
            }

        }
        //EXCLUIR
        public void excluirUser(int Id)
        {
               using(BibliotecaContext bc = new BibliotecaContext()){
                   bc.Usuarios.Remove(Listar(Id));

                   bc.SaveChanges();
               }
        }
    }
}