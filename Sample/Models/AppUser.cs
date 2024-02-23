namespace Sample.Models
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public List<AppUserRole> AppUserRoles { get; set; } = new List<AppUserRole>();
    }
}
