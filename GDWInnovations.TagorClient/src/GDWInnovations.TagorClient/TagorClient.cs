using GDWInnovations.TagorClient.Api;
using GDWInnovations.TagorClient.Client;
using Microsoft.Extensions.Logging;

namespace GDWInnovations.TagorClient
{
    public interface ITagorClient
    {
        public IActionsApi Actions { get; }
        public ICodeApi Code { get; }
        public IConfigApi Config { get; }
        public IDocumentApi Document { get; }
        public IDossierApi Dossier { get; }
        public IDossierlijnApi Dossierlijn { get; }
        public ILoginApi Login { get; }
        public IMessageApi Message { get; }
        public IPartyApi Party { get; }
        public IPayApi Pay { get; }
        public ISolvencyReportApi SolvencyReport { get; }
        public ITagorServiceApi Service { get; }
        public IUserApi User { get; }
    }

    internal class TagorClient : ITagorClient
    {
        public IActionsApi Actions { get; }
        public ICodeApi Code { get; }
        public IConfigApi Config { get; }
        public IDocumentApi Document { get; }
        public IDossierApi Dossier { get; }
        public IDossierlijnApi Dossierlijn { get; }
        public ILoginApi Login { get; }
        public IMessageApi Message { get; }
        public IPartyApi Party { get; }
        public IPayApi Pay { get; }
        public ISolvencyReportApi SolvencyReport { get; }
        public ITagorServiceApi Service { get; }
        public IUserApi User { get; }

        public TagorClient(ILoggerFactory loggerFactory, IReadableTagorConfiguration config, TagorRetryConfiguration retryConfiguration)
        {
            // Same merge the generated Api constructors do, then one shared ApiClient carrying the retry settings
            config = TagorConfiguration.MergeConfigurations(GlobalConfiguration.Instance, config);
            var client = new ApiClient(config.BasePath, retryConfiguration);
            client.SetLogger(loggerFactory);

            Actions = new ActionsApi(client, client, config);
            Code = new CodeApi(client, client, config);
            Config = new ConfigApi(client, client, config);
            Document = new DocumentApi(client, client, config);
            Dossier = new DossierApi(client, client, config);
            Dossierlijn = new DossierlijnApi(client, client, config);
            Login = new LoginApi(client, client, config);
            Message = new MessageApi(client, client, config);
            Party = new PartyApi(client, client, config);
            Pay = new PayApi(client, client, config);
            SolvencyReport = new SolvencyReportApi(client, client, config);
            Service = new TagorServiceApi(client, client, config);
            User = new UserApi(client, client, config);
        }
    }
}
