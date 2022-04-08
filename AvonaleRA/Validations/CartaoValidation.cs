using AvonaleRA.Models;
using FluentValidation;

namespace AvonaleRA.Validations
{
    public class CartaoValidation : AbstractValidator<Cartao>
    {
        public CartaoValidation()
        {
            RuleFor(x => x.numeroCartao).CreditCard();

            RuleFor(x => x.cvv)
                .NotEmpty()
                .NotNull()
                .Must(x => x.ToString().Length == 3);

            RuleFor(x => x.titular)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.bandeira)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.data_expiracao)
                .NotEmpty()
                .NotNull();
        }
    }
}
