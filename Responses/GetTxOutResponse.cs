using CloudChains.Spv.Lib.Responses.SharedComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudChains.Spv.Lib.Responses
{
    public class GetTxOutResponse
    {
        public int Confirmations { get; set; }
        public decimal Value { get; set; }
        public ScriptPubKey ScriptPubKey { get; set; }
        public bool CoinBase { get; set; }
    }
}
