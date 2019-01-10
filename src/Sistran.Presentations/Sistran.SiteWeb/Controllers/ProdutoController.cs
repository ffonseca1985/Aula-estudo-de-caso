using Newtonsoft.Json;
using Sistran.SharedKernel.Constants;
using Sistran.SiteWeb.Helpers;
using Sistran.SiteWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sistran.SiteWeb.Controllers
{
    [ValidateInput(false)]
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {
            if (TempData["msgTokenInvalido"] != null)
                ViewBag.msgTokenInvalido = TempData["msgTokenInvalido"];

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> IndexMVC()
        {
            string idToken;
            string msg = string.Empty;

            if (!HttpHelper.TryGetCookie(out idToken, "idToken", Request))
                msg = "Favor gerar um token!";

            var vm = await HttpHelper.GetClient<List<ProdutoViewModel>>(UrlServices.GestaoProduto + "produto/token/" + idToken);

            if (vm == null || !vm.Any())
                msg = "Token expirado, favor gerar outro novamente!";

            if (msg != string.Empty)
            {
                TempData["msgTokenInvalido"] = msg;
                return RedirectToAction("Index");
            }

            return View("Index", vm);
        }

        [HttpGet]
        public ActionResult Table(string produtos)
        {
            var result = JsonConvert.DeserializeObject<List<ProdutoViewModel>>(produtos);
            return PartialView(result);
        }
    }
}