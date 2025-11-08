using EntityLayer.Concreta;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz");
            RuleFor(x => x.Writertitle).NotEmpty().WithMessage("Ünvan kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Litfen 50 karakterden fazla değer girişi yapmayın");
        }
    }
}
