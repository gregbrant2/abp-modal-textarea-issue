using abpForm.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abpForm.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class abpFormController : AbpController
    {
        protected abpFormController()
        {
            LocalizationResource = typeof(abpFormResource);
        }
    }
}