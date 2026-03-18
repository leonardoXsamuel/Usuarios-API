using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios_API.Data;
using Usuarios_API.Model;

namespace users_API.service;

public class UserService
{
    // lista em memória que representará nosso banco de dados
    //public List<User> users = new List<User> { };

    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetAllUsers(int skip, int take)
    {

        var qtdeUsers = _context.Users.Count();

        if (qtdeUsers == 0)
        {
            throw new Exception("não há users registrados.");
            // futuramente inserir exception personalizada: UserNotFoundException
        }

        return _context.Users.Skip(skip).Take(take).ToList();
    }

    public User GetUserById(int id)
    {

        var ExistingUser = _context.Users.Find(id);

        if (!(id == ExistingUser.Id))
        {
            throw new Exception("não foi possível localizar o usuário.");
        }

        return ExistingUser;

    }

    public List<User> GetUsersByCity(string city)
    {
        List<User> ExistingUser = _context.Users
            .Where(u => u.Address.City == city)
            .ToList();

        if (ExistingUser == null || ExistingUser.Count == 0)
        {
            throw new Exception("não foi possível localizar o usuário.");
        }

        return ExistingUser;
    }

    public User GetUserByPhone(string phone)
    {
        var ExistingUser = _context.Users
            .FirstOrDefault(u => u.Phone == phone);

        if (ExistingUser == null)
        {
            throw new Exception("não foi possível localizar o usuário.");
        }

        return ExistingUser;
    }

    public User PostUser(User User)
    {
        if (User == null)
        {
            throw new Exception("User Inválido");
        }
        _context.Users.Add(User);
        _context.SaveChanges();

        return User;
    }

    public void PostListUsuarios(List<User> usuarios)
    {

        // melhor para validações complexas
        foreach (var item in usuarios)
        {
            /*
            if (string.IsNullOrEmpty(item.Nome))
            {
                throw new Exception("nome deve ser preenchido.");
            }
            */
            _context.Users.Add(item);
        }

        // versao LINQ => usuarios.ForEach(u => ListaUsuarios.Add(u));

    }

    public User PutUserById(int id, User User)
    {
        var ExistingUser = _context.Users.Find(id);

        if (string.IsNullOrWhiteSpace(User.Name))
        {
            throw new Exception("Nome é obrigatório.");
        }

        if (string.IsNullOrWhiteSpace(User.Email))
        {
            throw new Exception("Email é obrigatório.");
        }

        if (User.Address == null)
        {
            throw new Exception("Endereço é obrigatório.");
        }

        ExistingUser.Name = User.Name;
        ExistingUser.Phone = User.Phone;
        ExistingUser.Address = User.Address;
        ExistingUser.Email = User.Email;

        _context.SaveChanges();

        return ExistingUser;
    }

    public void DeleteUserById(int id)
    {

        var userDelete = _context.Users.Find(id);

        if (userDelete == null)
        {
            throw new Exception("O usuario requisitado para deletar nao existe.");
        }

        _context.Users.Remove(userDelete);
        _context.SaveChanges();
    }


}
