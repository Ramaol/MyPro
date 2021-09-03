

namespace MyPro.Application.Contract.Comment
{
    public class CommentViewModel
    {   
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public bool IsRead { get; set; }
        public string CreationDate { get; set; }
        public string Message { get; set; }
    }
}