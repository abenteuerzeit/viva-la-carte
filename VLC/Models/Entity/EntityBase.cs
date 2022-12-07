using System;
using System.ComponentModel.DataAnnotations;

namespace VLC.Models.Entity
{
    public abstract class EntityBase
    {
        [Required, Key]
        public int Id { get; set; }
    }
}

