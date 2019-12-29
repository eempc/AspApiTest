# Instructions

So you have created a model and scaffoled the CRUD pages as standard. Then you have used PMC to add a migration and update the database. Then tested the web interface to add a new (in this instance) Country

To do add an API controller is easy, do the following:

1. Add a folder called Controllers
2. Right click Controllers folder and select Add New Scaffolded Item
3. Select API Controller with CRUD with EF, select the model you want and the DbContext you will be using, pretty much like a normal Razor pages CRUD scaffold
4. It will create a controller, and VS automatically names it for you, in this case CountriesController.cs
5. In this controller, the tutorial says to modify a line in the POST, but it is not necessary, take a look at the commented line to see what it did
6. In Startup.cs you will need to add two lines:

`services.AddControllers();`

```diff
    app.UseEndpoints(endpoints => {
        endpoints.MapRazorPages();
+       endpoints.MapControllers();
    });
```
7. You can then view the entire list from the browser by `e.g. localhost/<port>/api/Countries`
8. You can then use PostMan to do a POST test, remember to select Body tab then Raw radio then JSON, before you write the contents of the JSON