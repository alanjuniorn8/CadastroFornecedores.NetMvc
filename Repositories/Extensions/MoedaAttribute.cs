﻿using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Localization;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CadastroFornecedores.Repositories.Extensions
{
    public class MoedaAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            try
            {
                var moeda = Convert.ToDecimal(value, new CultureInfo("pt-BR"));
            }
            catch
            {
                return new ValidationResult("Moeda em formato invalído");
            }

            return ValidationResult.Success;
        }

    }

    public class MoedaAttributeAdapter : AttributeAdapterBase<MoedaAttribute>
    {

        public MoedaAttributeAdapter(MoedaAttribute moedaAttribute, IStringLocalizer stringLocalizer) 
            : base(moedaAttribute, stringLocalizer)
        {

        }

        public override void AddValidation(ClientModelValidationContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            MergeAttribute(context.Attributes, "data-val", "true");
            MergeAttribute(context.Attributes, "data-val-number", GetErrorMessage(context));]MergeAttribute(context.Attributes, "data-val-moeda", GetErrorMessage(context));

        }

        public override string GetErrorMessage(ModelValidationContextBase validationContext)
        {
            return "Moeda em formao inválido";
        }

    }

    public class MoedaValidationAttributeAdapterProvider : IValidationAttributeAdapterProvider
    {

        private readonly IValidationAttributeAdapterProvider _baseProvider = new ValidationAttributeAdapterProvider();
        public IAttributeAdapter GetAttributeAdapter(ValidationAttribute attribute, IStringLocalizer stringLocalizer)
        {
            if (attribute is MoedaAttribute moedaAttribute) 
            {
                return new MoedaAttributeAdapter(moedaAttribute, stringLocalizer);
            }

            return _baseProvider.GetAttributeAdapter(attribute, stringLocalizer);
        }
    }
}
