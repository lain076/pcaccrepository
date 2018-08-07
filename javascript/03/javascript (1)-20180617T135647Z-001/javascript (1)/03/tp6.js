console.log('start execution js5');

var mainDiv = document.createElement('div');
mainDiv.id = 'divTP4';

var form = document.createElement('form');

form.action = 'upload.php';
form.enctype = 'multipart/form-data';
form.method = 'post';

var fieldSet = document.createElement('fieldset');
var legend = document.createElement('legend');
var legendText = document.createTextNode('upload pic');
var center = document.createElement('div');
center.setAttribute('style','text-align: center');

legend.appendChild(legendText);

fieldSet.appendChild(legend);
fieldSet.appendChild(center);

form.appendChild(fieldSet);


//fields creation
var label = document.createElement('label'),
    labelText = document.createTextNode('Image à uploader :');

var input = document.createElement('input');
var br = document.createElement('br');
var submit = document.createElement('input');

input.type = 'file';
input.id = 'inputUpload';
input.name = input.id;

submit.type = 'submit';
submit.value = 'Envoyer';

label.htmlFor = 'inputUpload';
label.appendChild(labelText);


center.appendChild(label);
center.appendChild(input);
center.appendChild(br);
center.appendChild(br.cloneNode(false));
center.appendChild(submit);

mainDiv.appendChild(form);

document.body.appendChild(mainDiv);

console.log('return(0)');
