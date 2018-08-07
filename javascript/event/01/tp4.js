console.log("script start");

var field = document.getElementById('field'),
    down = document.getElementById('down'),
    press = document.getElementById('press'),
    up = document.getElementById('up');


document.addEventListener('keydown', function(e) {
    down.innerHTML = String.fromCharCode(e.keyCode);
});

document.addEventListener('keypress', function(e) {
    press.innerHTML = e.keyCode;
});

document.addEventListener('keyup', function(e) {
    up.innerHTML = e.keyCode;
});





console.log("exit 0");
