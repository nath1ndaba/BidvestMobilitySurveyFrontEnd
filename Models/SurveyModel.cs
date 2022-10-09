namespace BidvestMobilitySurveyFrontEnd.Models
{
    public class SurveyModel
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; } = null!;
        public string? Surname { get; set; } = null!;
        public string ProgrammingLanguage { get; set; }
        //public ProgrammingLanguagesModel ProgrammingLanguages { get; set; }
        //private string? _programmingLanguage;
        //public string? ProgrammingLanguage
        //{
        //    get =>_programmingLanguage ?? ProgrammingLanguages.LanguageFullName; 
        //    set {
        //        if(_programmingLanguage == value) return;
        //        _programmingLanguage = value; }
        //}

    }
}
