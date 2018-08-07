var position = document.getElementById('position');

document.addEventListener('mousemove',function(e) {
    position.innerHTML = 'position x : ' + e.clientX + ' px<br/> position y : ' + e.clientY + ' px';
});
