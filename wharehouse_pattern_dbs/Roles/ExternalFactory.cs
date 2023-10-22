namespace wharehouse_pattern_dbs.Roles;

public class ExternalFactory : RolesFactory
{
    public override IRoles CreateRole()
    {
        return new External();
    }
}