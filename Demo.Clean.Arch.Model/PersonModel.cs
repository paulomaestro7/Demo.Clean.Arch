using System.Collections.Generic;

namespace Demo.Clean.Arch.Model
{
    public class PersonModel
    {
        public PersonModel()
        {
            User = new HashSet<UserModel>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<UserModel> User { get; set; }
    }
}
