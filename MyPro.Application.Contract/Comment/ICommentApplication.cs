using System;
using System.Collections.Generic;

namespace MyPro.Application.Contract.Comment
{
    public interface ICommentApplication
    {
        void Create(ContactModel command);
        List<CommentViewModel> GetCommentViewModels();
        CommentViewModel GetSingleComment(long id);

        void ThisCommentIsRead(long id);
    }
}
