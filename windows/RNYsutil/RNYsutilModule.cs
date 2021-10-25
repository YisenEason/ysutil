using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Ysutil.RNYsutil
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNYsutilModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNYsutilModule"/>.
        /// </summary>
        internal RNYsutilModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNYsutil";
            }
        }
    }
}
