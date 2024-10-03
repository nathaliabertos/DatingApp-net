using System;
using API.Entities;

namespace API.Interfaces;

public interface iTokenServices
{
    string CreateToken(AppUser user);
}
