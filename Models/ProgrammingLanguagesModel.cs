using System.Text.Json.Serialization;

namespace BidvestMobilitySurveyFrontEnd.Models;

public class ProgrammingLanguagesModel
{
    public string Id { get; set; } = null!;
    public string LanguageShortName { get; set; } = null!;
    public string LanguageFullName { get; set; } = null!;
    public string LanguageShortDescription { get; set; } = null!;
}
