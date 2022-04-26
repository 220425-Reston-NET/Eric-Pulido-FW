echo "this is a script"
# variables
msg="hello"
echo $msg

#if statements
ten=10
five=5
thirteen=13
echo "===First If==="
if [ "$ten" -ge "$five" ]
then
echo "Greater!"
echo "$ten > $five"
fi

echo "This is outside of the then fi"

echo "===Second If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -le "$ten" ]
then echo "lesser"
echo "$five < $ten"
fi

echo "===Third If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater"
echo "$five > $ten"
elif [ "$five" -ge "$thirtenn" ]
then
echo "Greater"
echo "$five > $thirteen"
else
echo "Nothing Matches"
fi

# loops
# a way to repeat multiple lines of code x ammount of times.
# for loops statement
#useful if you know how many times you need to execute those lines of code.
echo "===First Loop==="
for number in 1 2 3 4 5
do
echo "hello $number"
done

echo "===Second Loop==="
for i in {1..10}
do
echo "$i"
done

echo "===While loops==="
#useful if you dont know how many times you need to execute those lines of code
while [ "$five" -le "$ten" ]
do
echo "lesser"
five=$(($five+1))
echo "$five"
done

# INPUT AND OUTPUT
echo "what is your name?"
read name
echo "hello $name, welcome to programming!"

# CLEAR COMMAND WILL CLEAR ALL THE TEXT IN THE TERMINAL
while [ "$repeat" == "true" ]
do
echo "Welcome to shell scripting"
echo "what do you want to do today"
echo "enter 1 for adding two numbers"

read answer
if [ "$answer" == "1" ]
then
      echo "give me number 1"
      read num1
      echo "give me number 2"
      read num2
      echo "the sum is $(($num1+$num2))"
elif [ "$answer" == "2" ]
then
	repeat="false"
else
	echo "please enter a correct option"
fi

done

echo "hello fellow customer! What is your name?"
read name
echo " Hello $name , what would you like to buy?"
echo "please select  which items you would like : Apples , Bread , Eggs , Milk , Cheese"
read answer
if [ "$answer" == "Apples" ]
then
echo "You selected Apples,thatll be 1.00"
elif [ "$answer" == "Bread" ]
then
echo "thatll be 2.00"
#elif [ "answer" == "Eggs" ]
#then
#echo "You selected Eggs,thatll be 3.00"
#elif [ "$answer" == "Milk" ]
#then
#echo "You selected Milk,thatll be 4.00"
#elif [ "$answer" == "Cheese" ]
#echo "You selected Cheese, Thatll be 3.00" 
fi

