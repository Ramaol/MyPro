using System;
using System.Collections.Generic;

namespace MyPro.Domain.CommentAgg
{
    public interface ICommentRepository
    {
        void Add(Comment comment);
        List<Comment> List();
        Comment GetComment(long id);
        void Save();
    }
}
