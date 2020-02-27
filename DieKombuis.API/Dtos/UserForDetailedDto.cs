using System;
using System.Collections.Generic;
using DieKombuis.API.Models;

namespace DieKombuis.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CellNr { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Kombuis { get; set; }
        public bool IsAdmin { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotoForDetailedDto> Photos { get; set; }
    }
}