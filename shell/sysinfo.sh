#! /bin/sh

#creator : lain
#last update : 22/07/2019

clear

myuser=$USER
echo "Current user : $myuser" 

cat /proc/version
acpi -b
command=`pwd`
echo "Personnal scripts are executed in : $command"


command=`date`
echo "Current date : $command" 
echo " "
echo " "


echo "Memory status :"
free


echo " "
echo "Hard drive(s) status :  "
df -h
echo " "
echo " "
echo " "


