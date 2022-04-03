#!/bin/bash

#check the command

goodCommand="false"

if [ -z $1 ]
then
    echo "error no command"
else

    if [ $1 = "touch" ]
    then
	echo "create file"
	goodCommand="true"
    fi
    

    if [ $1 = "copy" ]
    then
	echo "copy file"
	goodCommand="true"	
    fi

    if [ $goodCommand = "false" ]
    then
	echo "wrong command"
    fi
    
fi
