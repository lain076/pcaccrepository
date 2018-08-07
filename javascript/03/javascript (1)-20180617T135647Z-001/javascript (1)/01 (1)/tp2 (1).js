
function num2Letter(number)
{
    if(isNaN(number) || number < 0 || 999 < number)
    {
	return('Please enter a NUMBER between 0 and 999');
    }

    var units2Letters= ['','un','deux','trois','quatre','cinq','six','sept','huit','neuf','dix','onze','douze','treize','quatorze','quinze','seize','dix-sept','dix-huit','dix-neuf'];


    var tens2Letters= ['','dix','vingt','trente','quarante','cinquante','soixante','septente','quatre-vingt','nonante'];

    var units = number % 10;
    var tens = (number % 100 - units) / 10;
    var hundreds = (number % 1000 - number % 100) / 100;

    var unitsOut, tensOut, hundredsOut;

    if(number === 0)
    {
	return('zéro');
    }
    else
    {
	//traitement des unités 
	unitsOut = (units === 1 && tens > 0 && tens !== 8 ? 'et-' : '') + units2Letters[units];

	//traitement des dizaines
	if(tens === 1 && units > 0)
	{
	    tensOut = units2Letters[10 + units];
	    unitsOut = '';
	}
	else if(tens === 7 || tens === 9)
	{
	    tensOut = tens2Letters[tens-1] + '-' + (tens === 7 && units === 1 ?  'et-' :'') + units2Letters[10+ units];
    	    unitsOut = '';
	}
	else
	{
	    tensOut = tens2Letters[tens];
	}

	tensOut += (units === 0 && tens ===8 ? 's' : '');


	//traitement des centaines
	hundredsOut = (hundreds > 1 ? units2Letters[hundreds] + '-' : '') + (hundreds > 0 ? 'cent' : '') + (hundreds > 1 && tens == 0 && units == 0 ? 's' : '');


	return hundredsOut + (hundredsOut && tensOut ? '-' : '') + tensOut + (hundredsOut && unitsOut || tensOut && unitsOut ? '-' : '') + unitsOut;
    }
    
}


var userEntry;

while(userEntry = prompt('Enter a number to write in letter between 0 and 999 : '))
      {
	  alert(num2Letter(parseInt(userEntry,10)));
      }
