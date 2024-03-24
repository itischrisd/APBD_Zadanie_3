using System;

namespace LegacyApp.Core.Interfaces;

public interface IInputValidator
{
    public bool ValidateAge(DateTime dateOfBirth);
    public bool ValidateEmail(string email);
    public bool ValidateName(string firstName, string lastName);
}