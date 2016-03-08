using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackAPI.RPCMessages
{
    [RequestPath("emoji.list")]
    public class EmojiListResponse : Response
    {
        /// <summary>
        /// A dictionary where the keys are the emoji names and the values are the emoji urls
        /// </summary>
        public Dictionary<string, string> emoji;
    }
}
