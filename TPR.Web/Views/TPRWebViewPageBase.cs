using Abp.Web.Mvc.Views;

namespace TPR.Web.Views
{
    public abstract class TPRWebViewPageBase : TPRWebViewPageBase<dynamic>
    {

    }

    public abstract class TPRWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TPRWebViewPageBase()
        {
            LocalizationSourceName = TPRConsts.LocalizationSourceName;
        }
    }
}