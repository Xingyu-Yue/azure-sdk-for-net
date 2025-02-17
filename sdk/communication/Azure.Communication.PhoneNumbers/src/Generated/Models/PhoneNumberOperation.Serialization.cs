// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    internal partial class PhoneNumberOperation
    {
        internal static PhoneNumberOperation DeserializePhoneNumberOperation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PhoneNumberOperationType operationType = default;
            PhoneNumberOperationStatus status = default;
            Optional<string> resourceLocation = default;
            DateTimeOffset createdDateTime = default;
            Optional<CommunicationError> error = default;
            string id = default;
            Optional<DateTimeOffset> lastActionDateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationType"u8))
                {
                    operationType = new PhoneNumberOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new PhoneNumberOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = CommunicationError.DeserializeCommunicationError(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastActionDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastActionDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new PhoneNumberOperation(operationType, status, resourceLocation.Value, createdDateTime, error.Value, id, Optional.ToNullable(lastActionDateTime));
        }
    }
}
