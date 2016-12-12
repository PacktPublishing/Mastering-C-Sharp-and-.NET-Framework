class Greeter {
    element: HTMLElement;
    span: HTMLElement;
    timerToken: number;

    constructor(element: HTMLElement) {
        this.element = element;
        this.element.innerHTML += "The time is: ";
        this.span = document.createElement('span');
        this.element.appendChild(this.span);
        this.span.innerText = new Date().toUTCString();
    }

    start() {
        this.timerToken = setInterval(
            () => this.span.innerHTML = new Date().toUTCString(), 500);
    }

    stop() {
        clearTimeout(this.timerToken);
    }

}

window.onload = () => {
    // This links the UI to the JS code
    var el = document.getElementById('content');
    var btnStop = document.getElementById('btnStop');
    var greeter = new Greeter(el);
    // Now that Greeter is defined, we can use it
    // from the button to stop the clock
    btnStop.addEventListener("click", () => {
        greeter.stop();
        alert("Clock Stopped!");
    });
    greeter.start();
};