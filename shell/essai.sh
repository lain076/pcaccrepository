#!/bin/bash

clear
#aff folder content

#ls -l

#message='hello world \n how are you'
#echo -e $message

exit

#mavar='VALUE'
#command=`ls -l`

#echo 'hello world $mavar'
#echo ''
#echo "hello world $mavar"
#echo ''
#echo "hello world $command"

#read -p 'entrez nom max 5 char ' -n 5 name
#echo -e "\n bonjour $name"

#read -p 'Entrez le code de d�samor�age de la bombe (vous avez 5 secondes) : '  -t 5 code
#echo -e "\nBoum !"

#let "a = 5"
#let "b = 4"
#let "c = a + b"
#echo $c


#echo "le script ex�cut� est : $0 il y a $# params"
#echo "param01 $1 param02 $2"

echo "Le param�tre 1 est $1"
shift
echo "Le param�tre 1 est maintenant $1"
shift
echo "Le param�tre 1 est maintenant $1"


tableau=('valeur0' 'valeur1' 'valeur2')
tableau[2]=$1
echo ${tableau[1]}
echo ${tableau[*]}


echo '--------------------------------------'

nom='bruno'

if [ $nom = "bruno" ]
then
echo "salut $nom"
fi







