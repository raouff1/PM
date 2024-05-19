using Infrastructure.Models.Users;

namespace WebApp.Models;

public class AccountDetailsViewModel
{
    public AcountBasicInfo BasicInfo { get; set; } = null!;
    public AcountAdressInfo AddressInfo { get; set; } = null!;
}
