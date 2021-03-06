﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Rest.Generator.ClientModel
{
    /// <summary>
    /// Defines available parameter locations
    /// </summary>
    public enum ParameterLocation
    {
        None = 0,
        Path,
        Query,
        Header,
        Body,
        FormData
    }
}