namespace .workspaces.Contracts.ABI

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes
open Nethereum.Web3
open Nethereum.RPC.Eth.DTOs
open Nethereum.Contracts.CQS
open Nethereum.Contracts.ContractHandlers
open Nethereum.Contracts
open System.Threading
open .workspaces.Contracts.ABI.ContractDefinition


    type ABIService (web3: Web3, contractAddress: string) =
    
        member val Web3 = web3 with get
        member val ContractHandler = web3.Eth.GetContractHandler(contractAddress) with get
    
        static member DeployContractAndWaitForReceiptAsync(web3: Web3, aBIDeployment: ABIDeployment, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> = 
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            web3.Eth.GetContractDeploymentHandler<ABIDeployment>().SendRequestAndWaitForReceiptAsync(aBIDeployment, cancellationTokenSourceVal)
        
        static member DeployContractAsync(web3: Web3, aBIDeployment: ABIDeployment): Task<string> =
            web3.Eth.GetContractDeploymentHandler<ABIDeployment>().SendRequestAsync(aBIDeployment)
        
        static member DeployContractAndGetServiceAsync(web3: Web3, aBIDeployment: ABIDeployment, ?cancellationTokenSource : CancellationTokenSource) = async {
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            let! receipt = ABIService.DeployContractAndWaitForReceiptAsync(web3, aBIDeployment, cancellationTokenSourceVal) |> Async.AwaitTask
            return new ABIService(web3, receipt.ContractAddress);
            }
    
        member this.EndGrantAuthenticationRequestAsync(endGrantAuthenticationFunction: EndGrantAuthenticationFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(endGrantAuthenticationFunction);
        
        member this.EndGrantAuthenticationRequestAndWaitForReceiptAsync(endGrantAuthenticationFunction: EndGrantAuthenticationFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(endGrantAuthenticationFunction, cancellationTokenSourceVal);
        
        member this.GrantInitialAuthenticationRequestAsync(grantInitialAuthenticationFunction: GrantInitialAuthenticationFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(grantInitialAuthenticationFunction);
        
        member this.GrantInitialAuthenticationRequestAndWaitForReceiptAsync(grantInitialAuthenticationFunction: GrantInitialAuthenticationFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(grantInitialAuthenticationFunction, cancellationTokenSourceVal);
        
        member this.RegisterProxyRequestAsync(registerProxyFunction: RegisterProxyFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(registerProxyFunction);
        
        member this.RegisterProxyRequestAndWaitForReceiptAsync(registerProxyFunction: RegisterProxyFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(registerProxyFunction, cancellationTokenSourceVal);
        
        member this.RenounceOwnershipRequestAsync(renounceOwnershipFunction: RenounceOwnershipFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        
        member this.RenounceOwnershipRequestAndWaitForReceiptAsync(renounceOwnershipFunction: RenounceOwnershipFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationTokenSourceVal);
        
        member this.RevokeAuthenticationRequestAsync(revokeAuthenticationFunction: RevokeAuthenticationFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(revokeAuthenticationFunction);
        
        member this.RevokeAuthenticationRequestAndWaitForReceiptAsync(revokeAuthenticationFunction: RevokeAuthenticationFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(revokeAuthenticationFunction, cancellationTokenSourceVal);
        
        member this.StartGrantAuthenticationRequestAsync(startGrantAuthenticationFunction: StartGrantAuthenticationFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(startGrantAuthenticationFunction);
        
        member this.StartGrantAuthenticationRequestAndWaitForReceiptAsync(startGrantAuthenticationFunction: StartGrantAuthenticationFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(startGrantAuthenticationFunction, cancellationTokenSourceVal);
        
        member this.TransferOwnershipRequestAsync(transferOwnershipFunction: TransferOwnershipFunction): Task<string> =
            this.ContractHandler.SendRequestAsync(transferOwnershipFunction);
        
        member this.TransferOwnershipRequestAndWaitForReceiptAsync(transferOwnershipFunction: TransferOwnershipFunction, ?cancellationTokenSource : CancellationTokenSource): Task<TransactionReceipt> =
            let cancellationTokenSourceVal = defaultArg cancellationTokenSource null
            this.ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationTokenSourceVal);
        
        member this.ContractsQueryAsync(contractsFunction: ContractsFunction, ?blockParameter: BlockParameter): Task<bool> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<ContractsFunction, bool>(contractsFunction, blockParameterVal)
            
        member this.DELAY_PERIODQueryAsync(dELAY_PERIODFunction: DELAY_PERIODFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<DELAY_PERIODFunction, BigInteger>(dELAY_PERIODFunction, blockParameterVal)
            
        member this.DelegateProxyImplementationQueryAsync(delegateProxyImplementationFunction: DelegateProxyImplementationFunction, ?blockParameter: BlockParameter): Task<string> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<DelegateProxyImplementationFunction, string>(delegateProxyImplementationFunction, blockParameterVal)
            
        member this.InitialAddressSetQueryAsync(initialAddressSetFunction: InitialAddressSetFunction, ?blockParameter: BlockParameter): Task<bool> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<InitialAddressSetFunction, bool>(initialAddressSetFunction, blockParameterVal)
            
        member this.NameQueryAsync(nameFunction: NameFunction, ?blockParameter: BlockParameter): Task<string> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameterVal)
            
        member this.OwnerQueryAsync(ownerFunction: OwnerFunction, ?blockParameter: BlockParameter): Task<string> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameterVal)
            
        member this.PendingQueryAsync(pendingFunction: PendingFunction, ?blockParameter: BlockParameter): Task<BigInteger> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<PendingFunction, BigInteger>(pendingFunction, blockParameterVal)
            
        member this.ProxiesQueryAsync(proxiesFunction: ProxiesFunction, ?blockParameter: BlockParameter): Task<string> =
            let blockParameterVal = defaultArg blockParameter null
            this.ContractHandler.QueryAsync<ProxiesFunction, string>(proxiesFunction, blockParameterVal)
            
    

