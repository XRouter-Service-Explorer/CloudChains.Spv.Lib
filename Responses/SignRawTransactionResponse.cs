using System;
using System.Collections.Generic;
using System.Text;

namespace CloudChains.Spv.Lib.Responses
{
    public class SignRawTransactionResponse
    {
        public string Hex { get; set; }
        public bool Complete { get; set; }
    }
}
