using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace huzcodes.Endpoints.Attributes
{
    public class FileExtensionsAttribute(string[] extensions) : ValidationAttribute
    {
        private readonly string[] _extensions = extensions;

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {
                if (!IsFileExtensionValid(file)) return new ValidationResult(GetErrorMessage());
            }
            else
            {
                if (value is IFormFileCollection fileCollection)
                    foreach (var oFile in fileCollection)
                        if (!IsFileExtensionValid(oFile)) return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success!;
        }

        private bool IsFileExtensionValid(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName);

            if (!_extensions.Contains(extension)) return false;
            return true;
        }

        public static string GetErrorMessage() => $"This file extension is not allowed!";
    }
}
