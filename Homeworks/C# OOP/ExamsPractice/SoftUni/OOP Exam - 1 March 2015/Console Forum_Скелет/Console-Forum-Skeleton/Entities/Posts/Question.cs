namespace ConsoleForum.Entities.Posts
{
    using ConsoleForum.Contracts;
    using System;

    public class Question : Post, IQuestion, IPost
    {
        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Collections.Generic.IList<IAnswer> Answers
        {
            get { throw new NotImplementedException(); }
        }
    }
}
