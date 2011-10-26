using System.Web.Mvc;
using Orchard.Environment.Extensions;
using Orchard.Mvc.Filters;
using Orchard.UI.Resources;

namespace Piedone.TargetBlank
{
    [OrchardFeature("Piedone.TargetBlank")]
    public class TargetBlankFilter : FilterProvider, IResultFilter
    {
        private readonly IResourceManager _resourceManager;

        public TargetBlankFilter(
            IResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        #region IResultFilter Members

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            // Should only run on a full view rendering result
            if (!(filterContext.Result is ViewResult))
                return;

            _resourceManager.Require("script", "TargetBlank").AtFoot();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }

        #endregion
    }
}