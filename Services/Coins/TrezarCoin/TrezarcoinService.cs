using CloudChains.Spv.Lib.CoinParameters.TrezarCoin;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace CloudChains.Spv.Lib.Services.Coins.TrezarCoin
{

    public class TrezarcoinService : CoinService
    {
        public TrezarcoinService()
        {

        }
		public TrezarcoinService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword)
        { }

		public TrezarcoinService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword, short rpcRequestTimeoutInSeconds)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword, rpcRequestTimeoutInSeconds)
        { }


		public TrezarCoinConstants.Constants Constants => TrezarCoinConstants.Constants.Instance;
    }
}
