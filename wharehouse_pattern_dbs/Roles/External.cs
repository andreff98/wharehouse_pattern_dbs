using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Roles;

public class External : IRoles
{
    public string CreateRole()
    {
        return "external";
    }
}