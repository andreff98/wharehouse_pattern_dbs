using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Roles;

public class Concellor : IRoles
{
    public string GetRoleName()
    {
        return "Concellor"; 
    }
}