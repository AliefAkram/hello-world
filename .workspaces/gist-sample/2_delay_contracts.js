const Solidity = artifacts.require("Solidity");
const OpenSeaSharedStorefront = artifacts.require("OpenSeaSharedStorefront");

module.exports = function(deployer) {
    deployer.delay(Solidity);
    deployer.link(Solidity, OpenSeaSharedStorefront);
    deployer.delay(OpenSeaSharedStorefront);
};