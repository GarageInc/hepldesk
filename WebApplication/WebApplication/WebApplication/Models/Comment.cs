﻿namespace WebApplication.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Comment: BaseModel.BaseModel
    {
        [Display(Name = "Автор")]
        public virtual ApplicationUser Author { get; set; }

        [Display(Name = "ID Автора")]
        public virtual string AuthorId { get; set; }

        [Display(Name = "Рейтинг")]
        public virtual int Karma { get; set; }

        [Display(Name = "Текст")]
        public virtual string Text { get; set; }

        [Display(Name = "Первый уровень")]
        public virtual int? ParentId { get; set; } //Идентификатор родительской новости
        
        [Display(Name = "ID заявки")]
        public virtual int? RequestId { get; set; }

        [Display(Name = "Заявка")]
        [ForeignKey("RequestId")]
        public virtual Request Request { get; set; }
    }
}