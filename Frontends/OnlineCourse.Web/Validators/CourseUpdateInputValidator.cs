﻿using FluentValidation;
using OnlineCourse.Web.Models.Catalog;

namespace OnlineCourse.Web.Validators;

public class CourseUpdateInputValidator : AbstractValidator<CourseUpdateInput>
{
    public CourseUpdateInputValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("isim alanı boş olamaz");
        RuleFor(x => x.Description).NotEmpty().WithMessage("açıklama alanı boş olamaz");
        RuleFor(x => x.Feature.Duration).InclusiveBetween(1, int.MaxValue).WithMessage("süre alanı boş olamaz");

        RuleFor(x => x.Price).NotEmpty().WithMessage("fiyat alanı boş olamaz").ScalePrecision(2, 6).WithMessage("hatalı para formatı");
    }
}