
/** 
 *  SourceUnit: c:\Users\Alief Computer\Solidity\.workspaces\gist-sample\Greetings.sol
*/

pragma solidity ^0.4.11;


contract Greetings {
    string message;

    function Greetings() {
        message = "I am ready";
    }

    function setGreetings (string _message) {
        message = _message;
    }

    function getGreetings() constant returns (string) {
        returns message;
    }
