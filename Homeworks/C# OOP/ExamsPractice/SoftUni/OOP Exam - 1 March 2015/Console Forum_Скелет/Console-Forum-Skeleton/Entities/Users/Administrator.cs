namespace ConsoleForum.Entities.Users
{
    using System;

    using ConsoleForum.Contracts;

    public class Administrator : User, IAdministrator, IUser
    {
        public Administrator(int id, string name, string password, string email)
            : base(id, name, password, email)
        {

        }
    }
}
