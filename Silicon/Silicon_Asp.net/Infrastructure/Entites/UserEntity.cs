﻿using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Entites;

public class UserEntity : IdentityUser
{

    [ProtectedPersonalData]
    public string FirstName { get; set; } = null!;

    [ProtectedPersonalData]
    public string LastName { get; set; } = null!;

    public string? ProfileImage { get; set; } = "avatar.jpg";
    public bool IsExternal { get; set; }
    public string? Bio { get; set; }

    public int? AddressId { get; set; }
    public AddressEntity? Address { get; set; }

}
