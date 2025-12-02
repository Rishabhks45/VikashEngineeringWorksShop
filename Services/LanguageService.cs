namespace VikashEngineeringWorksShop.Services;

public class LanguageService
{
    public event Action? OnLanguageChanged;
    private string _currentLanguage = "en";

    public string CurrentLanguage 
    { 
        get => _currentLanguage;
        set
        {
            if (_currentLanguage != value)
            {
                _currentLanguage = value;
                OnLanguageChanged?.Invoke();
            }
        }
    }

    public bool IsEnglish => CurrentLanguage == "en";
    public bool IsHindi => CurrentLanguage == "hi";

    public void SetLanguage(string lang)
    {
        CurrentLanguage = lang;
    }
}

