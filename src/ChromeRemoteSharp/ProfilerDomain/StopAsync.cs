using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.ProfilerDomain
{
    public partial class ProfilerDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler#method-stop"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StopAsync()
        {
            return await CommandAsync("stop");
        }
    }
}
