
using System;

namespace MyPro.Domain.ProjectAgg 
{
    public class Project
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Image { get; private set; }
        public string ShortDescription { get; private set; }
        public string Content { get; private set; }
        public DateTime CreationDate { get; private set; }
        public bool IsDeleted { get; private set; }

        public Project(string title , string image , string shortDescription ,string content)
        {
            Title = title;
            Image= image;
            ShortDescription = shortDescription;
            Content = content;
            CreationDate = DateTime.Now;
            IsDeleted = false;
        }

        public void Edit(string title , string shortDescription , string image, string content)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            CreationDate = DateTime.Now;
        }

        public void Remove()
        {
            IsDeleted = true;
        }
        public void Activate()
        {
            IsDeleted = false;
        }
    }
}