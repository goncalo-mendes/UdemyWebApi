# Notes

this course is from udemy im currently learning c# as a backend tool

first one comand for webapi
```bash
dotnet new webapi
```

and to create a gitignore
```bash
dotnet new gitignore
```
## MVC (Model-View-Controller)

### Model
you have model thats is the data you have like a server data

```c#
public class character
{
    public int Id {get; set;};
    public string Name {get; set;};
    public int Strength {get; set;};
    //etc...
```
### View

Its a representation of the data(model) you have

### Controller

Make the hard work and its jobs its to manipulate the model

![Mvc](https://imgur.com/1MfqiAk.png)

In models you can put a default value like this
```c#
public string Name { get; set; } = 'Mendes'
```