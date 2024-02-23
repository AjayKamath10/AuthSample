namespace Sample.Models
{
    public class AppUserRole
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        
    }
}
