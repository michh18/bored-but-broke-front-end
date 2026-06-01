var facts = [
    "We have a <strong>16-day forecast system</strong> built-in to optimise your search based on the weather",
    "There are over 100,000 places to choose from in the UK",
    "There are over 4,000 free museums and galleries across the UK.",
    "We have best database for finding free activities in the world",
    "New fact"
];

var current = 0;

function showFact() {
    var el = document.getElementById("fact-display");
    if (el) el.innerHTML = facts[current];
}

window.changeFact = function (direction) {
    current = (current + direction + facts.length) % facts.length;
    showFact();
};

function initFacts() {
    var el = document.getElementById("fact-display");
    if (!el) {
        setTimeout(initFacts, 100);
        return;
    }
    showFact();
    setInterval(function () {
        current = (current + 1) % facts.length;
        showFact();
    }, 7000);
}

initFacts();
