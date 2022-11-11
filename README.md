
# Data Types and Variables


With solving this problems, I practice working with variable types.




## Problem: Centuries to Nanoseconds

Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.

### Examples:

#### input:
5

#### output:

5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes = 15778454400 seconds = 15778454400000 milliseconds = 15778454400000000 microseconds = 15778454400000000000 nanoseconds

## Problem: Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than some fixed constant eps. 
You will receive two lines, each containing a floating-point number. Your task is to compare the values of the two numbers.

### Examples:
#### input: 
5.00000005

5.00000001
#### output:
True

## Problem: Convert Speed Units
Create a program to ask the user for a distance (in meters) and the time taken (as three numbers: hours, minutes, seconds), and print the speed, in meters per second, kilometers per hour and miles per hour.

### Input condition:
•	On first line, you receive – distance in meters
•	On second – hours
•	On third – minutes
•	On fourth – seconds
### Output condition: 
Every number in the output should be precise up to 6 digits after the floating point

•	On first line – speed in meters per second (m/s)

•	On second line – speed in kilometers per hour (km/h)

•	On third line – speed in miles per hour (mph)

### Examples
#### input:
10000

0

20

30
#### output:
8.130081

29.26829

18.19036

## Problem: Different Integers Size

Given an input integer, you must determine which primitive data types are capable of properly storing that input.

### Input condition
•	You receive N – integer which can be arbitrarily large or small

### Output condition
You must determine if the given primitives are capable of storing it. If yes, then print:
"{N} can fit in:
(* dataType)"

If there is more than one appropriate data type, print each one on its own line and order them by size
(sbyte < byte < short < ushort < int < uint < long).

If the number cannot be stored in one of the four aforementioned primitives, print the line: "
{N} can't fit in any type"

### Examples:
#### input:
1500000000
#### output:
1500000000 can fit in:

"* int"

"* uint"

"* long"


## Problem: Integer To Hex And Binary
Create a program to convert a decimal number to hexadecimal and binary number and print it.

### Examples:
#### input:
10
#### output:
A

1010

## Problem: Print Part of the ASCII Table
Write a program that prints part of the ASCII table of characters at the console.  On the first line of input you will receive the char index you should start with and on the second line - the index of the last character you should print.

### Examples:
#### input:
60

65
#### Output:
< = > ? @ A

## Problem: Thea The Photographer
Thea is a photographer. She takes pictures of people on special events. She is a good friend and you want to help her.
She wants to inform her clients when their pictures will be ready. Since the number of pictures is big and it requires time for editing (#nofilter, #allnatural) every single picture - you decide to write a program in order to help her.
Thea follows this pattern: first she takes all pictures. Then she goes through every single picture to filter these pictures that are considered "good". Then she needs to upload every single filtered picture to her cloud. She is considered ready when all filtered pictures are uploaded in her picture storage.
You will receive the number of pictures she had taken. Then the approximate time in seconds for every picture to be filtered. Then a filter factor – a percentage (integer number) of the total photos (rounded to the nearest bigger integer value e.g. 5.01 -> 6) that are good enough to be given to her clients (Photoshop may do miracles but Thea does not). Approximate time for every picture to be uploaded will be given again in seconds. Your task is: based on this input to display total time needed for her to be ready with the pictures in given below format.

### Input condition:
On the first line, you will receive an integer N – the number of pictures Thea had taken.

On the second line, you will receive an integer FT – the amount of time (filter time) in seconds that Thea will require to filter every single picture.

On the third line, you will receive an integer FF – the filter factor or the percentage of the total pictures that are considered “good” to be uploaded.

On the fourth line, you will receive an integer UT – the amount of time needed for every filtered picture to be uploaded to her storage.

The input will be in the described format, there is no need to check it explicitly.

### Output condition:
Print the amount of time Thea will need in order to have her pictures ready to be sent to her client in given format:

d:HH:mm:ss

d - days needed – starting from 0.

HH –  hours needed – from 00 to 24.

mm – minutes needed – from 00 to 59.

ss – minutes needed – from 00 to 59.

### Examples:
#### input: 
1000

1

50

1
#### output:
0:00:25:00

