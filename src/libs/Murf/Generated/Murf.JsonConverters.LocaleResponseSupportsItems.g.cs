#nullable enable

namespace Murf.JsonConverters
{
    /// <inheritdoc />
    public sealed class LocaleResponseSupportsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Murf.LocaleResponseSupportsItems>
    {
        /// <inheritdoc />
        public override global::Murf.LocaleResponseSupportsItems Read(
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
                        return global::Murf.LocaleResponseSupportsItemsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Murf.LocaleResponseSupportsItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Murf.LocaleResponseSupportsItems);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Murf.LocaleResponseSupportsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Murf.LocaleResponseSupportsItemsExtensions.ToValueString(value));
        }
    }
}
