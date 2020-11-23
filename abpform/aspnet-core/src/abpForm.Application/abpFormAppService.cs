using System;
using System.Collections.Generic;
using System.Text;
using abpForm.Localization;
using Volo.Abp.Application.Services;

namespace abpForm
{
    /* Inherit your application services from this class.
     */
    public abstract class abpFormAppService : ApplicationService
    {
        protected abpFormAppService()
        {
            LocalizationResource = typeof(abpFormResource);
        }
    }
}
