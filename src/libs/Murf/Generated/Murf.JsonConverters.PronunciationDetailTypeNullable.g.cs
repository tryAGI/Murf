#nullable enable

namespace Murf.JsonConverters
{
    /// <inheritdoc />
    public sealed class PronunciationDetailTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Murf.PronunciationDetailType?>
    {
        /// <inheritdoc />
        public override global::Murf.PronunciationDetailType? Read(
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
                        return global::Murf.PronunciationDetailTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Murf.PronunciationDetailType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Murf.PronunciationDetailType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Murf.PronunciationDetailType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Murf.PronunciationDetailTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
