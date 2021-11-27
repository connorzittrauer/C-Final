using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ExcitingVirtualPetCore
{
    public class PetClassConverter : JsonConverter<Pet>
    {
        enum TypeDiscriminator
        {

            Cat = 1,
            Dog = 2,
            Bird = 3,
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(Pet).IsAssignableFrom(typeToConvert);
        }

        public override Pet
           Read(
                ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            if (!reader.Read()
                    || reader.TokenType != JsonTokenType.PropertyName
                    || reader.GetString() != "TypeDiscriminator")
            {
                throw new JsonException();
            }

            if (!reader.Read() || reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException();
            }

            Pet baseClass;
            TypeDiscriminator typeDiscriminator = (TypeDiscriminator)reader.GetInt32();
            switch (typeDiscriminator)
            {
                case TypeDiscriminator.Cat:
                    if (!reader.Read() || reader.GetString() != "TypeValue")
                    {
                        throw new JsonException();
                    }
                    if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }
                    baseClass = (Cat)JsonSerializer.Deserialize(ref reader, typeof(Cat));
                    break;
                case TypeDiscriminator.Dog:
                    if (!reader.Read() || reader.GetString() != "TypeValue")
                    {
                        throw new JsonException();
                    }
                    if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }
                    baseClass = (Dog)JsonSerializer.Deserialize(ref reader, typeof(Dog));
                    break;
                case TypeDiscriminator.Bird:
                    if (!reader.Read() || reader.GetString() != "TypeValue")
                    {
                        throw new JsonException();
                    }
                    if (!reader.Read() || reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }
                    baseClass = (Bird)JsonSerializer.Deserialize(ref reader, typeof(Bird));
                    break;


                default:
                    throw new NotSupportedException();
            }

            if (!reader.Read() || reader.TokenType != JsonTokenType.EndObject)
            {
                throw new JsonException();
            }

            return baseClass;
        }

        public override void Write(
            Utf8JsonWriter writer,
            Pet value,
            JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            if (value is Cat derivedA)
            {
                writer.WriteNumber("TypeDiscriminator", (int)TypeDiscriminator.Cat);
                writer.WritePropertyName("TypeValue");
                JsonSerializer.Serialize(writer, derivedA);
            }
            else if (value is Dog derivedB)
            {
                writer.WriteNumber("TypeDiscriminator", (int)TypeDiscriminator.Dog);
                writer.WritePropertyName("TypeValue");
                JsonSerializer.Serialize(writer, derivedB);
            }
            else if (value is Bird derivedC)
            {
                writer.WriteNumber("TypeDiscriminator", (int)TypeDiscriminator.Bird);
                writer.WritePropertyName("TypeValue");
                JsonSerializer.Serialize(writer, derivedC);
            }
            else
            {
                throw new NotSupportedException();
            }

            writer.WriteEndObject();

        }
    }
}
