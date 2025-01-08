# Observer Pattern
Defins a one-to-many dependency between objects so that one object changes state, all its dependents are notified and updated automatically.

For example: 
* The newsletter you have subscribed to got has a new article for you.
* The youtube channel you subscribed to has a new video for you to watch.

To me the **Observer Pattern** (in a summed up way) is something that is being watched along with the things that need to watch it.

# Using WeatherData
In the example of the *WeatherData Observer Pattern* we are using an **Observable Class** as a base class to help encapsulate the common behaviors relating to all types of **Observable Objects** which should all have common behavoirs.

So **WeatherData "is-a" Obseravble** type of relationship.

# Using CurrentConditionsDisplay
The **CurrentConditionsDisplay Object** is subscribed to the **WeatherData Object** so when something changes in the **WeatherData Object** then all the things that have *subscribed* to it will be notified so they can updated themselves

Here our **CurrentConditionsDisplay** is our **Observer** and we are utilizing *composition* in order for the **Observer** to subscribe itself to any changes in the **Observable**

So **CurrentConditionsDisplay "has-a" Obseravble** type of relationship.

For example, if the temperature had changed in **WeatherData** then **CurrentConditionsDisplay** will get notified that it needs to update itself since it had subscribed to **WeatherData** 


# Breaking Down the Classes/Interfaces

## ISubject Interface
We created our general interface that we would need. In this example we cared about setting up the general requirements an **Object** would need to meet in order to be an **Observable (ISubject)**.

Basic methods that an **Observable** should have is how to *register/remove*, *notify* **Observers** (someting in our **Observable** changed), and optionally some methods that allow the **Object** to set when something has changed.

## IObserver Interface
This interface has really only one requirement which is an *Update* method. So any **Observer Object** needs a way to update itself. How it implements that is not important so long as it has an implemantation of *Update* and it accepts an **Object** that *"is-a"* **Observable** as its paramter.

Its important to have an *Update* method since this is what our **Observable Object** would be looking to invoke when it notifys the **Objects** registered to it.

## IDisplay Interface
This interface has really only one requirement which is a *Display* method. So any **Display Object** needs a way to *Diplay* data of interest. How it implements that is not important.

## Observable Object
Here we are abstracting away what might be different in each **Observable** which would be the *state*. So this **Observable Objects** takes care of all the requirements set by the **ISubject Interface**. This is important since our **IObserver Interface** will expect to receive an **Object** that *"is-a"* **Observable**.

Here is where we really handle the properites and behavoirs for notifying, registering/removing, and opitionally setting when something has changed or not.

The way we are keeping track of the **Objects** registered to the **Observerable Object** is through (what we have chose) a simple list that only check for the basic requirements of the **IObserver Interface**.

## WeatherData Object
Now we're getting into being able to use all things we've been setting up. The **WeatherData Object** manages the state of anything relating to weathter data as well as having methods to access data from itself (example shows with public properties and methods that returns value of private fields).

 Its important to not that our **WeatherData Object** *inherits* from our **Observable Object**. 

So **WeatherData "is-a" Obseravble** type of relationship.

Since we are inheriting *properties* and *behavoirs* from our **Observable Object** our **WeatherData Object** now has the ability to do everything mention in the [**Observable Object** section](#observable-object) without needing to bloat our **WeatherData Object**.

## CurrentConditionsDisplay Object 
The **CurrentConditionsDisplay Object** is used for the purposes of displaying data. We are favoring composition by making the constructor of our **CurrentConditionsDisplay Object** require and object that *"is-a"* **Observable Object**. That way we have now allowed our **CurrentConditionsDisplay Object** to register itself to the **WeatherData Object**.

**CurrentConditionsDisplay Object** has its own *Update* method which checks to make sure that that the **Observable Object** *"is-a"* **WeatherData Object**. If it is then **CurrentConditionsDisplay Object** pulls out the *state* of interest from **WeatherData Object**.