using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace InvoiceApp.Localization
{
    public static class InvoiceAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(InvoiceAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(InvoiceAppLocalizationConfigurer).GetAssembly(),
                        "InvoiceApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
