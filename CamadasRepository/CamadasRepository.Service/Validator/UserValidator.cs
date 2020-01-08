using CamadasRepository.Domain.Entities;
using CamadasRepository.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CamadasRepository.Service.Validator
{
    public class UserValidator : BaseValidator<User>
    {
        public override void IsValid(User item)
        {
            if (string.IsNullOrEmpty(item.Nome) || string.IsNullOrWhiteSpace(item.Nome))
            {
                throw new ArgumentException("O NOME não pode ser nulo");
            }
            else if (string.IsNullOrEmpty(item.Email) || string.IsNullOrWhiteSpace(item.Email))
            {
                throw new ArgumentException("O EMAIL não pode ser nulo");
            }
        }
    }
}
