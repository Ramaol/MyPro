using System;


namespace MyPro.Domain.ArticleCateguryAgg.Exeptions 
{
    public class DuplicatedCustomExeptios : Exception 
    {
        public DuplicatedCustomExeptios(string message) : base(message)
        {
            
        }

    }
}