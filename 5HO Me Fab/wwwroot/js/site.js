// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const tankDescriptions = window.tankLookupData;
const tankPrices = window.tankPriceData;

function updateDesc(selectId, descId) {
    const selected = document.getElementById(selectId).value;
    document.getElementById(descId).innerText = tankDescriptions[selected] || "";
}

function bindDesc(selectId, descId) {
    const el = document.getElementById(selectId);
    if (el) {
        el.addEventListener("change", () => {
            updateDesc(selectId, descId);
            saveState();
            updatePricing();
        });
    }
}

bindDesc("TankCust1", "desc1");
bindDesc("TankCust2", "desc2");
bindDesc("TankCust3", "desc3");
bindDesc("TankCust4", "desc4");
bindDesc("TankCust5", "desc5");
bindDesc("TankCust6", "desc6");

function saveState() {
    const ids = [
        "TankCust1", "TankCust2", "TankCust3",
        "TankCust4", "TankCust5", "TankCust6",
        "TankCust1Notes", "TankCust2Notes", "TankCust3Notes",
        "TankCust4Notes", "TankCust5Notes", "TankCust6Notes"
    ];

    ids.forEach(id => {
        const el = document.getElementById(id);
        if (el) localStorage.setItem(id, el.value);
    });
}

function loadState() {
    const ids = [
        "TankCust1", "TankCust2", "TankCust3",
        "TankCust4", "TankCust5", "TankCust6",
        "TankCust1Notes", "TankCust2Notes", "TankCust3Notes",
        "TankCust4Notes", "TankCust5Notes", "TankCust6Notes"
    ];

    ids.forEach(id => {
        const el = document.getElementById(id);
        if (el) {
            const saved = localStorage.getItem(id);
            if (saved !== null) el.value = saved;
        }
    });

    updateDesc("TankCust1", "desc1");
    updateDesc("TankCust2", "desc2");
    updateDesc("TankCust3", "desc3");
    updateDesc("TankCust4", "desc4");
    updateDesc("TankCust5", "desc5");
    updateDesc("TankCust6", "desc6");

    updatePricing();
}

function updatePricing() {
    const selects = [
        "TankCust1", "TankCust2", "TankCust3",
        "TankCust4", "TankCust5", "TankCust6"
    ];

    let total = 0;

    selects.forEach(id => {
        const val = document.getElementById(id).value;
        if (tankPrices[val]) total += tankPrices[val];
    });

    const labor = 0;
    const tax = total * 0.08;
    const grand = total + labor + tax;

    document.getElementById("price-individual").innerText = total.toFixed(2);
    document.getElementById("price-labor").innerText = labor.toFixed(2);
    document.getElementById("price-tax").innerText = tax.toFixed(2);
    document.getElementById("price-total").innerText = grand.toFixed(2);
}

window.addEventListener("load", loadState);