

var B_running = true;
var Fname = '';
var tab_names = [];


function ano()
{
    console.log("anonon");
}


do
{

    
    Fname = prompt('entrez un prénom');

    if(Fname)
    {
	tab_names.push(Fname);
	console.log('ta mere en short');
    }
    else
    {
	B_running = false;
	console.log('condition est false');
    }
    
}while(B_running)


if(tab_names.length > 0)
{
    var namesConcat = '';
    for(var Tname in tab_names)
    {
	namesConcat += tab_names[Tname] + ',';
    }
    console.log('affichage finale');
    alert(namesConcat);
}
else
{
    alert('Aucun nom n a été saisi')
}

console.log(tab_names);
    alert('return 0')
