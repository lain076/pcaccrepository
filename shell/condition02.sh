#!/bin/bash

#if [ $1 -ge 20 ]
#then
#   echo "nombre pge a 20"
#else
#   echo "nombre pp 20"
#fi

#read -p "entrez un répertoire : " rep

#if [ -d $rep ]
#then
 #   echo "rep exist"
#else
 #   echo "rep exist pas"
#fi


read -p "enter your name : " yname 
   
case $yname in
    "asuka")
	echo "hy $yname"
    ;;
    "rei")
	echo "hy $yname"
    ;;
    *)
echo 'balaye'
	;;
esac


       
