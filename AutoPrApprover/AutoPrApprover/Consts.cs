using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrApprover
{
    public class Consts
    {
        public const string ApiUrl = "https://dev.azure.com/" +
            "{organizationName}/" +
            "{projectName}/" +
            "_apis/git/" +
            "repositories/{repository}/" +
            "pullRequests/{pullRequestId}/" +
            "reviewers/{reviewerId}" +
            "?api-version=6.0";

        public const string defaultReviewerId = ""; //Ömer faruk aydın
        public const string defaultOrganizationName = "fimple";
        public const string defaultProjectName = "Fi";

        public const string defaultPersonelAccessToken = "";//pat


        public const string ForeignTradeApiName = "Fi.ForeignTrade.Api";
        public const string ForeignTradeWebName = "Fi.Web.ForeignTrade";
        public const string ChequeApiName = "Fi.Cheque.Api";
        public const string ChequeWebName = "Fi.Web.Cheque";

        public const string ProjectSelectionString =
            "1. ForeignTrade.Api\n" +
            "2. ForeignTrade.Web\n" +
            "3. Cheque.Api\n" +
            "4. Cheque.Web\n";

        public const string InitializeString =
            "1. Hızlı Ayarlar\n" +
            "2. Ben Challange Seviyorum Kardeşim\n";

        public const string SelectProject = "Proje Seçiniz";

        public const string EnterPullRequest = "Pr Id'sini giriniz. (Pr url'nin sonundaki Id numarasını koymalısınız)";

        public const string EnterReviewerId = "Reviewer Id'sini giriniz";

        public const string EnterOrganizationName = "Orginization adını giriniz.";

        public const string EnterProjectName = "Proje Adını Giriniz";

        public const string EnterRepositoryName = "Repo Adını Giriniz";

        public const string EnterPersonelAccessToken = "Personel Access Token Giriniz.";

    }
}
