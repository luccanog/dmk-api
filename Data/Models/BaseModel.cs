using System;
using System.ComponentModel.DataAnnotations;
namespace DMKit.WebApi
{
    public class BaseModel
    {
        public Guid Id { get; set; }

        public BaseModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
