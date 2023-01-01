using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.Youoko
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;

        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest
                .DefineStyle("Youoko-Bootstrap")
                .SetUrl("~/Youoko/css/bootstrap.min.css", "~/Youoko/css/bootstrap.min.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("Youoko-Bootstrap-Addons")
                .SetUrl("~/Youoko/css/bootstrap.addons.css", "~/Youoko/css/bootstrap.addons.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("Youoko-Animations")
                .SetUrl("~/Youoko/css/animations.css", "~/Youoko/css/animations.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineStyle("Youoko-Main")
                .SetUrl("~/Youoko/css/main.css", "~/Youoko/css/main.css")
                .SetVersion("1.0.0");

            _manifest
                .DefineScript("Youoko-Main")
                .SetUrl("~/Youoko/js/main.js", "~/Youoko/js/main.js")
                .SetVersion("1.0.0");

            _manifest
                .DefineScript("Youoko-Compressed")
                .SetUrl("~/Youoko/js/compressed.js", "~/Youoko/js/compressed.js")
                .SetVersion("1.0.0");

            _manifest
                .DefineScript("Youoko-BootstrapAddons")
                .SetUrl("~/Youoko/js/bootstrap.addons.js", "~/Youoko/js/bootstrap.addons.js")
                .SetVersion("1.0.0");

            _manifest
                .DefineScript("Youoko-CustomModernizer")
                .SetUrl("~/Youoko/js/vendor/modernizer-custom.js", "~/Youoko/js/vendor/modernizer-custom.js")
                .SetVersion("1.0.0");
        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}
