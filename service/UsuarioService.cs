using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios_API.model;

namespace Usuarios_API.service
{
    public class UsuarioService
    {
        // lista em memória que representará nosso banco de dados
        public List<Usuario> usuarios = new List<Usuario> { };

        public List<Usuario> GetAllUsuarios()
        {

            if (usuarios.Count == 0)
            {
                throw new Exception("não há usuarios registrados.");
            }
            return usuarios;
        }

        public Usuario GetUsuarioById(int id)
        {

            var usuarioExistente = usuarios.FirstOrDefault(u => u.Id == id);

            if (!(id == usuarioExistente.Id))
            {
                throw new Exception("não foi possível localizar o usuário.");
            }

            return usuarios[usuarioExistente.Id];

        }

        public List<Usuario> GetUsuariosByCity(string city)
        {
            List<Usuario> usuarioExistente = usuarios
                .Where(u => u.Address.City == city)
                .ToList();

            if (usuarioExistente == null || usuarioExistente.Count == 0)
            {
                throw new Exception("não foi possível localizar o usuário.");
            }

            return usuarioExistente;
        }

        public Usuario GetUsuarioByPhone(string phone)
        {
            var usuarioExistente = usuarios
                .FirstOrDefault(u => u.Phone == phone);

            if (usuarioExistente == null)
            {
                throw new Exception("não foi possível localizar o usuário.");
            }

            return usuarioExistente;
        }

        public Usuario PostUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("Usuario Inválido");
            }
            usuarios.Add(usuario);

            return usuario;
        }

        public Usuario PutUsuarioById (int id, Usuario usuario)
        {
            var usuarioExistente = usuarios.FirstOrDefault(u => u.Id == id);

            if (string.IsNullOrWhiteSpace(usuario.Name))
            {
                throw new Exception("Nome é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(usuario.Email))
            {
                throw new Exception("Email é obrigatório.");
            }

            if (usuario.Address == null)
            {
                throw new Exception("Endereço é obrigatório.");
            }

            usuarioExistente.Name = usuario.Name;
            usuarioExistente.Phone = usuario.Phone;
            usuarioExistente.Address = usuario.Address;
            usuarioExistente.Email = usuario.Email;

            return usuarioExistente;
        }



    }
}
