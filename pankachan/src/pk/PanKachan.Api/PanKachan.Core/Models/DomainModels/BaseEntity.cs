﻿using System;
using System.ComponentModel.DataAnnotations;
using PanKachan.Core.Models.DomainModels.Interfaces;

namespace PanKachan.Core.Models.DomainModels
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        [Required]
        [MaxLength(36, ErrorMessage = "The id must consist of 36 characters"), MinLength(36, ErrorMessage = "The id must consist of 36 characters")]
        public string Id { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
