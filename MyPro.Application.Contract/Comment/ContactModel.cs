using System;
using System.ComponentModel.DataAnnotations;

namespace MyPro.Application.Contract.Comment
{
    public class ContactModel
    {
        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MinLength(3 , ErrorMessage = "حداقل طول نام ۳ کاراکتر است")]  
        [MaxLength(100 , ErrorMessage ="حداکثر طول نام ۱۰۰ کاراکتر است")]      
        public string Name { get; set; }
        
        [EmailAddress(ErrorMessage ="مقدار وارد شده ایمیل صحیح نیست")]
        public String Email { get; set; }
        public string Message { get; set; }
    }
}
