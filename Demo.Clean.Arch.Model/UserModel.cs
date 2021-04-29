namespace Demo.Clean.Arch.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public int IdPerson { get; set; }
        public int IdUserLevel { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public virtual PersonModel Person { get; set; }
        public virtual UserLevelModel UserLevel { get; set; }
    }
}
