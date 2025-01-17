// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// This connection type covers the generic ApiKey auth connection categories, for examples:
    /// AzureOpenAI:
    ///     Category:= AzureOpenAI
    ///     AuthType:= ApiKey (as type discriminator)
    ///     Credentials:= {ApiKey} as Microsoft.MachineLearning.AccountRP.Contracts.WorkspaceConnection.ApiKey
    ///     Target:= {ApiBase}
    ///
    /// CognitiveService:
    ///     Category:= CognitiveService
    ///     AuthType:= ApiKey (as type discriminator)
    ///     Credentials:= {SubscriptionKey} as Microsoft.MachineLearning.AccountRP.Contracts.WorkspaceConnection.ApiKey
    ///     Target:= ServiceRegion={serviceRegion}
    ///
    /// CognitiveSearch:
    ///     Category:= CognitiveSearch
    ///     AuthType:= ApiKey (as type discriminator)
    ///     Credentials:= {Key} as Microsoft.MachineLearning.AccountRP.Contracts.WorkspaceConnection.ApiKey
    ///     Target:= {Endpoint}
    ///
    /// Use Metadata property bag for ApiType, ApiVersion, Kind and other metadata fields
    /// </summary>
    public partial class ApiKeyAuthWorkspaceConnectionProperties : MachineLearningWorkspaceConnectionProperties
    {
        /// <summary> Initializes a new instance of ApiKeyAuthWorkspaceConnectionProperties. </summary>
        public ApiKeyAuthWorkspaceConnectionProperties()
        {
            AuthType = MachineLearningConnectionAuthType.ApiKey;
        }

        /// <summary> Initializes a new instance of ApiKeyAuthWorkspaceConnectionProperties. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="expiryOn"></param>
        /// <param name="metadata"> Any object. </param>
        /// <param name="target"></param>
        /// <param name="credentials"> Api key object for workspace connection credential. </param>
        internal ApiKeyAuthWorkspaceConnectionProperties(MachineLearningConnectionAuthType authType, MachineLearningConnectionCategory? category, DateTimeOffset? expiryOn, BinaryData metadata, string target, WorkspaceConnectionApiKey credentials) : base(authType, category, expiryOn, metadata, target)
        {
            Credentials = credentials;
            AuthType = authType;
        }

        /// <summary> Api key object for workspace connection credential. </summary>
        internal WorkspaceConnectionApiKey Credentials { get; set; }
        /// <summary> Gets or sets the credentials key. </summary>
        public string CredentialsKey
        {
            get => Credentials is null ? default : Credentials.Key;
            set
            {
                if (Credentials is null)
                    Credentials = new WorkspaceConnectionApiKey();
                Credentials.Key = value;
            }
        }
    }
}
