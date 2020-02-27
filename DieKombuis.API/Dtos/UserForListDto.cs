using System;

namespace DieKombuis.API.Dtos
{
    public class UserForListDto
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
    }
}