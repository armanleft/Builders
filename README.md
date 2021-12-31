# Builders
How to use builders for complex objects, directly or loosly coupled

Hello there. One of my friends asked me how to build a complex object that has another complex object inside. So, this sample is for him and every one around web who was searched but could not find proper answer.
I think the very first purpose of builder is to make building an object more Readable And make it easy for the others to build.
Another purpose is to make it Testable!
In this project I have a "MyObject" that has 6 properties and one "InsideObject" with 6 properties With List Of "ValueObjects" that has two property.
First I write a simple builders and use them directly inside program, but then I think what would happen if some one wanted to use the objects loosly coupled? It is a common demmand on DDD approach, so I add another folder with looslyCoupled name.
Download it, Enjoy it.
Best Regards
