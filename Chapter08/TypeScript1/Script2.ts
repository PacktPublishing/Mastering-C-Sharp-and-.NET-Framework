// TypeScript source code
interface Calculator {
    increment?: number,
    clear(): void,
    result(): number,
    add(n: number): void,
    add(): void,
    new (s: string): Element;
}

function makeCalculation(c: Calculator) {
    var result = 0;
    c.add(7);
}

window.onmousemove = function (e) {
    alert("Mouse left at X coord: " +
        e.clientX);
};