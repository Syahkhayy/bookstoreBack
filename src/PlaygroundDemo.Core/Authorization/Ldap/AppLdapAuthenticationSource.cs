using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using PlaygroundDemo.Authorization.Users;
using PlaygroundDemo.MultiTenancy;

namespace PlaygroundDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}