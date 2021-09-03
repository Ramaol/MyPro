using System;

namespace MyPro.Domain.CommentAgg {
    public class Comment {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Message { get; private set; }
        public string Email { get; private set; }
        public DateTime CreationDate { get; private set; }
        public bool IsRead { get; private set; }

        public Comment(string name , string message , string email)
        {
            Name = name; 
            Message = message;
            Email = email;
            CreationDate = DateTime.Now;
            IsRead = false;
        }

        public void ThisCommentRead()
        {
            IsRead = true;
        }
      
    }
}