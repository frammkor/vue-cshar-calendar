# Plan:

## Requirements

- 1. a class definition: There will be a base class Event
- 2. a second class definition: There will be a class Reminder that inherits from the Event class
- 3. a third class definition: There will be a class third type of event that inherits from the Event class
- 4. a struct definition: A struct might be used to convert the currency price of the event to/from dollars
- 5. an enumerated type: There will be an Enum that will represent the different types of events that exist
- 6. inheritance: There will be types of events that inherits from the base class Event
- 7. polymorphism: Event children will redefine some methods.
- 8. a second example of polymorphism: Event children will redefine some methods.
- 9. throwing an exception and properly catching it: When trying to init an event with wrong values and exemption will be thrown, triggering a http response with and error message
- 10. definition of your own generic datatype: I am not yet sure how this can fit my project, but I will find a implementation for it.
- 11. properties: Events will have many properties to init and read
- 12. a static member function: There might be a static member function that counts how many events where created
- 13. an interface: There will be a interface that show what can be done with an event
- 14. a second interface: There might be a user type/class that uses an interface.
- 15. use of at least two of the built-in generic collection types: List and Hash Tables will be used.

## Extra Credits

- working with file IO: Maybe I can program the server to write the event details down and return them to the user for he downloads it
- recursion: events can have inner events so recursion can be used to look/extract for inner events
- operator overloading: not sure how I can override any other method than the == operator for the events
