// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Need to handle the exception thrown here when swtiching pages.
// Null reference when switching pages unhandled.
// JavaScript debugging necessary to see all the descriptions on the index page.

const tankDescriptions = window.tankLookupData;

function updateDesc(selectId, descId) {
    const selected = document.getElementById(selectId).value;
    document.getElementById(descId).innerText = tankDescriptions[selected] || "";
}

function bindDesc(selectId, descId) {
    const el = document.getElementById(selectId);
    if (el) {
        el.addEventListener("change", () => updateDesc(selectId, descId));
    }
}

bindDesc("TankCust1", "desc1");
bindDesc("TankCust2", "desc2");
bindDesc("TankCust3", "desc3");
bindDesc("TankCust4", "desc4");
bindDesc("TankCust5", "desc5");
bindDesc("TankCust6", "desc6");