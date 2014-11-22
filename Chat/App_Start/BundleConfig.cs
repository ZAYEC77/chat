using System.Web;
using System.Web.Optimization;

namespace Chat
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/styles").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css",
                        "~/Css/ChatStyle.css",
                        "~/Content/bootstrap.css",
                        "~/Css/JQueryUI/themes/base/jquery.ui.all.css"
                        ));

            bundles.Add(new ScriptBundle("~/scripts").Include(
                        "~/Scripts/jquery-1.9.0.js",
                        "~/Scripts/ui/jquery.ui.core.js",
                        "~/Scripts/ui/jquery.ui.widget.js",
                        "~/Scripts/ui/jquery.ui.mouse.js",
                        "~/Scripts/ui/jquery.ui.draggable.js",
                        "~/Scripts/ui/jquery.ui.resizable.js",
                        "~/Scripts/jquery.signalR-1.0.0.js",
                        "~/Scripts/main.js"
                        )
            );

        }
    }
}