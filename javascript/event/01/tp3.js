var child1= document.getElementById('parent1');
var child2= document.getElementById('parent2');
var result= document.getElementById('result');

child1.addEventListener('mouseover', function(e){
    result.innerHTML = 'element quitté ' + e.relatedTarget.id;
});

child2.addEventListener('mouseout', function(e){
    result.innerHTML = 'element survolé ' + e.relatedTarget.id;
});


