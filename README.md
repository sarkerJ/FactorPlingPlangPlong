# PlingPlangPlong Project

### Project Goal

The goal of this project was to create an application that returns a string which depended on whether it was a factor of 3 , 5 or 7. The string value returned from the method can vary between Pling, Plang, Plong or any other combination of these 3 or be the input value given to us but as a string. For example :

- 28 is a factor of 7 therefore it would return a simple 'Plong'
- 30 is a factor of 3 and 5 therefore it would return a simple  'PlingPlang'
- 34 is a **not** factor of any of the 3 mentioned therefore it would return a simple  '34'

### Tools Used

The main tools used for this project is the NUnit Test Project (.NET Core) framework and a StringBuilder which was used to store the result of the method. One of the main reasons for using a StringBuilder is because you able to append to the same string value instead reassigning a string variable a new string value. Normal string variables are immutable which is why a StringBuilder can be used instead in order to overcome that. 

With the NUnit Framework above two Nuget Packages were used to test the the method response, these are:

*  NUnit 

* NUnit3Adapter 

