using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTestes.Dominio.ModuloTeste
{
    public class ValidadorTeste : AbstractValidator<Teste>
    {
        public ValidadorTeste()
        {
            RuleFor(x => x.Serie)
               .NotEmpty().NotNull();

            RuleFor(x => x.Disciplina)
                .NotEmpty().NotNull();

        }
    }
}
