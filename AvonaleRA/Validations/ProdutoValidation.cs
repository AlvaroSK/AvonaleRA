using AvonaleRA.Models;
using FluentValidation;

namespace AvonaleRA.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(x => x.nome)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.qtde_estoque)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.valor_unitario)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);


        }
    }
}
