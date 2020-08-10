using CloudChains.Spv.Lib.RPC.Specifications;

namespace CloudChains.Spv.Lib.RPC.Connector
{
    public interface IRpcConnector
    {
        T MakeRequest<T>(RpcMethods method, params object[] parameters);
    }
}
