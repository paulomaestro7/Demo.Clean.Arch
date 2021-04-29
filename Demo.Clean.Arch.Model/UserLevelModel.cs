using System.Collections.Generic;

namespace Demo.Clean.Arch.Model
{
    public class UserLevelModel
    {
        public UserLevelModel()
        {
            User = new HashSet<UserModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<UserModel> User { get; set; }
    }
}
