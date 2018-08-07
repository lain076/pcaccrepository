
console.log('start execution');

// create the paragraph
var para = ﻿document.createElement('p');
var paraText = document.createTextNode('Language basé sur ECMAScript');
para.appendChild(paraText);


var optionsList = [
    document.createTextNode('JavaScript'),
    document.createTextNode('JScript'),
    document.createTextNode('action script'),
    document.createTextNode('EX4')
]

var myList = document.createElement('ul'),
    itemList;


for (var i=0; i < optionsList.length; i++)
{
    itemList = document.createElement('li');
    itemList.appendChild(optionsList[i]);
    myList.appendChild(itemList);
}
    


// create the main DIV tag
var myDiv = ﻿document.createElement('div');
myDiv.id = 'divTP2';

// add the previously created elements in the DIV tag
myDiv.appendChild(para);
myDiv.appendChild(myList);


// insert the DIV tag in the page
document.body.appendChild(myDiv);
