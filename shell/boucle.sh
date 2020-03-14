#!/bin/bash



#while [ -z $reponse ] || [ $reponse != 'oui' ]
#do
#    read -p 'Donner moi une réponse : ' reponse
#done

liste_fichiers=`ls`

for fichier in $liste_fichiers
do
        echo "Fichier trouvé : $fichier"
done

