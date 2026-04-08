// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const tankDescriptions = window.tankLookupData;

function updateDesc(selectId, descId) {
    const selected = document.getElementById(selectId).value;
    document.getElementById(descId).innerText = tankDescriptions[selected] || "";
}

document.getElementById("TankCust1").addEventListener("change", () => updateDesc("TankCust1", "desc1"));
document.getElementById("TankCust2").addEventListener("change", () => updateDesc("TankCust2", "desc2"));
document.getElementById("TankCust3").addEventListener("change", () => updateDesc("TankCust3", "desc3"));
document.getElementById("TankCust4").addEventListener("change", () => updateDesc("TankCust4", "desc4"));
document.getElementById("TankCust5").addEventListener("change", () => updateDesc("TankCust5", "desc5"));
document.getElementById("TankCust6").addEventListener("change", () => updateDesc("TankCust6", "desc6"));