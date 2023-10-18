using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Roles;

public class Admin : IRoles
{
    public string CreateRole()
    {
        return "admin";
    }
}