namespace wharehouse_pattern_dbs.Roles;

public class AdminFactory : RolesFactory
{
    public override IRoles CreateRole()
    {
        return new Admin();
    }
}