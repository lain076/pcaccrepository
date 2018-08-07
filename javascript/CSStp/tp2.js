console.log("script start");
//  <!--exercice de la page 194 sur les css -->

(function(){

    var storage = {};

    function init(){

	var elements = document.querySelectorAll('.draggableBox');
	var elementsLength = elements.length;

	for(var i = 0; i < elementsLength; i++)
	{
       	    elements[i].addEventListener('mousedown', function(e)
            {
		var s = storage;
		s.target = e.target;
		s.offsetX = e.clientX - s.target.offsetLeft;
		s.offsetY = e.clientY - s.target.offsetLeft;
	    });

	    elements[i].addEventListener('mouseup', function()
	    {
		storage = {};
	    });
	}
	
	document.addEventListener('mousemove', function(e)
				  {
				      var target = storage.target;
				      if(target)
				      {
					  target.style.top = e.clientY - storage.offsetY + 'px';
					  target.style.left = e.clientX - storage.offsetX + 'px';					  
				      }
				  });

    }
	init();
    
    
})();


console.log("return 0");
