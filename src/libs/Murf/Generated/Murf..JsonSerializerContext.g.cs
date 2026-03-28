
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Murf
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Murf.JsonConverters.PronunciationDetailTypeJsonConverter),

            typeof(global::Murf.JsonConverters.PronunciationDetailTypeNullableJsonConverter),

            typeof(global::Murf.JsonConverters.GenerateSpeechRequestModelVersionJsonConverter),

            typeof(global::Murf.JsonConverters.GenerateSpeechRequestModelVersionNullableJsonConverter),

            typeof(global::Murf.JsonConverters.ApiVoiceGenderJsonConverter),

            typeof(global::Murf.JsonConverters.ApiVoiceGenderNullableJsonConverter),

            typeof(global::Murf.JsonConverters.LocaleResponseSupportsItemsJsonConverter),

            typeof(global::Murf.JsonConverters.LocaleResponseSupportsItemsNullableJsonConverter),

            typeof(global::Murf.JsonConverters.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriorityJsonConverter),

            typeof(global::Murf.JsonConverters.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriorityNullableJsonConverter),

            typeof(global::Murf.JsonConverters.ApiJobResponseDubbingTypeJsonConverter),

            typeof(global::Murf.JsonConverters.ApiJobResponseDubbingTypeNullableJsonConverter),

            typeof(global::Murf.JsonConverters.ApiJobResponsePriorityJsonConverter),

            typeof(global::Murf.JsonConverters.ApiJobResponsePriorityNullableJsonConverter),

            typeof(global::Murf.JsonConverters.V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriorityJsonConverter),

            typeof(global::Murf.JsonConverters.V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriorityNullableJsonConverter),

            typeof(global::Murf.JsonConverters.ApiCreateProjectRequestDubbingTypeJsonConverter),

            typeof(global::Murf.JsonConverters.ApiCreateProjectRequestDubbingTypeNullableJsonConverter),

            typeof(global::Murf.JsonConverters.ApiProjectResponseDubbingTypeJsonConverter),

            typeof(global::Murf.JsonConverters.ApiProjectResponseDubbingTypeNullableJsonConverter),

            typeof(global::Murf.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.PronunciationDetailType), TypeInfoPropertyName = "PronunciationDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.PronunciationDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateSpeechStreamingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Murf.PronunciationDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.TextToSpeechStreamResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateSpeechRequestModelVersion), TypeInfoPropertyName = "GenerateSpeechRequestModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.WordDurationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Murf.WordDurationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ApiVoiceGender), TypeInfoPropertyName = "ApiVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.StyleDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ApiVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Murf.StyleDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.SpeechToSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.MurfApiTranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CharacterCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.Translation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.MurfApiTranslationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Murf.Translation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.AuthTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.LocaleResponseSupportsItems), TypeInfoPropertyName = "LocaleResponseSupportsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.LocaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Murf.LocaleResponseSupportsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.SourceLocaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority), TypeInfoPropertyName = "V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ApiJobResponseDubbingType), TypeInfoPropertyName = "ApiJobResponseDubbingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ApiJobResponsePriority), TypeInfoPropertyName = "ApiJobResponsePriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ApiJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority), TypeInfoPropertyName = "V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.DubApiDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.DubJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Murf.DubApiDetailResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ApiCreateProjectRequestDubbingType), TypeInfoPropertyName = "ApiCreateProjectRequestDubbingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ApiCreateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ApiProjectResponseDubbingType), TypeInfoPropertyName = "ApiProjectResponseDubbingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ApiProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GroupApiProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Murf.ApiProjectResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ApiUpdateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ConvertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingJobWithProjectIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.StreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.StreamResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.StreamResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.StreamResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.StreamResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Murf.ApiVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GetVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GetVoicesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GetVoicesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GetVoicesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ConvertResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ConvertResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ConvertResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ConvertResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ConvertResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.TranslateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.TranslateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.TranslateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.TranslateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.TranslateResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateTokenResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GenerateTokenResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Murf.LocaleResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListDestinationLanguagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListDestinationLanguagesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListDestinationLanguagesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListDestinationLanguagesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Murf.SourceLocaleResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListSourceLanguagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListSourceLanguagesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListSourceLanguagesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListSourceLanguagesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingJobResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingJobResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingJobResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingJobWithProjectIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingJobWithProjectIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingJobWithProjectIdResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingJobWithProjectIdResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GetStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GetStatusResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GetStatusResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.GetStatusResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingProjectResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.CreateDubbingProjectResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.ListResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.UpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.UpdateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.UpdateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Murf.UpdateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Murf.WordDurationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Murf.Translation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Murf.LocaleResponseSupportsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Murf.DubApiDetailResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Murf.ApiProjectResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Murf.ApiVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Murf.LocaleResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Murf.SourceLocaleResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}