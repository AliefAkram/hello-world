Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts.ContractHandlers
Imports Nethereum.Contracts
Imports System.Threading
Imports .workspaces.Contracts.ABI.ContractDefinition
Namespace .workspaces.Contracts.ABI


    Public Partial Class ABIService
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal aBIDeployment As ABIDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of ABIDeployment)().SendRequestAndWaitForReceiptAsync(aBIDeployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal aBIDeployment As ABIDeployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of ABIDeployment)().SendRequestAsync(aBIDeployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal aBIDeployment As ABIDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of ABIService)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, aBIDeployment, cancellationTokenSource)
            Return New ABIService(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    
        Public Function EndGrantAuthenticationRequestAsync(ByVal endGrantAuthenticationFunction As EndGrantAuthenticationFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of EndGrantAuthenticationFunction)(endGrantAuthenticationFunction)
        
        End Function

        Public Function EndGrantAuthenticationRequestAndWaitForReceiptAsync(ByVal endGrantAuthenticationFunction As EndGrantAuthenticationFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of EndGrantAuthenticationFunction)(endGrantAuthenticationFunction, cancellationToken)
        
        End Function

        
        Public Function EndGrantAuthenticationRequestAsync(ByVal [addr] As String) As Task(Of String)
        
            Dim endGrantAuthenticationFunction = New EndGrantAuthenticationFunction()
                endGrantAuthenticationFunction.Addr = [addr]
            
            Return ContractHandler.SendRequestAsync(Of EndGrantAuthenticationFunction)(endGrantAuthenticationFunction)
        
        End Function

        
        Public Function EndGrantAuthenticationRequestAndWaitForReceiptAsync(ByVal [addr] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim endGrantAuthenticationFunction = New EndGrantAuthenticationFunction()
                endGrantAuthenticationFunction.Addr = [addr]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of EndGrantAuthenticationFunction)(endGrantAuthenticationFunction, cancellationToken)
        
        End Function
        Public Function GrantInitialAuthenticationRequestAsync(ByVal grantInitialAuthenticationFunction As GrantInitialAuthenticationFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of GrantInitialAuthenticationFunction)(grantInitialAuthenticationFunction)
        
        End Function

        Public Function GrantInitialAuthenticationRequestAndWaitForReceiptAsync(ByVal grantInitialAuthenticationFunction As GrantInitialAuthenticationFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of GrantInitialAuthenticationFunction)(grantInitialAuthenticationFunction, cancellationToken)
        
        End Function

        
        Public Function GrantInitialAuthenticationRequestAsync(ByVal [authAddress] As String) As Task(Of String)
        
            Dim grantInitialAuthenticationFunction = New GrantInitialAuthenticationFunction()
                grantInitialAuthenticationFunction.AuthAddress = [authAddress]
            
            Return ContractHandler.SendRequestAsync(Of GrantInitialAuthenticationFunction)(grantInitialAuthenticationFunction)
        
        End Function

        
        Public Function GrantInitialAuthenticationRequestAndWaitForReceiptAsync(ByVal [authAddress] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim grantInitialAuthenticationFunction = New GrantInitialAuthenticationFunction()
                grantInitialAuthenticationFunction.AuthAddress = [authAddress]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of GrantInitialAuthenticationFunction)(grantInitialAuthenticationFunction, cancellationToken)
        
        End Function
        Public Function RegisterProxyRequestAsync(ByVal registerProxyFunction As RegisterProxyFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of RegisterProxyFunction)(registerProxyFunction)
        
        End Function

        Public Function RegisterProxyRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of RegisterProxyFunction)
        
        End Function

        Public Function RegisterProxyRequestAndWaitForReceiptAsync(ByVal registerProxyFunction As RegisterProxyFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of RegisterProxyFunction)(registerProxyFunction, cancellationToken)
        
        End Function

        Public Function RegisterProxyRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of RegisterProxyFunction)(Nothing, cancellationToken)
        
        End Function
        Public Function RenounceOwnershipRequestAsync(ByVal renounceOwnershipFunction As RenounceOwnershipFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of RenounceOwnershipFunction)(renounceOwnershipFunction)
        
        End Function

        Public Function RenounceOwnershipRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of RenounceOwnershipFunction)
        
        End Function

        Public Function RenounceOwnershipRequestAndWaitForReceiptAsync(ByVal renounceOwnershipFunction As RenounceOwnershipFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of RenounceOwnershipFunction)(renounceOwnershipFunction, cancellationToken)
        
        End Function

        Public Function RenounceOwnershipRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of RenounceOwnershipFunction)(Nothing, cancellationToken)
        
        End Function
        Public Function RevokeAuthenticationRequestAsync(ByVal revokeAuthenticationFunction As RevokeAuthenticationFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of RevokeAuthenticationFunction)(revokeAuthenticationFunction)
        
        End Function

        Public Function RevokeAuthenticationRequestAndWaitForReceiptAsync(ByVal revokeAuthenticationFunction As RevokeAuthenticationFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of RevokeAuthenticationFunction)(revokeAuthenticationFunction, cancellationToken)
        
        End Function

        
        Public Function RevokeAuthenticationRequestAsync(ByVal [addr] As String) As Task(Of String)
        
            Dim revokeAuthenticationFunction = New RevokeAuthenticationFunction()
                revokeAuthenticationFunction.Addr = [addr]
            
            Return ContractHandler.SendRequestAsync(Of RevokeAuthenticationFunction)(revokeAuthenticationFunction)
        
        End Function

        
        Public Function RevokeAuthenticationRequestAndWaitForReceiptAsync(ByVal [addr] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim revokeAuthenticationFunction = New RevokeAuthenticationFunction()
                revokeAuthenticationFunction.Addr = [addr]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of RevokeAuthenticationFunction)(revokeAuthenticationFunction, cancellationToken)
        
        End Function
        Public Function StartGrantAuthenticationRequestAsync(ByVal startGrantAuthenticationFunction As StartGrantAuthenticationFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of StartGrantAuthenticationFunction)(startGrantAuthenticationFunction)
        
        End Function

        Public Function StartGrantAuthenticationRequestAndWaitForReceiptAsync(ByVal startGrantAuthenticationFunction As StartGrantAuthenticationFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of StartGrantAuthenticationFunction)(startGrantAuthenticationFunction, cancellationToken)
        
        End Function

        
        Public Function StartGrantAuthenticationRequestAsync(ByVal [addr] As String) As Task(Of String)
        
            Dim startGrantAuthenticationFunction = New StartGrantAuthenticationFunction()
                startGrantAuthenticationFunction.Addr = [addr]
            
            Return ContractHandler.SendRequestAsync(Of StartGrantAuthenticationFunction)(startGrantAuthenticationFunction)
        
        End Function

        
        Public Function StartGrantAuthenticationRequestAndWaitForReceiptAsync(ByVal [addr] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim startGrantAuthenticationFunction = New StartGrantAuthenticationFunction()
                startGrantAuthenticationFunction.Addr = [addr]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of StartGrantAuthenticationFunction)(startGrantAuthenticationFunction, cancellationToken)
        
        End Function
        Public Function TransferOwnershipRequestAsync(ByVal transferOwnershipFunction As TransferOwnershipFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TransferOwnershipFunction)(transferOwnershipFunction)
        
        End Function

        Public Function TransferOwnershipRequestAndWaitForReceiptAsync(ByVal transferOwnershipFunction As TransferOwnershipFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferOwnershipFunction)(transferOwnershipFunction, cancellationToken)
        
        End Function

        
        Public Function TransferOwnershipRequestAsync(ByVal [newOwner] As String) As Task(Of String)
        
            Dim transferOwnershipFunction = New TransferOwnershipFunction()
                transferOwnershipFunction.NewOwner = [newOwner]
            
            Return ContractHandler.SendRequestAsync(Of TransferOwnershipFunction)(transferOwnershipFunction)
        
        End Function

        
        Public Function TransferOwnershipRequestAndWaitForReceiptAsync(ByVal [newOwner] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim transferOwnershipFunction = New TransferOwnershipFunction()
                transferOwnershipFunction.NewOwner = [newOwner]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferOwnershipFunction)(transferOwnershipFunction, cancellationToken)
        
        End Function
        Public Function ContractsQueryAsync(ByVal contractsFunction As ContractsFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Return ContractHandler.QueryAsync(Of ContractsFunction, Boolean)(contractsFunction, blockParameter)
        
        End Function

        
        Public Function ContractsQueryAsync(ByVal [returnValue1] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Dim contractsFunction = New ContractsFunction()
                contractsFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.QueryAsync(Of ContractsFunction, Boolean)(contractsFunction, blockParameter)
        
        End Function


        Public Function DELAY_PERIODQueryAsync(ByVal dELAY_PERIODFunction As DELAY_PERIODFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of DELAY_PERIODFunction, BigInteger)(dELAY_PERIODFunction, blockParameter)
        
        End Function

        
        Public Function DELAY_PERIODQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of DELAY_PERIODFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function DelegateProxyImplementationQueryAsync(ByVal delegateProxyImplementationFunction As DelegateProxyImplementationFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of DelegateProxyImplementationFunction, String)(delegateProxyImplementationFunction, blockParameter)
        
        End Function

        
        Public Function DelegateProxyImplementationQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of DelegateProxyImplementationFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function InitialAddressSetQueryAsync(ByVal initialAddressSetFunction As InitialAddressSetFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Return ContractHandler.QueryAsync(Of InitialAddressSetFunction, Boolean)(initialAddressSetFunction, blockParameter)
        
        End Function

        
        Public Function InitialAddressSetQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            return ContractHandler.QueryAsync(Of InitialAddressSetFunction, Boolean)(Nothing, blockParameter)
        
        End Function



        Public Function NameQueryAsync(ByVal nameFunction As NameFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of NameFunction, String)(nameFunction, blockParameter)
        
        End Function

        
        Public Function NameQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of NameFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function OwnerQueryAsync(ByVal ownerFunction As OwnerFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of OwnerFunction, String)(ownerFunction, blockParameter)
        
        End Function

        
        Public Function OwnerQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of OwnerFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function PendingQueryAsync(ByVal pendingFunction As PendingFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of PendingFunction, BigInteger)(pendingFunction, blockParameter)
        
        End Function

        
        Public Function PendingQueryAsync(ByVal [returnValue1] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Dim pendingFunction = New PendingFunction()
                pendingFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.QueryAsync(Of PendingFunction, BigInteger)(pendingFunction, blockParameter)
        
        End Function


        Public Function ProxiesQueryAsync(ByVal proxiesFunction As ProxiesFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of ProxiesFunction, String)(proxiesFunction, blockParameter)
        
        End Function

        
        Public Function ProxiesQueryAsync(ByVal [returnValue1] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Dim proxiesFunction = New ProxiesFunction()
                proxiesFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.QueryAsync(Of ProxiesFunction, String)(proxiesFunction, blockParameter)
        
        End Function


    
    End Class

End Namespace
