namespace GDWInnovations.TagorClient.Constants
{
    /// <summary>
    /// Well-known Tagor code ids, used when reading or writing Tagor entities through the API.
    /// </summary>
    /// <remarks>
    /// All ids are strings, matching how the Tagor API exchanges them. The full code lists can be fetched
    /// from Tagor through the <c>Code/GetList</c> endpoint.
    /// </remarks>
    public static class TagorConstants
    {
        /// <summary>
        /// Party type ids (Tagor table <c>TPARSOORT</c>), identifying the role a party has in a dossier.
        /// </summary>
        public static class PartyType
        {
            /// <summary>Client (<c>KLANT</c>).</summary>
            public const string Klant = "9000000000000000001";

            /// <summary>Plaintiff (<c>AANLEGGER</c>).</summary>
            public const string Aanlegger = "9000000000000000002";

            /// <summary>Defendant (<c>VERWEERDER</c>).</summary>
            /// <remarks>Use this id for the defendant of a dossier, not <see cref="OrigineleVerweerder"/>.</remarks>
            public const string Verweerder = "9000000000000000003";

            /// <summary>Lawyer of the client (<c>ADV_CLNT</c>).</summary>
            public const string AdvClnt = "9000000000000000005";

            /// <summary>Fellow lawyer or bailiff (<c>CONFRATER</c>).</summary>
            public const string Confrater = "9000000000000000008";

            /// <summary>Billing party (<c>FACTURATIE</c>).</summary>
            public const string Facturatie = "9000000000000000031";

            /// <summary>Fellow lawyer or bailiff who owns the dossier (<c>CONFRATER_DOSSIER_VAN</c>).</summary>
            public const string ConfraterDossierVan = "9000000000000000037";

            /// <summary>Original defendant (<c>ORIGINELE_VERWEERDER</c>).</summary>
            public const string OrigineleVerweerder = "1540000000000000020";
        }

        /// <summary>
        /// Contact detail type ids (Tagor table <c>TQCOM</c>), used when adding contact details to a party
        /// (e.g. through <c>Party/AddContactDetail</c>).
        /// </summary>
        public static class ContactType
        {
            /// <summary>Email address.</summary>
            public const string Email = "9000000000000000004";

            /// <summary>Mobile phone number (code <c>MOBI</c>, "GSM - SMS").</summary>
            public const string Gsm = "9000000000000000007";
        }

        /// <summary>
        /// Dossier status ids (Tagor table <c>TQSTATUS</c>).
        /// </summary>
        public static class DossierStatus
        {
            /// <summary>Settled ("Geregeld").</summary>
            public const string Geregeld = "9000000000000000015";

            /// <summary>In execution ("In uitvoering").</summary>
            public const string InUitvoering = "9000000000000000419";
        }

        /// <summary>
        /// Dossier stage ids (Tagor table <c>TQSTATUS</c>, stadium).
        /// </summary>
        public static class DossierStadium
        {
            /// <summary>In execution by CFR ("In uitvoering bij CFR").</summary>
            public const string InUitvoeringBijCfr = "9000000000000000446";

            /// <summary>In execution by DW&amp;B ("In uitvoering bij DW&amp;B").</summary>
            public const string InUitvoeringBijDwb = "904750";

            /// <summary>Amicable phase ("Minnelijke fase"), first of two codes.</summary>
            /// <remarks>
            /// Tagor uses two stage codes for the amicable phase. To check whether a dossier is in the
            /// amicable phase, compare against both <see cref="MinnelijkeFase1"/> and <see cref="MinnelijkeFase2"/>.
            /// </remarks>
            public const string MinnelijkeFase1 = "364861";

            /// <summary>Amicable phase ("Minnelijke fase"), second of two codes.</summary>
            /// <remarks>See <see cref="MinnelijkeFase1"/>.</remarks>
            public const string MinnelijkeFase2 = "3820000000000000124";
        }

        /// <summary>
        /// Tagor merge field codes.
        /// </summary>
        public static class MergeFieldStatus
        {
            /// <summary>Language of the defendant.</summary>
            public const string VerweerderTaal = "M_0575";

            /// <summary>Language of the dossier.</summary>
            public const string DossierTaal = "M_0070";
        }

        /// <summary>
        /// Document group ids (Tagor table <c>TQDISGROEP</c>), as used in
        /// <see cref="Model.DsTDOCWebDsTDOCWebTtTDOCWebInner.TQDISGROEPId"/> and
        /// <see cref="Model.DsAttachmentWebDsAttachmentWebTtAttachmentWebInner.TQDISGROEPId"/>.
        /// </summary>
        /// <remarks>
        /// The full list can be fetched through the <c>Code/GetList</c> endpoint with context
        /// <c>{ "ContextKey": "table", "ContextValue": "TQSDISGROUP" }</c>.
        /// </remarks>
        public static class DocumentGroup
        {
            /// <summary>Titles (code <c>TIT</c>, "Titels").</summary>
            public const string Titels = "356757";

            /// <summary>CROS enforceable title (code <c>C_UITV</c>, "CROS: Uitvoerbare titel").</summary>
            public const string CrosUitvoerbareTitel = "4600000000000000021";

            /// <summary>
            /// Finance: extract from the administrative enforceable title
            /// (code <c>FINUAUT</c>, "Financiën - Uittreksel uit de administratieve uitvoerbare titel").
            /// </summary>
            public const string FinancienUittrekselAdministratieveUitvoerbareTitel = "3820000000000000221";
        }
    }
}
