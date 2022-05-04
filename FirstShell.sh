
clear
#Variables
total=0
Milk=4
Bread=3
Cheese=2
Bacon=5
Eggs=4
greeting="Hello Customer welcome to my Store!"
name=Eric

#Greeting into store and ask user for name
echo "$greeting"
echo "What is your name?"
read name
clear

#Loop will repeat the menu to the user and read users answer for products chosen
repeat="true"
while [ "$repeat" == "true" ]
do
echo "$name ,What would you like to buy?"
echo "1. Milk 4.00"
echo "2. Bread 3.00"
echo "3. Cheese 2.00"
echo "4. Bacon 5.00"
echo "5. Eggs 4.00"
echo "6. Exit"
echo "7. Checkout"
read answer

if [ "$answer" == "1" ]
then
echo "Milk $Milk"
total=$(($total+$Milk))

elif [ "$answer" == "2" ]
then
echo "Bread $Bread"
total=$(($total+$Bread))

elif [ "$answer" == "3" ]
then
echo "Cheese $Cheese"
total=$(($total+$Cheese))

elif [ "$answer" == "4" ]
then
echo "Bacon $Bacon"
total=$(($total+$Bacon))

elif [ "$answer" == "5" ]
then
echo "Eggs $Eggs"
total=$(($total+$Eggs))

#this elif will stop the loop
elif [ "$answer" == "6" ]
then
repeat="false"
echo "Thank You please come again!"

#this elif will checkout and return the total price of products
elif [ "$answer" == "7" ]
then
clear
echo "This is the Total : $total"

#this will run if user enters anything besides the menu options , ex . 8.
else
echo "Please enter a correct option"

fi
done



