# Spark Notes

### Basically this is a linked list using composition by having the objects of type Condiments consume an object of type Beverage upon Condiment object creation. The Condiment object then saves a pointer to the Beverage object it consumed and when the Cost method on Condiment object gets invoked it also invockes the Cost method on the saved Beverage object (by utilizing its pointer).

### At this point we basically just iterate through our linked list (made through putting requirements on the constructor of our CondimentDecorator abstract class) and keep invoking the Cost method until we have no "next" Beverage object to invoke the Cost method on. Same logic goes for the description.

### We then unravel our way back to the thing that invoked the first Cost method via a series of returns. 
