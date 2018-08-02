using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomDomain
{
    public partial class DomDomain
    {
        /// <summary>
        /// Returns node's HTML markup.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-getOuterHTML"/>
        /// </summary>
        /// <param name="nodeId">Identifier of the node.</param>
        /// <param name="backendNodeId">Identifier of the backend node.</param>
        /// <param name="objectId">JavaScript object id of the node wrapper.</param>
        /// <returns></returns>
        public async Task<JObject> GetOuterHTMLAsync(int nodeId, string backendNodeId = null, string objectId = null)
        {
            return await CommandAsync("getOuterHTML", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("backendNodeId", backendNodeId), 
                 new KeyValuePair<string, object>("objectId", objectId)
                 );
        }
    }
}
