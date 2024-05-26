using Google.Cloud.SecretManager.V1;
using Microsoft.Extensions.Configuration;

namespace TerraDeGoshenAPI.Infrastructure
{
    public static class SecretManagerConfig
    {
        public static void AddSecretManager(IConfigurationBuilder configBuilder, string projectId)
        {
            var secretManagerClient = new SecretManagerServiceClientBuilder
            {
                CredentialsPath = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS")
            }.Build();

            // Add Firestore ProjectId Secret
            var projectIdSecretName = $"projects/{projectId}/secrets/FirestoreProjectId/versions/latest";
            var projectIdSecret = secretManagerClient.AccessSecretVersion(projectIdSecretName);
            var firestoreProjectId = projectIdSecret.Payload.Data.ToStringUtf8();

            // Add Firestore JsonCredentials Secret
            var jsonCredentialsSecretName = $"projects/{projectId}/secrets/FirestoreJsonCredentials/versions/latest";
            var jsonCredentialsSecret = secretManagerClient.AccessSecretVersion(jsonCredentialsSecretName);
            var firestoreJsonCredentials = jsonCredentialsSecret.Payload.Data.ToStringUtf8();

            var inMemorySettings = new Dictionary<string, string>
            {
                { "Firestore:ProjectId", firestoreProjectId },
                { "Firestore:JsonCredentials", firestoreJsonCredentials }
            };

            configBuilder.AddInMemoryCollection(inMemorySettings);
        }
    }
}