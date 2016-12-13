var Greeter = (function () {
    function Greeter(element) {
        this.element = element;
        this.element.innerHTML += "The time is: ";
        this.span = document.createElement('span');
        this.element.appendChild(this.span);
        this.span.innerText = new Date().toUTCString();
    }
    Greeter.prototype.start = function () {
        var _this = this;
        this.timerToken = setInterval(function () { return _this.span.innerHTML = new Date().toUTCString(); }, 500);
    };
    Greeter.prototype.stop = function () {
        clearTimeout(this.timerToken);
    };
    return Greeter;
}());
window.onload = function () {
    // This links the UI to the JS code
    var el = document.getElementById('content');
    var btnStop = document.getElementById('btnStop');
    var greeter = new Greeter(el);
    // Now that Greeter is defined, we can use it
    // from the button to stop the clock
    btnStop.addEventListener("click", function () {
        greeter.stop();
        alert("Clock Stopped!");
    });
    greeter.start();
};
//# sourceMappingURL=app.js.map