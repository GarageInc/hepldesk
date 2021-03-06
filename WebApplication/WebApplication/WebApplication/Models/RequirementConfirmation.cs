﻿namespace WebApplication.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class RequirementConfirmation: BaseModel.BaseModel
    {
        [Display(Name = "Описание/Пожелания")]
        [Required(ErrorMessage = "Обязательно для заполнения!")]
        [MaxLength(200, ErrorMessage = "Превышена максимальная длина записи(200 символов)")]
        public virtual string Description { get; set; }

        [Display(Name = "Файл")]
        public virtual Document Document { get; set; }

        [Display(Name = "ID файла")]
        public virtual int? DocumentId { get; set; }

        [Display(Name = "Автор")]
        public virtual ApplicationUser Author { get; set; }

        [Display(Name = "ID Автора")]
        public virtual string AuthorId { get; set; }
        
        [Display(Name = "ID заявки на вывод средств")]
        public virtual int? RequirementId { get; set; }

        [Display(Name = "Заявка на вывод средств")]
        [ForeignKey("RequirementId")]
        public virtual Requirement Requirement { get; set; }
    }
}