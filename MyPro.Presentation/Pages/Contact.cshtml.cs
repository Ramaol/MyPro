using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.Application.Contract.Comment;

namespace MyPro.Presentation.Pages
{
    public class Contact : PageModel
    {
        
        public ContactModel ContactModel { get; set; }
        private readonly ICommentApplication _CommentApplication;

        public Contact(ICommentApplication commentApplication)
        {
           _CommentApplication = commentApplication;
        } 

        public void OnGet()
        {
            
        }

        public RedirectToPageResult OnPost(ContactModel command)
        {
            _CommentApplication.Create(command);
            return RedirectToPage("./Contact");     
        }
    }
}
