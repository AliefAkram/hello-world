pragma solidity ^0.4.0;

contract Mortal {
    /* Define variable owner of the type address*/
    address owner;

    /* this function is executed at initialization and sets the owner of the contract */
    function Mortal() { owner = msg.sender; }

    /* Function to recover the funds on the contract */
    function kill() { if (msg.sender == owner) selfdestruct(owner); }
}

contract Demo is Mortal{
    uint storedVal;
    string storedText;
    uint public initialEther;

    function Demo(uint _storedVal, string _storedText) payable {
      storedVal = _storedVal;
      storedText = _storedText;
      initialEther = msg.value;
    }

    function showHello() constant returns (string) {
        return "你好";
    }

    function setStoredVal(uint _storedVal) {
        storedVal = _storedVal;
    }

    function setStoredText(string _storedText) {
        storedText = _storedText;
    }

    function getStoredText() constant returns (string) {
        return storedText;
    }

    function getStoredTextNoConstant() returns (string) {
        return storedText;
    }

    function getStoredVal() constant returns (uint) {
        return storedVal;
    }

    function getStoredValNoConstant() returns (uint) {
        return storedVal;
    }
}