namespace code_task
{
    internal class User : Account
    {
        private string password;
        private static int _id = 1;

        public string FullName { get; set; }
        public int Id { get; }
        public string Email { get; set; }

        public string Password
        {
            get => password;
            set
            {
                if (PasswordChecker(value))
                {
                    password = value;
                }
                else
                {
                    throw new IncorrectPaswordException("ERROR 404");
                }
            }
        }

        public User(string fullname, string email, string password, int id)
        {
            FullName = fullname;
            Email = email;
            Password = password;
            Id = ++_id;
        }

        public override bool PasswordChecker(string password)
        {
            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"id: {Id} - FullName: {FullName} - Email: {Email}");
        }
    }
}
