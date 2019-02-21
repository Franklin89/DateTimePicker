using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace DateTimePicker
{
    public class CustomModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(DateTime) || context.Metadata.ModelType == typeof(DateTime?))
            {
                return new DateTimeModelBinder();
            }

            return null;
        }
    }
}
