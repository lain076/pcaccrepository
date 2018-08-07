console.log("script start");

myElem = document.getElementById('myElem');

myElem.onclick = function(e) {
    console.log("type : " + e.type);
    console.log(this);

    e.target.innerHTML = 'modiftxt';
};

console.log("return 0");
