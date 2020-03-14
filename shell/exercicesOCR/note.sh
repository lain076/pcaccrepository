#!/bin/bash

note=0
moyenne=0
i=0

until [ $note -lt 0 ]
do

    read -p 'Entrer une note : ' note

    if [ $note = "q" ]
    then
	note=-1
    elif [ $note -ge 16 ]
    then
	echo 'Trés bien'

    elif [ $note -lt 16 ] && [ $note -ge 14 ]
    then
	echo 'Bien'

    elif [ $note -lt 14 ] && [ $note -ge 12 ]
    then
	echo 'Assez bien'

    elif [ $note -lt 12 ] && [ $note -ge 10 ]
    then
	echo 'Moyen'

    elif [ $note -lt 10 ]
    then
	echo 'Mauvais'    
    fi

    if [ $note -ge 0 ]
    then
	let moyenne+=$note
	let i+=1
    fi

done

if [ $i -le 0 ]
then
    i=1
fi

let moyenne=$moyenne/$i
echo "la moyenne est $moyenne ($i notes)"






