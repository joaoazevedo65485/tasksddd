using System;
using System.ComponentModel.DataAnnotations;

namespace EventsManager.Domain.Entity
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
    }
}
