using CloudChains.Spv.Lib.CoinParameters.BitBay;


namespace CloudChains.Spv.Lib.Services.Coins.BitBay
{
    public class BitbayService : CoinService
    {
        public BitbayService()
        {

        }
		public BitbayService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword)
        { }

		public BitbayService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword, short rpcRequestTimeoutInSeconds)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword, rpcRequestTimeoutInSeconds)
        { }


		public BitBayConstants.Constants Constants => BitBayConstants.Constants.Instance;
    }
}
