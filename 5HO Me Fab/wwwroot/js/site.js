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

function fmt(n) {
    return "$" + n.toLocaleString(undefined, { minimumFractionDigits: 2, maximumFractionDigits: 2 });
}

function updatePricing() {
    const selects = [
        "TankCust1", "TankCust2", "TankCust3",
        "TankCust4", "TankCust5", "TankCust6"
    ];

    let partsTotal = 0;
    let laborHours = 0;
    let uniqueParts = new Set();
    let partLines = [];

    selects.forEach(id => {
        const val = document.getElementById(id).value;
        if (val) uniqueParts.add(val);
    });

    uniqueParts.forEach(val => {
        const price = tankPrices[val] || 0;
        if (price > 0) {
            partsTotal += price;
            laborHours += 4;
            partLines.push(val + " " + fmt(price) + " +");
        }
    });

    const laborCost = laborHours * 50;
    const tankBase = 31085.00;
    const subtotal = tankBase + partsTotal + laborCost;
    const tax = subtotal * 0.08;
    const grand = subtotal + tax;

    document.getElementById("price-base").innerText = fmt(tankBase);

    document.getElementById("price-individual-breakdown").innerHTML =
        partLines.length > 0 ? partLines.join("<br>") : "No priced parts selected";

    document.getElementById("price-individual").innerText =
        fmt(partsTotal);

    document.getElementById("price-labor-breakdown").innerText =
        "50 × " + laborHours + " = " + fmt(laborCost);

    document.getElementById("price-labor").innerText = fmt(laborCost);

    document.getElementById("price-tax-breakdown").innerText =
        fmt(subtotal) + " × 0.08 = " + fmt(tax);

    document.getElementById("price-tax").innerText = fmt(tax);

    document.getElementById("price-total").innerText =
        fmt(grand);
}

window.addEventListener("load", loadState);