using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "İLHAN" && gamer.LastName == "COŞKUN" && gamer.BirthYear == 1986 && gamer.TcNo == 12345678901)
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
 