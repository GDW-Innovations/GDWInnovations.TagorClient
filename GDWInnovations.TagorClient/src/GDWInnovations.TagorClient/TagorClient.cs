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

        public TagorClient(ILoggerFactory loggerFactory, IReadableTagorConfiguration config)
        {
            Actions = new ActionsApi(config, loggerFactory);

            Code = new CodeApi(config, loggerFactory);

            Config = new ConfigApi(config, loggerFactory);

            Document = new DocumentApi(config, loggerFactory);

            Dossier = new DossierApi(config, loggerFactory);

            Dossierlijn = new DossierlijnApi(config, loggerFactory);

            Login = new LoginApi(config, loggerFactory);

            Message = new MessageApi(config, loggerFactory);

            Party = new PartyApi(config, loggerFactory);

            Pay = new PayApi(config, loggerFactory);

            SolvencyReport = new SolvencyReportApi(config, loggerFactory);
            Service = new TagorServiceApi(config, loggerFactory);

            User = new UserApi(config, loggerFactory);
        }
    }
}
