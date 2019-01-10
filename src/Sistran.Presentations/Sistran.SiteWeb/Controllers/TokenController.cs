using Sistran.SharedKernel.Constants;
using Sistran.SiteWeb.Helpers;
using Sistran.SiteWeb.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sistran.SiteWeb.Controllers
{
    public class TokenController : Controller
    {
        [HttpPost]
        public async Task<JsonResult> Index()
        {
            var vm = await HttpHelper.PostClient<TokenViewModel>(UrlServices.GestaoProduto + "token");

            HttpHelper.SetTokenCookie("idToken", vm.Id, Response);
            HttpHelper.SetTokenCookie("dataEspiracao", vm.DataExpiracao.ToString("dd/MM/yyyy hh:mm"), Response);

            return Json(vm);
        }

        [HttpGet]
        public JsonResult Get()
        {
            string idToken;
            string dataEspiracao;

            HttpHelper.TryGetCookie(out idToken, "idToken", Request);
            HttpHelper.TryGetCookie(out dataEspiracao, "dataEspiracao", Request);

            var vm = new TokenViewModel()
            {
                Id = idToken,
                DataExpiracao = dataEspiracao == string.Empty ? DateTime.Now : Convert.ToDateTime(dataEspiracao)
            };

            return Json(vm, JsonRequestBehavior.AllowGet);
        }
    }
}