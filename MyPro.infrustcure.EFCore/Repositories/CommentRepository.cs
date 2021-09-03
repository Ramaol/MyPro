using System;
using System.Collections.Generic;
using MyPro.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MyPro.infrustcure.EFCore.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BlogContext _Context;

        public CommentRepository(BlogContext context)
        {
            _Context = context;
        }
        public void Add(Comment comment)
        {
            _Context.Comments.Add(comment);
            _Context.SaveChanges();
        }

        public Comment GetComment(long id)
        {
            return _Context.Comments.FirstOrDefault( x => x.Id == id);
        }

        public List<Comment> List()
        {
            return _Context.Comments.OrderByDescending( x => x.Id).ToList();
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
