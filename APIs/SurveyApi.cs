using BidvestMobilitySurveyFrontEnd.Models;
using Refit;
namespace BidvestMobilitySurveyFrontEnd.APIs;

public interface SurveyApi
{
    [Post("/api/v1/ProgrammingLanguages")]
    Task<ApiResponse<Response<ProgrammingLanguagesModel>>> AddProgrammingLanguage([Body(BodySerializationMethod.Serialized)]  ProgrammingLanguagesModel programming); 
    
    [Delete("/api/v1/ProgrammingLanguages/{id}")]
    Task<ApiResponse<Response<ProgrammingLanguagesModel>>> RemoveProgrammingLanguage( string id); 
    
    [Delete("/api/v1/ProgrammingLanguages/{id}")]
    Task<ApiResponse<Response<ProgrammingLanguagesModel>>> UpdateProgrammingLanguage( string id, ProgrammingLanguagesModel data);

    [Get("/api/v1/ProgrammingLanguages/Languages")]
    Task<ApiResponse<Response<List<ProgrammingLanguagesModel>>>> GetProgrammingLanguages();



    [Post("/api/v1/Survey")]
    Task<ApiResponse<Response<ProgrammingLanguagesModel>>> AddSurvey([Body(BodySerializationMethod.Serialized)] SurveyModel survey );

    [Delete("/api/v1/Survey/{id}")]
    Task<ApiResponse<Response<ProgrammingLanguagesModel>>> RemoveSurvey(string id);

    [Get("/api/v1/Survey/Surveys")]
    Task<ApiResponse<Response<List<SurveyModel>>>> GetSurveys();

}
