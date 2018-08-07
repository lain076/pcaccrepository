
console.log('start execution js5');

// create the paragraph
var para = ﻿document.createElement('p');
var paraText = document.createTextNode('Language basé sur ECMAScript');
para.appendChild(paraText);


var ddList = [
    document.createTextNode('JavaScript'),
    document.createTextNode('JScript'),
    document.createTextNode('action script'),
    document.createTextNode('EX4')
]

var dtList = [
    document.createTextNode('description javascript'),
    document.createTextNode('description jscript'),
    document.createTextNode('description action script'),
    document.createTextNode('description EX4')
]

var myList = document.createElement('dl');

for (var i=0; i < ddList.length; i++)
{
    console.log(i);
    dtItem = document.createElement('dt');
    dtItem.appendChild(dtList[i]);

    ddItem = document.createElement('dd');
    ddItem.appendChild(ddList[i]);
    
    myList.appendChild(ddItem);
    myList.appendChild(dtItem);

}
    


// create the main DIV tag
var myDiv = ﻿document.createElement('div');
myDiv.id = 'divTP2';

// add the previously created elements in the DIV tag
myDiv.appendChild(para);
myDiv.appendChild(myList);


// insert the DIV tag in the page
document.body.appendChild(myDiv);

console.log('return(0)');
