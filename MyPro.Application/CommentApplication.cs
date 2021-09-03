using System.Globalization;
using System.Collections.Generic;
using MyPro.Application.Contract.Comment;
using MyPro.Domain.CommentAgg;

namespace MyPro.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository _CommentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            _CommentRepository = commentRepository;
        }
        public void Create(ContactModel command)
        {
            var comment = new Comment(command.Name , command.Message , command.Email);
            _CommentRepository.Add(comment);            
        }

        public List<CommentViewModel> GetCommentViewModels()
        {
            var Comments = _CommentRepository.List();
            var Results = new List<CommentViewModel>();
            
            foreach (var item in Comments)
            {
                Results.Add(new CommentViewModel {
                    Id = item.Id ,
                    Name = item.Name , 
                    CreationDate = item.CreationDate.ToString(CultureInfo.InvariantCulture) ,
                    IsRead = item.IsRead ,
                    Email = item.Email 
                });
            }

            return Results;
        }

        public CommentViewModel GetSingleComment(long id)
        {
            var comment =  _CommentRepository.GetComment(id);
            return new CommentViewModel {
                Id = comment.Id , 
                Message = comment.Message , 
                CreationDate = comment.CreationDate.ToString(CultureInfo.InvariantCulture) , 
                Email = comment.Email , 
                Name = comment.Name , 
                IsRead = comment.IsRead
            };
        }

        public void ThisCommentIsRead(long id)
        {
            var comment = _CommentRepository.GetComment(id);
            comment.ThisCommentRead();
            _CommentRepository.Save();
        }
    }
}
