# CSharp-Things--LearningPolymorphism

Solved exercise to learn Inherit and Polymorphism  [C#-things, C#-exercises, learning-C#]

## EXERCISE ORDER

Make a program to read N data
products (not supplied by the user). At end,
show the price tag of each product on the
same order as they were typed.
Every product has name and price. Products
imported have a customs duty, and
Used products have date of manufacture.
These specific data should be
added to the price tag as
example (next page). For products
imported, the tax and customs should be
added to the final price of the product.
Please implement the program as
next project.

## UML Diagram

![UML Diagram](https://github.com/GiuseppeVarriale/CSharpt-Things--Inherit-And-Polymorphism/raw/master/img/UML.PNG)

## Input

Enter the number of products: **3**  
Product #1 data:  
Common, used or imported (c/u/i)? **i**  
Name: **Tablet**  
Price: **260.00**  
Customs fee: **20.00**  
Product #2 data:  
Common, used or imported (c/u/i)? **c**  
Name: **Notebook**  
Price: **1100.00**  
Product #3 data:  
Common, used or imported (c/u/i)? **u**  
Name: **Iphone**  
Price: **400.00**  
Manufacture date (DD/MM/YYYY): **15/03/2017**  

## Expected Output

```console
PRICE TAGS:
Tablet $ 280.00 (Customs fee: $ 20.00)
Notebook $ 1100.00
Iphone (used) $ 400.00 (Manufacture date: 15/03/2017) 
```
