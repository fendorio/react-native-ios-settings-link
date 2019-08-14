using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Ios.Settings.Link.RNReactNativeIosSettingsLink
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeIosSettingsLinkModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeIosSettingsLinkModule"/>.
        /// </summary>
        internal RNReactNativeIosSettingsLinkModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeIosSettingsLink";
            }
        }
    }
}
