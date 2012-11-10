using Orchard.Environment.Extensions;
using Orchard.UI.Resources;

namespace Piedone.TargetBlank
{
    [OrchardFeature("Piedone.TargetBlank")]
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineScript("TargetBlank").SetUrl("piedone-target-blank.js").SetDependencies("jQuery");
        }
    }
}
