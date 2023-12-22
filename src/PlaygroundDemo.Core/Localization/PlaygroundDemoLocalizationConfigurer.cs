using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PlaygroundDemo.Localization
{
    public static class PlaygroundDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    PlaygroundDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PlaygroundDemoLocalizationConfigurer).GetAssembly(),
                        "PlaygroundDemo.Localization.PlaygroundDemo"
                    )
                )
            );
        }
    }
}