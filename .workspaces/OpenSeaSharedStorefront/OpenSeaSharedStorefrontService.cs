using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using .workspaces.Contracts.OpenSeaSharedStorefront.ContractDefinition;

namespace .workspaces.Contracts.OpenSeaSharedStorefront
{
    public partial class OpenSeaSharedStorefrontService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, OpenSeaSharedStorefrontDeployment openSeaSharedStorefrontDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<OpenSeaSharedStorefrontDeployment>().SendRequestAndWaitForReceiptAsync(openSeaSharedStorefrontDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, OpenSeaSharedStorefrontDeployment openSeaSharedStorefrontDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<OpenSeaSharedStorefrontDeployment>().SendRequestAsync(openSeaSharedStorefrontDeployment);
        }

        public static async Task<OpenSeaSharedStorefrontService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, OpenSeaSharedStorefrontDeployment openSeaSharedStorefrontDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, openSeaSharedStorefrontDeployment, cancellationTokenSource);
            return new OpenSeaSharedStorefrontService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public OpenSeaSharedStorefrontService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        
        public Task<string> NameQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public Task<bool> InitialAddressSetQueryAsync(InitialAddressSetFunction initialAddressSetFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<InitialAddressSetFunction, bool>(initialAddressSetFunction, blockParameter);
        }

        
        public Task<bool> InitialAddressSetQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<InitialAddressSetFunction, bool>(null, blockParameter);
        }

        public Task<string> EndGrantAuthenticationRequestAsync(EndGrantAuthenticationFunction endGrantAuthenticationFunction)
        {
             return ContractHandler.SendRequestAsync(endGrantAuthenticationFunction);
        }

        public Task<TransactionReceipt> EndGrantAuthenticationRequestAndWaitForReceiptAsync(EndGrantAuthenticationFunction endGrantAuthenticationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(endGrantAuthenticationFunction, cancellationToken);
        }

        public Task<string> EndGrantAuthenticationRequestAsync(string addr)
        {
            var endGrantAuthenticationFunction = new EndGrantAuthenticationFunction();
                endGrantAuthenticationFunction.Addr = addr;
            
             return ContractHandler.SendRequestAsync(endGrantAuthenticationFunction);
        }

        public Task<TransactionReceipt> EndGrantAuthenticationRequestAndWaitForReceiptAsync(string addr, CancellationTokenSource cancellationToken = null)
        {
            var endGrantAuthenticationFunction = new EndGrantAuthenticationFunction();
                endGrantAuthenticationFunction.Addr = addr;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(endGrantAuthenticationFunction, cancellationToken);
        }

        public Task<string> RevokeAuthenticationRequestAsync(RevokeAuthenticationFunction revokeAuthenticationFunction)
        {
             return ContractHandler.SendRequestAsync(revokeAuthenticationFunction);
        }

        public Task<TransactionReceipt> RevokeAuthenticationRequestAndWaitForReceiptAsync(RevokeAuthenticationFunction revokeAuthenticationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(revokeAuthenticationFunction, cancellationToken);
        }

        public Task<string> RevokeAuthenticationRequestAsync(string addr)
        {
            var revokeAuthenticationFunction = new RevokeAuthenticationFunction();
                revokeAuthenticationFunction.Addr = addr;
            
             return ContractHandler.SendRequestAsync(revokeAuthenticationFunction);
        }

        public Task<TransactionReceipt> RevokeAuthenticationRequestAndWaitForReceiptAsync(string addr, CancellationTokenSource cancellationToken = null)
        {
            var revokeAuthenticationFunction = new RevokeAuthenticationFunction();
                revokeAuthenticationFunction.Addr = addr;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(revokeAuthenticationFunction, cancellationToken);
        }

        public Task<BigInteger> PendingQueryAsync(PendingFunction pendingFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PendingFunction, BigInteger>(pendingFunction, blockParameter);
        }

        
        public Task<BigInteger> PendingQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var pendingFunction = new PendingFunction();
                pendingFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PendingFunction, BigInteger>(pendingFunction, blockParameter);
        }

        public Task<bool> ContractsQueryAsync(ContractsFunction contractsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractsFunction, bool>(contractsFunction, blockParameter);
        }

        
        public Task<bool> ContractsQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var contractsFunction = new ContractsFunction();
                contractsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ContractsFunction, bool>(contractsFunction, blockParameter);
        }

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public Task<string> RenounceOwnershipRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> DelegateProxyImplementationQueryAsync(DelegateProxyImplementationFunction delegateProxyImplementationFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DelegateProxyImplementationFunction, string>(delegateProxyImplementationFunction, blockParameter);
        }

        
        public Task<string> DelegateProxyImplementationQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DelegateProxyImplementationFunction, string>(null, blockParameter);
        }

        public Task<string> ProxiesQueryAsync(ProxiesFunction proxiesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ProxiesFunction, string>(proxiesFunction, blockParameter);
        }

        
        public Task<string> ProxiesQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var proxiesFunction = new ProxiesFunction();
                proxiesFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ProxiesFunction, string>(proxiesFunction, blockParameter);
        }

        public Task<string> StartGrantAuthenticationRequestAsync(StartGrantAuthenticationFunction startGrantAuthenticationFunction)
        {
             return ContractHandler.SendRequestAsync(startGrantAuthenticationFunction);
        }

        public Task<TransactionReceipt> StartGrantAuthenticationRequestAndWaitForReceiptAsync(StartGrantAuthenticationFunction startGrantAuthenticationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(startGrantAuthenticationFunction, cancellationToken);
        }

        public Task<string> StartGrantAuthenticationRequestAsync(string addr)
        {
            var startGrantAuthenticationFunction = new StartGrantAuthenticationFunction();
                startGrantAuthenticationFunction.Addr = addr;
            
             return ContractHandler.SendRequestAsync(startGrantAuthenticationFunction);
        }

        public Task<TransactionReceipt> StartGrantAuthenticationRequestAndWaitForReceiptAsync(string addr, CancellationTokenSource cancellationToken = null)
        {
            var startGrantAuthenticationFunction = new StartGrantAuthenticationFunction();
                startGrantAuthenticationFunction.Addr = addr;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(startGrantAuthenticationFunction, cancellationToken);
        }

        public Task<string> RegisterProxyRequestAsync(RegisterProxyFunction registerProxyFunction)
        {
             return ContractHandler.SendRequestAsync(registerProxyFunction);
        }

        public Task<string> RegisterProxyRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RegisterProxyFunction>();
        }

        public Task<TransactionReceipt> RegisterProxyRequestAndWaitForReceiptAsync(RegisterProxyFunction registerProxyFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerProxyFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RegisterProxyRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RegisterProxyFunction>(null, cancellationToken);
        }

        public Task<BigInteger> DELAY_PERIODQueryAsync(DELAY_PERIODFunction dELAY_PERIODFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DELAY_PERIODFunction, BigInteger>(dELAY_PERIODFunction, blockParameter);
        }

        
        public Task<BigInteger> DELAY_PERIODQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DELAY_PERIODFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> GrantInitialAuthenticationRequestAsync(GrantInitialAuthenticationFunction grantInitialAuthenticationFunction)
        {
             return ContractHandler.SendRequestAsync(grantInitialAuthenticationFunction);
        }

        public Task<TransactionReceipt> GrantInitialAuthenticationRequestAndWaitForReceiptAsync(GrantInitialAuthenticationFunction grantInitialAuthenticationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantInitialAuthenticationFunction, cancellationToken);
        }

        public Task<string> GrantInitialAuthenticationRequestAsync(string authAddress)
        {
            var grantInitialAuthenticationFunction = new GrantInitialAuthenticationFunction();
                grantInitialAuthenticationFunction.AuthAddress = authAddress;
            
             return ContractHandler.SendRequestAsync(grantInitialAuthenticationFunction);
        }

        public Task<TransactionReceipt> GrantInitialAuthenticationRequestAndWaitForReceiptAsync(string authAddress, CancellationTokenSource cancellationToken = null)
        {
            var grantInitialAuthenticationFunction = new GrantInitialAuthenticationFunction();
                grantInitialAuthenticationFunction.AuthAddress = authAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantInitialAuthenticationFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }
    }
}
