#nullable enable

namespace Murf.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiVoiceGenderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Murf.ApiVoiceGender>
    {
        /// <inheritdoc />
        public override global::Murf.ApiVoiceGender Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Murf.ApiVoiceGenderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Murf.ApiVoiceGender)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Murf.ApiVoiceGender);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Murf.ApiVoiceGender value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Murf.ApiVoiceGenderExtensions.ToValueString(value));
        }
    }
}
