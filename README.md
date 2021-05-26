# Triangle Calculator

## Purpose

This is a simple program made to quickly figure out what kind of triangle you got based on the value of the sides you have.

## Potential Tests

Even though this is a simple program, there can be made tests based on what kind of triangle is returned, i.e. the way the program is currently set up we could run tests where, dependant on what the function returns, we'd know if it failed or not.

e.g.  if all 3 sides are 10 we'd assume the triangle would be an equilateral triangle and therefore the function GuiTriangleCalculator would return 1 and since we'd then expect it to return 1 the test would succeed, essentially the same could be done for the other type of triangles.

We could also test whether or not it actually works the way we intend it too by suggesting that a triangle where all 3 sides are 10 would return 2 or 3, which would 'fail' the test assuming the function works the way we intent it and actually return a 1 insted of either 2 or 3

## Running the programs

the github project can be cloned to a local machine where both can be tested and should work. Currently I use JetBrains Rider as my IDE

Steps to follow for Rider:
1. Open Rider
2. find the "Get from VCS" button 
3. copy this URL: https://github.com/TheMagicalKing/trianglecalculator
4. paste it into Rider's URL.
5. Clone the repository
6. let the IDE Think

From here you can build the project and run it if you'd like, but this will open the console version of the Triangle Calculator in order to open the GUI version
you'd want to 

1. find the Edit Run/Debug configurations drop down in the top right corner of your IDE
2. from there change the Run configuration to TriangleCalculaterv2
3. run the process as you would normally
