namespace AppMeeting.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new List<UserInfo>();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Engin Carta", Email = "engin@info.com", Phone = "123", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Barış Yurt", Email = "baris@info.com", Phone = "102334", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Caner Artık", Email = "caner@info.com", Phone = "853", WillAttend = false });
        }
        public static List<UserInfo> Users { get { return _users; } }

        public static void CreateUser(UserInfo user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
