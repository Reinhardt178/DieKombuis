using System;
using System.Collections.Generic;

namespace DieKombuis.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CellNr { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Kombuis { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}