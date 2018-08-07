//var div = document.getElementById('myDiv');
//alert(div);


var query = document.querySelector('#menu .item span'),queryAll = document.querySelectorAll('#menu .item span');
alert(query.innerHTML);

console.log(query.innerHTML);
console.log(queryAll.length);
console.log(queryAll[0].innerHTML + ' - ' + queryAll[1].innerHTML);
console.log("total tab");
console.log(queryAll);


var jad00 = document.getElementById('jad');
//var lnkref = jad00.href;
var lnkref = jad00.getAttribute('href');
var lnktxt = jad00.innerHTML;
console.log(lnkref + ' - ' + lnktxt);

jad00.setAttribute('href','http://wwww.yahoo.com');
jad00.innerHTML = 'new url';

console.log("test sur les noeuds");

var paragraph = document.getElementById('myp');
var children = paragraph.childNodes;

console.log(children.length);

for (var i = 0, c = children.length; i <c; i++)
{
    if(children[i].nodeType === Node.ELEMENT_NODE)
    {
	console.log('html element : ' + children[i].firstChild.data);
    }
    else
    {
	console.log('text element : ' + children[i].data);
    }
}
