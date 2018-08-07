
var numberToConvert;
var runningProcess = true;

var exist_3rank = false;
var exist_2rank = false;
var exist_1rank = false;

var block3="";
var block2="";
var block1="";


function checkSigneOK(numberConverted)
{
    if(numberConverted>-1){return(true);}
    return(false);
}

function checkRanksOK(numberToConvert)
{
    var numberLenght = numberToConvert.length;
    if(numberLenght<4)
    {
	switch(numberLenght)
	{
	    case 1:
	      exist_1rank = true;
	      exist_2rank = exist_3rank = false;
	    break;

	    case 2:
       	      exist_2rank = true;
	      exist_1rank = exist_3rank = false;
	    break;

	    case 3:
	      exist_3rank = true;
	      exist_2rank = exist_1rank = false;
	    break;
	}
	return(true);
    }
    else
    {
	return(false);
    }
}

function convertInLetter(numberToConvert)
{
    console.log("je convertis");
    if(exist_3rank)
    {
	convert3Rank(numberToConvert[0]);
	convert2Rank(numberToConvert[1]);
	convert1Rank(numberToConvert[2]);
    }

    if(exist_2rank)
    {
	
    }

    if(exist_1rank)
    {
	
    }
}

function convert3Rank(number)
{

    console.log("convertis les centaines");
    switch(number)
    {
	case "1":block3="cent";	break;
	case "2":block3="deux cent";	break;
	case "3":block3="trois cent";	break;
	case "4":block3="quattre cent";	break;
	case "5":block3="cinq cent";	break;
	case "6":block3="six cent";	break;
	case "7":block3="sept cent";	break;
	case "8":block3="huit cent";	break;
	case "9":block3="neuf cent";	break;
	
    }
}
 
function convert2Rank(number)
{
   switch(number)
    {
	
	case "0":block2=("");	break;	
	case "1":block2=("dix");	break;
	case "2":block2=("vinght");	break;
	case "3":block2=("trente");	break;
	case "4":block2=("quarante");	break;
	case "5":block2=("cinqante");	break;
	case "6":block2=("sixante");	break;
	case "7":block2=("septante");	break;
	case "8":block2=("quattrevingt");	break;
	case "9":block2=("nonante");	break;
	
    }
}

function convert1Rank(number)
{


    switch(number)
    {
	case "0":block1="";
	case "1":block1="un";	break;
	case "2":block1="deux";	break;
	case "3":block1="trois";	break;
	case "4":block1="quattre";	break;
	case "5":block1="cinq";	break;
	case "6":block1="six";	break;
	case "7":block1="sept";	break;
	case "8":block1="huit";	break;
	case "9":block1="neuf";	break;
	
    }
}


//---------------------------------------------------------------------------------------------- end functions area

//boucle principale
do
{
   
    numberToConvert = prompt("entrez un nombre strictement positif de 3 chiffres \n ou entrez esc pour sortir");
    //convertion en entier
    var numberConverted = parseInt(numberToConvert,);

    if(!isNaN(numberConverted)) //si bien un  nombre on continue
    {

	if(!checkSigneOK(numberConverted)) //si nombre nonpositif on stope
	{
	    alert("Nombre non positif");
	}
	else
	{
	    if(checkRanksOK(numberToConvert)) //si nombre de rangs entre 1 et 3 on continue
	    {
		convertInLetter(numberToConvert);
		alert(block3+"-"+block2+"-"+block1);
	    }
	    else
	    {
		alert("le nombre est trop grand");
	    }
	}
    }
    else
    {
	if(numberToConvert == 'esc')
	{
	    runningProcess = false;
	}
	else
	{
	    alert("Il ne s'agit pas d'un nombre ou d'une commande valide");
	}
    }

}
while(runningProcess)



console.log("return 0");


