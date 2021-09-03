using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.Application.Contract.Comment;

namespace MyPro.Presentation.Areas.Administrator.Pages.CommentManagement
{
    public class List : PageModel
    {
        public List<CommentViewModel> Comments { get; set; }
        private readonly ICommentApplication _CommentApplication;

        public List(ICommentApplication commentApplication)
        {
            _CommentApplication = commentApplication;
        }
        
        public void OnGet()
        {
            Comments = _CommentApplication.GetCommentViewModels();
        }

    }
}
