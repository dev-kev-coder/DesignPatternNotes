# Strategy Pattern
Defines a family of algorithms, encapsulates each one, and make them interchangeable. Strategy lets the algorithm va;ry independently from clients that use it.

## Using Ducks
In the basic example of the Duck Strategy Pattern we are using an <span style="color:green">**abstract**</span> base class to help encapsulate the common behaviors relating to all types of ducks such as they all usually have the ability to Fly and Quack (the ones that don't still have the *action* to do so but it just ends up doing "nothing").

The <span style="color:green">**abstract**</span> Duck class has the common behaviors that all ducks hould have such as a FlyBehavoir and a QuackBehavior which will be represented as an <span style="color:yellow">**interface**</span> (**contract**) for any behavior object we wish to instantiate.

## Breaking Down the Contracts
The QuackBehavoir contract requires any concrete class (**behavior**) using the contract to have a method called Quack in it.

The FlyBehavoir contract requires any concrete class (**behavior**) using the contract to have a method called Fly in it.

The contracts allow us to ensure that any concrete class (**behavior**) using the <span style="color:yellow">**interfaces**</span> (**contract**) must utlize the Fly and Quack methods in our contract ensuring we don't get any invalid behaviors.

## Breaking Down the Abstract Duck Class
The <span style="color:green">**abstract**</span> Duck class has two contracted behaviors of Flying and Quacking that only really cares that the concrete classes have the requirements to fufill the contract. The methods withing the <span style="color:green">**abstract**</span> Duck class call upon those concrete classes end envokes their methods in order to perform the action.

Since we are using <span style="color:yellow">**interfaces**</span>  (**contracts**) as our data type for our behavior variables, this allows us to reassign behavoirs at runtime to our concrete Duck Classes (like the **MallardDuck**) instead of being chained to them at compile time. Hence why we also have methods to set the behavior variables in our <span style="color:green">**abstract**</span> Duck class.

# Breaking Down the Behavoirs
Really all the Behavoirs are just concrete classes that hold a/some algorithm/s that can be implemnted independently from the object that holds the behavior/algorithm

## Vocab
- [<span style="color:green">**abstract** </span>](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract)
- [<span style="color:yellow">**interface**</span>](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)