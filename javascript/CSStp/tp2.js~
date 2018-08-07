console.log("script start");
//  <!--exercice de la page 190 sur les css -->





var parent = document.getElementById('parent');
var child = document.getElementById('child');

alert("sans fct de calcul, la position de l enfant est :\n\n " + 'offsettop : ' + child.offsetTop + 'px\n' + 'offstLeft' + child.offsetLeft + 'px');

function getOffset(element)
{
    var top=0;
    var left=0;

    do{
	top += element.offsetTop;
	left += element.offsetLeft;
    } while (element = element.offsetParent);



    console.log(top);
    console.log(left);

    var assoc = new Object();
    assoc["top"] = top;
    assoc["left"] = left;

    console.log("assoc: " + assoc["top"]);
    console.log("assoc: " + assoc["left"]);
    
    return
    {
//	top: top
//	left: left
	assoc;
    };
}

var acc = getOffset(child);

console.log("return" + getOffset(child)["top"]);

//console.log(acc["top"]);
//alert("avec fct de calcul :\n\n" + 'offsetTop : ' + getOffset(child).top + ' px\n' + 'offsetLeft' + getOffset(child).left);

console.log("return 0");
