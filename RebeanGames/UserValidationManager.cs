using System;
using System.Collections.Generic;
using System.Text;

namespace RebeanGames
{
    class UserValidationManager : IUserValidationServices
    {
    

        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "Recep" && gamer.LastName == "Anık")
            {
                return true;


            }
            else
            {
                return false;
            }
        }
    }
}
