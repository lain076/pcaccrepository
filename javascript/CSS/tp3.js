console.log("script start");

function testH()
{
    var assoc = new Object();
    assoc["case00"] = 1;
    assoc["case01"] = 2;
    assoc["case02"] = 3;

    console.log(assoc["case01"]);
    
    return(assoc);
}


var acc = testH();

    console.log("fct return " + acc["case01"]);
console.log("fct " + acc);

console.log("return 0");
