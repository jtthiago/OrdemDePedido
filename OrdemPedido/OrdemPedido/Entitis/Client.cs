using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdemPedido.Entitis
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client(string clienteName, string email, DateTime birthDate)
        {
            Name = clienteName;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name + ", (" + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email; 
        }
    }
}