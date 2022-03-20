namespace .workspaces.Contracts.ABI.ContractDefinition

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Numerics
open Nethereum.Hex.HexTypes
open Nethereum.ABI.FunctionEncoding.Attributes
open Nethereum.Web3
open Nethereum.RPC.Eth.DTOs
open Nethereum.Contracts.CQS
open Nethereum.Contracts
open System.Threading

    
    
    type ABIDeployment(byteCode: string) =
        inherit ContractDeploymentMessage(byteCode)
        
        static let BYTECODE = "0x"
        
        new() = ABIDeployment(BYTECODE)
        

        
    
    [<Function("endGrantAuthentication")>]
    type EndGrantAuthenticationFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "addr", 1)>]
            member val public Addr = Unchecked.defaultof<string> with get, set
        
    
    [<Function("grantInitialAuthentication")>]
    type GrantInitialAuthenticationFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "authAddress", 1)>]
            member val public AuthAddress = Unchecked.defaultof<string> with get, set
        
    
    [<Function("registerProxy", "address")>]
    type RegisterProxyFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("renounceOwnership")>]
    type RenounceOwnershipFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("revokeAuthentication")>]
    type RevokeAuthenticationFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "addr", 1)>]
            member val public Addr = Unchecked.defaultof<string> with get, set
        
    
    [<Function("startGrantAuthentication")>]
    type StartGrantAuthenticationFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "addr", 1)>]
            member val public Addr = Unchecked.defaultof<string> with get, set
        
    
    [<Function("transferOwnership")>]
    type TransferOwnershipFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "newOwner", 1)>]
            member val public NewOwner = Unchecked.defaultof<string> with get, set
        
    
    [<Function("contracts", "bool")>]
    type ContractsFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
        
    
    [<Function("DELAY_PERIOD", "uint256")>]
    type DELAY_PERIODFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("delegateProxyImplementation", "address")>]
    type DelegateProxyImplementationFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("initialAddressSet", "bool")>]
    type InitialAddressSetFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("name", "string")>]
    type NameFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("owner", "address")>]
    type OwnerFunction() = 
        inherit FunctionMessage()
    

        
    
    [<Function("pending", "uint256")>]
    type PendingFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
        
    
    [<Function("proxies", "address")>]
    type ProxiesFunction() = 
        inherit FunctionMessage()
    
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
        
    
    [<Event("OwnershipRenounced")>]
    type OwnershipRenouncedEventDTO() =
        inherit EventDTO()
            [<Parameter("address", "previousOwner", 1, true )>]
            member val PreviousOwner = Unchecked.defaultof<string> with get, set
        
    
    [<Event("OwnershipTransferred")>]
    type OwnershipTransferredEventDTO() =
        inherit EventDTO()
            [<Parameter("address", "previousOwner", 1, true )>]
            member val PreviousOwner = Unchecked.defaultof<string> with get, set
            [<Parameter("address", "newOwner", 2, true )>]
            member val NewOwner = Unchecked.defaultof<string> with get, set
        
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    [<FunctionOutput>]
    type ContractsOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("bool", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<bool> with get, set
        
    
    [<FunctionOutput>]
    type DELAY_PERIODOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type DelegateProxyImplementationOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
        
    
    [<FunctionOutput>]
    type InitialAddressSetOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("bool", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<bool> with get, set
        
    
    [<FunctionOutput>]
    type NameOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("string", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
        
    
    [<FunctionOutput>]
    type OwnerOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
        
    
    [<FunctionOutput>]
    type PendingOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("uint256", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<BigInteger> with get, set
        
    
    [<FunctionOutput>]
    type ProxiesOutputDTO() =
        inherit FunctionOutputDTO() 
            [<Parameter("address", "", 1)>]
            member val public ReturnValue1 = Unchecked.defaultof<string> with get, set
    

