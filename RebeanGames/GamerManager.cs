using System;
using System.Collections.Generic;
using System.Text;

namespace RebeanGames
{
    class GamerManager : IGamerService
    {
        IUserValidationServices userValidationServices;
        private readonly IUserValidationServices userValidationServices;

     

        public void Add(Gamer gamer, IUserValidationServices userValidationServices)
        {
            if (userValidationServices(gamer) == true)
            {

            }
            Console.WriteLine("Kayıt Gerçekleşti");
        }

    

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncelledndi");
        }
    }
}
