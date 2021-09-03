using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.Application.Contract.Comment;

namespace MyPro.Presentation.Areas.Administrator.Pages.CommentManagement
{
    public class ReadComment : PageModel
    {
        public CommentViewModel Comment { get; set; }
        private readonly ICommentApplication _CommentApplication; 
        
        public ReadComment(ICommentApplication commentApplication)
        {
            _CommentApplication = commentApplication;
        }
        public void OnGet(long id)
        {
            _CommentApplication.ThisCommentIsRead(id);
            Comment = _CommentApplication.GetSingleComment(id);
        }
    }
}
