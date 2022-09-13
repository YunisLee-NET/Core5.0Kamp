using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class BlogValidation:AbstractValidator<Blog>
    {
        public BlogValidation()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Bloq başlığı doldurulmalıdır.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Bloq məzmunu doldurulmalıdır.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Bloq şəkli doldurulmalıdır.");
            RuleFor(x => x.BlogTitle).MaximumLength(200).WithMessage("Maksimum 200 simvoldan istifadə olunmalıdır.");
            RuleFor(x => x.BlogTitle).MinimumLength(6).WithMessage("6 simvoldan çox məlumat əlavə edin.");
        }
    }
}
