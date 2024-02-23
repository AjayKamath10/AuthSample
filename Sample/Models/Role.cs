namespace Sample.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public List<AppUserRole> AppUserRoles { get; set; } = new List<AppUserRole>();
    }
}
