namespace wharehouse_pattern_dbs.Roles;

public class ConcellorFactory : RolesFactory
{
    public override IRoles CreateRole()
    {
        return new Concellor();
    }
}