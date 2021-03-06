﻿using System.Web;
using System.Web.Optimization;

namespace Chat
{
    public class BundleConfig
    {
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
                        "~/Content/ChatStyle.css",
                        "~/Content/bootstrap.css"
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