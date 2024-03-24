using System;
using LegacyApp.Core.Interfaces;

namespace LegacyApp.Core.Validators.Users;

public class InputValidator : IInputValidator
{
    public bool ValidateName(string firstName, string lastName)
    {
        return !(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName));
    }

    public bool ValidateEmail(string email)
    {
        return email.Contains('@') && email.Contains('.');
    }

    public bool ValidateAge(DateTime dateOfBirth)
    {
        var now = DateTime.Now;
        var age = now.Year - dateOfBirth.Year;
        if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;
        return age >= 21;
    }
}