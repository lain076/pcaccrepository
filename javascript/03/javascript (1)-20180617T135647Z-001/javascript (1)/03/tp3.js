console.log('je passe ici');
var newDiv = document.createElement('div');
newDiv.id='divTP1';

//we create all nodes in a tab for more easiness
var textNodes = [
    document.createTextNode('le '),
    document.createTextNode('world wide web consortium'),
    document.createTextNode(' abrégé par le sigle '),
    document.createTextNode('w3c'),
    document.createTextNode(' est un '),
    document.createTextNode('organisme de standardisation'),
    document.createTextNode(' à but non lucratif chargé de promouvoir le coxmpatibilité des technologies du '),
    document.createTextNode('world wide WEB'),
    document.createTextNode(' . ')
];

//we create two <a> and <strong> elements
var w3cStrong1 = document.createElement('strong');
var w3cStrong2 = document.createElement('strong');

w3cStrong1.appendChild(textNodes[1]);
w3cStrong2.appendChild(textNodes[3]);

var orgLink = document.createElement('a');
var wwwLink = document.createElement('a');


orgLink.id = 'orgLink';
orgLink.title = 'Organisme de normalisation';
orgLink.href = 'http://www.google.be';
orgLink.appendChild(textNodes[5]);

wwwLink.id = 'wwwLink';
wwwLink.title = 'world wide web';
wwwLink.href = 'http://www.yahoo.be';
wwwLink.appendChild(textNodes[7]);

console.log('je passe ici 02');

// we insert all elements in the main DIV
newDiv.appendChild(textNodes[0]);
newDiv.appendChild(w3cStrong1);
newDiv.appendChild(textNodes[2]);
newDiv.appendChild(w3cStrong2);
newDiv.appendChild(textNodes[3]);
newDiv.appendChild(orgLink);
newDiv.appendChild(textNodes[6]);
newDiv.appendChild(wwwLink);
newDiv.appendChild(textNodes[8]);


// we insert the main DIV in the html tag body
document.body.appendChild(newDiv);

console.log('return(0)');
