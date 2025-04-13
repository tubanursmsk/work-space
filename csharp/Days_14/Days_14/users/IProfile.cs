using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_14.models;

namespace Days_14.users
{
    public interface IProfile
    {
        UserModel? UserPublicProfile(int uid);
        bool UserLogout(int uid);
    }
}
