using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNModuleCustom
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNModuleCustomModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNModuleCustomModule"/>.
        /// </summary>
        internal RNModuleCustomModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNModuleCustom";
            }
        }
    }
}
