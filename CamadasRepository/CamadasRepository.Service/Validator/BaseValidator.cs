using CamadasRepository.Domain.Entities;
using CamadasRepository.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CamadasRepository.Service.Validator
{
    public class BaseValidator<T> where T : class
    {
        public virtual void IsValid(T item)
        {
            if (item is User)
            {
                new UserValidator().IsValid(item as User);
            }
        }
    }
}
