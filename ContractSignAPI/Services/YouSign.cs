using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractSignAPI.Services
{
    public class YouSign
    {

        #region Input

        public class FileInput
        {

            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "type")]
            public string Type { get; set; }

            [JsonProperty(PropertyName = "description")]
            public string Description { get; set; }

            [JsonProperty(PropertyName = "content")]
            public string Content { get; set; }

            public FileInput()
            {
                this.Name = string.Empty;
                this.Type = "signable";
                this.Content = string.Empty;
            }

        }

        public class ProcedureInput
        {

            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "description")]
            public string Description { get; set; }

            [JsonProperty(PropertyName = "expiresAt")]
            public DateTime? ExpiresAt { get; set; }

            [JsonProperty(PropertyName = "template")]
            public bool Template { get; set; }

            [JsonProperty(PropertyName = "ordered")]
            public bool Ordered { get; set; }

            [JsonProperty(PropertyName = "config")]
            public ProcedureConfig Config { get; set; }

            [JsonProperty(PropertyName = "members")]
            public List<MemberInput> Members { get; set; }

            [JsonProperty(PropertyName = "start")]
            public bool Start { get; set; }

            [JsonProperty(PropertyName = "relatedFilesEnable")]
            public bool RelatedFilesEnable { get; set; }

            [JsonProperty(PropertyName = "archive")]
            public bool Archive { get; set; }

        }

        public class MemberInput
        {

            [JsonProperty(PropertyName = "user")]
            public string User { get; set; }

            [JsonProperty(PropertyName = "type")]
            public string Type { get; set; }

            [JsonProperty(PropertyName = "firstname")]
            public string Firstname { get; set; }

            [JsonProperty(PropertyName = "lastname")]
            public string Lastname { get; set; }

            [JsonProperty(PropertyName = "email")]
            public string Email { get; set; }

            [JsonProperty(PropertyName = "phone")]
            public string Phone { get; set; }

            [JsonProperty(PropertyName = "position")]
            public int Position { get; set; }

            [JsonProperty(PropertyName = "fileObjects")]
            public List<FileObjectInput> FileObjects { get; set; }

            [JsonProperty(PropertyName = "procedure")]
            public string Procedure { get; set; }

            [JsonProperty(PropertyName = "operationLevel")]
            public string OperationLevel { get; set; } = "custom";

            [JsonProperty(PropertyName = "operationCustomModes")]
            public List<string> OperationCustomModes { get; set; } = new List<string>() { "sms" };

            [JsonProperty(PropertyName = "operationModeSmsConfig")]
            public ModeSmsConfiguration SmsConfiguration { get; set; }


            public MemberInput()
            {
                this.Type = "signer";
            }

        }

        public class FileObjectInput
        {

            [JsonProperty(PropertyName = "file")]
            public string File { get; set; }

            [JsonProperty(PropertyName = "page")]
            public int Page { get; set; }

            [JsonProperty(PropertyName = "position")]
            public string Position { get; set; }

            [JsonProperty(PropertyName = "fieldName")]
            public string FieldName { get; set; }

            [JsonProperty(PropertyName = "mention")]
            public string Mention { get; set; }

            [JsonProperty(PropertyName = "mention2")]
            public string Mention2 { get; set; }

            [JsonProperty(PropertyName = "Member")]
            public string Member { get; set; }

        }

        public class ModeSmsConfiguration
        {

            [JsonProperty(PropertyName = "content")]
            public string Content { get; set; }
        }

        public class StampInput
        {

            [JsonProperty(PropertyName = "file")]
            public string File { get; set; }

            [JsonProperty(PropertyName = "certificate")]
            public string Certificate { get; set; }

            [JsonProperty(PropertyName = "fileObjects")]
            public FileObjectInput[] FileObjects { get; set; }

            [JsonProperty(PropertyName = "signImage")]
            public string SignImage { get; set; }

            [JsonProperty(PropertyName = "config")]
            public StampConfig Config { get; set; }

        }

        #endregion

        #region Output

        public class ErrorOutput
        {

            [JsonProperty(PropertyName = "type")]
            public string Type { get; set; }

            [JsonProperty(PropertyName = "title")]
            public string Title { get; set; }

            [JsonProperty(PropertyName = "detail")]
            public string Detail { get; set; }

        }

        public class ProcedureOutput
        {

            [JsonProperty(PropertyName = "id")]
            public string Id { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "description")]
            public string Description { get; set; }

            [JsonProperty(PropertyName = "createdAt")]
            public DateTime? CreateAt { get; set; }

            [JsonProperty(PropertyName = "updatedAt")]
            public DateTime? UpdatedAt { get; set; }

            [JsonProperty(PropertyName = "expiresAt")]
            public DateTime? ExpiresAt { get; set; }

            [JsonProperty(PropertyName = "status")]
            public string Status { get; set; }

            [JsonProperty(PropertyName = "creator")]
            public string Creator { get; set; }

            [JsonProperty(PropertyName = "creatorFirstname")]
            public string CreatorFirstName { get; set; }

            [JsonProperty(PropertyName = "creatorLastname")]
            public string CreatorLastName { get; set; }

            [JsonProperty(PropertyName = "company")]
            public string Company { get; set; }

            [JsonProperty(PropertyName = "template")]
            public bool Template { get; set; }

            [JsonProperty(PropertyName = "ordered")]
            public bool Ordered { get; set; }

            [JsonProperty(PropertyName = "parent")]
            public string Parent { get; set; }

            [JsonProperty(PropertyName = "members")]
            public List<MemberOutput> Members { get; set; }

        }

        public class MemberOutput
        {

            [JsonProperty(PropertyName = "id")]
            public string Id { get; set; }

            [JsonProperty(PropertyName = "user")]
            public string User { get; set; }

            [JsonProperty(PropertyName = "type")]
            public string Type { get; set; }

            [JsonProperty(PropertyName = "firstname")]
            public string FirstName { get; set; }

            [JsonProperty(PropertyName = "lastname")]
            public string LastName { get; set; }

            [JsonProperty(PropertyName = "email")]
            public string Email { get; set; }

            [JsonProperty(PropertyName = "phone")]
            public string Phone { get; set; }

            [JsonProperty(PropertyName = "position")]
            public int Position { get; set; }

            [JsonProperty(PropertyName = "createdAt")]
            public DateTime? CreatedAt { get; set; }

            [JsonProperty(PropertyName = "updatedAt")]
            public DateTime? UpdatedAt { get; set; }

            [JsonProperty(PropertyName = "status")]
            public string Status { get; set; }

            [JsonProperty(PropertyName = "filesObjects")]
            public List<FileObjectInput> FilesObjects { get; set; }

            [JsonProperty(PropertyName = "comment")]
            public string Comment { get; set; }

        }

        public class FileObjectOuput
        {

            [JsonProperty(PropertyName = "id")]
            public string Id { get; set; }

            [JsonProperty(PropertyName = "files")]
            public FileOutput Files { get; set; }

            [JsonProperty(PropertyName = "page")]
            public int Page { get; set; }

            [JsonProperty(PropertyName = "position")]
            public string Position { get; set; }

            [JsonProperty(PropertyName = "filename")]
            public string FielName { get; set; }

            [JsonProperty(PropertyName = "mention")]
            public string Mention { get; set; }

            [JsonProperty(PropertyName = "createdAt")]
            public DateTime? CreatedAt { get; set; }

            [JsonProperty(PropertyName = "updatedat")]
            public DateTime? UpdatedAt { get; set; }

            [JsonProperty(PropertyName = "executedAt")]
            public DateTime? ExecutedAt { get; set; }

        }

        public class FileOutput
        {

            [JsonProperty(PropertyName = "id")]
            public string Id { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "type")]
            public string Type { get; set; }

            [JsonProperty(PropertyName = "contentType")]
            public string ContentType { get; set; }

            [JsonProperty(PropertyName = "description")]
            public string Description { get; set; }

            [JsonProperty(PropertyName = "createdAt")]
            public DateTime? CreatedAt { get; set; }

            [JsonProperty(PropertyName = "updatedAt")]
            public DateTime? UpdatedAt { get; set; }

            [JsonProperty(PropertyName = "company")]
            public string Company { get; set; }

            [JsonProperty(PropertyName = "creator")]
            public string Creator { get; set; }
        }

        public class StampOutput
        {

            [JsonProperty(PropertyName = "id")]
            public string Id { get; set; }

            [JsonProperty(PropertyName = "file")]
            public string File { get; set; }

            [JsonProperty(PropertyName = "certificate")]
            public string Certificate { get; set; }

            [JsonProperty(PropertyName = "createdAt")]
            public DateTime? CreatedAt { get; set; }

            [JsonProperty(PropertyName = "updatedAt")]
            public DateTime? UpdatedAt { get; set; }

            [JsonProperty(PropertyName = "finishedAt")]
            public string FinishedAt { get; set; }

            [JsonProperty(PropertyName = "company")]
            public string Company { get; set; }

            [JsonProperty(PropertyName = "status")]
            public string Status { get; set; }

        }

        #endregion

        #region UI

        public class SignatureUIInput
        {

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("logo")]
            public string Logo { get; set; }

            [JsonProperty("languages")]
            public List<string> Language { get; set; } = new List<string>() { "fr" };

            [JsonProperty("defaultLanguage")]
            public string DefaultLanguage { get; set; } = "fr";

            [JsonProperty("signImageTypesAvailable")]
            public List<string> SignImageTypesAvailable { get; set; } = new List<string>() { "name", "draw" };

            [JsonProperty("enableHeaderBar")]
            public bool EnableHeaderBar { get; set; } = true;

            [JsonProperty("enableHeaderBarSignAs")]
            public bool EnableHeaderBarSignAs { get; set; } = true;

            [JsonProperty("enableSidebar")]
            public bool EnableSidebar { get; set; } = true;

            [JsonProperty("enableMemberList")]
            public bool EnableMemberList { get; set; } = false;

            [JsonProperty("enableDocumentList")]
            public bool EnableDocumentList { get; set; } = true;

            [JsonProperty("enableDocumentDownload")]
            public bool EnableDocumentDownload { get; set; } = false;

            [JsonProperty("enableActivities")]
            public bool EnableActivities { get; set; } = true;

            [JsonProperty("authenticationPopup")]
            public bool AuthenticationPopup { get; set; } = false;

            [JsonProperty("fonts")]
            public List<string> Fonts { get; set; } = new List<string>() { "Roboto" };

            [JsonProperty("style")]
            public string Style { get; set; }

            [JsonProperty("redirectCancel")]
            public RedirectionInput RedirectCancel { get; set; }

            [JsonProperty("redirectError")]
            public RedirectionInput RedirectError { get; set; }

            [JsonProperty("redirectSuccess")]
            public RedirectionInput RedirectSuccess { get; set; }

            [JsonProperty("createdAt")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("updatedAt")]
            public DateTime UpdatedAt { get; set; }

        }

        public class LabelInput
        {

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("language")]
            public string Language { get; set; }

        }

        public class RedirectionInput
        {

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("target")]
            public string Target { get; set; }

            [JsonProperty("auto")]
            public bool Auto { get; set; }
        }

        public class SignatureUIOutput
        {

            public string Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public DateTime CreatedAt { get; set; }
        }


        #endregion

        #region Webhooks

        public class StampFinishedWebHookOutput
        {

            [JsonProperty(PropertyName = "serverStamp")]
            public StampWebHookOutput Stamp { get; set; }

            [JsonProperty(PropertyName = "file")]
            public FileOutput File { get; set; }

            [JsonProperty(PropertyName = "eventName")]
            public string EventName { get; set; }

        }

        public class StampWebHookOutput
        {

            [JsonProperty(PropertyName = "id")]
            public string Id { get; set; }

            [JsonProperty(PropertyName = "file")]
            public FileOutput File { get; set; }

            [JsonProperty(PropertyName = "certificate")]
            public string Certificate { get; set; }

            [JsonProperty(PropertyName = "createdAt")]
            public DateTime? CreatedAt { get; set; }

            [JsonProperty(PropertyName = "updatedAt")]
            public DateTime? UpdatedAt { get; set; }

            [JsonProperty(PropertyName = "finishedAt")]
            public string FinishedAt { get; set; }

            [JsonProperty(PropertyName = "company")]
            public string Company { get; set; }

            [JsonProperty(PropertyName = "status")]
            public string Status { get; set; }

        }

        public class ProcedureWebHookOutput
        {

            [JsonProperty(PropertyName = "procedure")]
            public ProcedureOutput Procedure { get; set; }

            [JsonProperty(PropertyName = "member")]
            public MemberOutput Member { get; set; }

            [JsonProperty(PropertyName = "eventName")]
            public string EventName { get; set; }

            [JsonProperty(PropertyName = "comment")]
            public string Comment { get; set; }
        }

        #endregion

        #region Shared

        public class ProcedureConfig
        {

            [JsonProperty(PropertyName = "webhook")]
            public ProcedureConfigWebhook Weebhook { get; set; }
        }

        public class StampConfig
        {

            [JsonProperty(PropertyName = "webhook")]
            public StampConfigWebhook Weebhook { get; set; }
        }

        public class ProcedureConfigWebhook
        {

            [JsonProperty(PropertyName = "procedure.started")]
            public ConfigWebhookTemplate[] ProcedureStarted { get; set; }

            [JsonProperty(PropertyName = "procedure.finished")]
            public ConfigWebhookTemplate[] ProcedureFinished { get; set; }

            [JsonProperty(PropertyName = "procedure.refused")]
            public ConfigWebhookTemplate[] ProcedureRefused { get; set; }

            [JsonProperty(PropertyName = "procedure.expired")]
            public ConfigWebhookTemplate[] ProcedureExpired { get; set; }

            [JsonProperty(PropertyName = "procedure.deleted")]
            public ConfigWebhookTemplate[] ProcedureDeleted { get; set; }

            [JsonProperty(PropertyName = "member.started")]
            public ConfigWebhookTemplate[] MemberStarted { get; set; }

            [JsonProperty(PropertyName = "member.finished")]
            public ConfigWebhookTemplate[] MemberFinished { get; set; }

            [JsonProperty(PropertyName = "comment.created")]
            public ConfigWebhookTemplate[] CommentCreated { get; set; }

        }

        public class StampConfigWebhook
        {

            [JsonProperty(PropertyName = "server_stamp.finished")]
            public ConfigWebhookTemplate[] StampFinished { get; set; }

        }

        public class ConfigWebhookTemplate
        {

            [JsonProperty(PropertyName = "url")]
            public string Url { get; set; }

            [JsonProperty(PropertyName = "method")]
            public string Method { get; set; }

            [JsonProperty(PropertyName = "headers")]
            public Dictionary<string, string> Headers { get; set; }

        }

        #endregion

    }
}
