using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
	public class WriterValidation:AbstractValidator<Writer>
	{
		public WriterValidation()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad və soyadınızı daxil edin");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail ünvanını daxil edin");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifrənizi daxil edin");
			RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Şəkil linkini əlavə edin");
		}
	}
}
