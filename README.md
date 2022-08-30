# kata_optim
Could you please complete and return the answer to this programming question

It should compile and work. You can use the internet as you would normally in your daily work life but all the code you submit should be your own.

Please only send 1 .cs file with all your code.


Write a method that will produce three (3) different strings (different string values) that have the same hash code such that:
```
stringA.GetHashCode() == stringB.GetHashCode() && !String.Equals(stringA, stringB) &&

stringB.GetHashCode() == stringC.GetHashCode() && !String.Equals(stringB, stringC) &&

!String.Equals(stringA, stringC)
```
