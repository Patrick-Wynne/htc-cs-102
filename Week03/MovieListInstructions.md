# Movie List Application
Create a visual application that holds a list of movies. Create a new WPF application, and then create a new class called `Movie` in its own file (`Movie.cs`).

## Requirements for Movie class
The class must contain the following:

### Fields/Variables
- Title
- Release year (4 digit year)

### Methods
- `ShowDetails`: this method should show a message containing details about the movie (information from the fields above)
    - Use the `MessageBox.Show` function to show the message

### Constructor
Create a basic constructor that takes in a title and releaseYear, and intializes the data to the fields on the object.

<br>

## Requirements for the Main Window
The `MainWindow` class should keep track of a `List` of movies. Remember, you can create a list using something like
```
List<int> ints = new List<int>();
```

In our case, we can create a list of `Movie`s instead by replacing `int` with `Movie`. The user should be able to add to this list of movies, and show details about each movie in the current list of movies.

### User Interface
The application must contain the following:
- A Title field (label and text box)
- A Release Year field (label and text box)
- An Add button
- A Show All Movies button

The user interface does not have to look great, but it should be functional.

### Individual Activity - Button functionality
#### Add
When the user clicks the "Add" button, a new `Movie` object should be created and added to the list of `Movie`s. The information for the movie should be taken from the fields in the user interface. Assume the user will always properly enter numeric values for Release Year. Once the movie is added, the fields should all clear their values.

#### Show All Movies
For each movie in the movie list, show a message to the user containing all of the information about the movie. Leverage the `ShowDetails` method on the `Movie` class to accomplish this.