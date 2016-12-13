var hardware = [
    { name: "Mouse", price: 9.95, id: 3 },
    { name: "Keyboard", price: 27.95, id: 1 },
    { name: "Printer", price: 49.95, id: 2 },
    { name: "Hard Drive", price: 72.95, id: 4 },
];
function sortByName(a) {
    var result = a.slice(0);
    result.sort(function (x, y) {
        return x.name.localeCompare(y.name);
    });
    return result;
}
window.onload = function () {
    var sorted = sortByName(hardware);
    sorted.map(function (e) {
        var elem = document.createElement("p");
        document.body.insertAdjacentElement("beforeEnd", elem);
        elem.innerText = e.name.toString() + " - " + e.price.toString();
    });
};
//# sourceMappingURL=app.js.map