console.log("start");


//test sur les litéraux
function testLit()
{
    var literalVar = {};

literalVar.sister = "sabrina";
literalVar.brother = "samsam";


    console.log(literalVar.brother);
    return(literalVar);
}



acc = testLit();

console.log("out of function " + acc.brother);


//idem avec tableau
function testTab()
{
    var myTab = [];
    myTab.push("item00");
    myTab.push("item01");
    myTab.push("item02");

    return(myTab);    
}

var accTab = testTab();

console.log(accTab[1]);

//test sur nombre
var myVar = "hello world";

if(isNaN(myVar))
{
    console.log("variable not a number");
}

console.log("end script");
