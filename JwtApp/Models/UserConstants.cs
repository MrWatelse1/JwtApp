using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApp.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        { 
            new UserModel(){ Username ="prince_admin", EmailAddress="ogbodoprince@gmail.com", Password="MyPass_w0rd", GivenName ="Prince", Surname ="Ogbodo", Role ="Administrator" },
            new UserModel(){Username ="jason_seller", EmailAddress="jason.seller@email.com", Password="MyPass_w0rd", GivenName="Jason", Surname="Bryant", Role="Seller" },
        };
    }
}
