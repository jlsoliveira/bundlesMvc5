using System.Web;
using System.Web.Optimization;

namespace bundle
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //otimiza todos os arquivos que estão sendo referenciados aqui no código e os compata
            BundleTable.EnableOptimizations = true;

            //Pega todos os arquivos js e subdiretório do diretório que for passado
            bundles.Add(new ScriptBundle("~/comum").IncludeDirectory("~/Scripts/comum", "*.js", true));

            //iguinorando arquivos do diretório
            bundles.IgnoreList.Ignore("*.dbg.js");

            //Definindo oredem de renderização dos arquivos bules
            var ordermArquivosbundlesComum = new BundleFileSetOrdering("meusSicripts");
            ordermArquivosbundlesComum.Files.Add("setup.js");
            ordermArquivosbundlesComum.Files.Add("display.js");
            bundles.FileSetOrderList.Insert(0, ordermArquivosbundlesComum);


            //Inclusão de um unico arquivo.
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
