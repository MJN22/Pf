https://www.youtube.com/watch?v=AzD_WibPGDc

was able to query sql in db then bring over that query
name for parmeters are @pvar name

string query = query string here
make sure ur connected

SqlCommand cmd = new SqlCommand(query, databasecontext here?)

then call that new cmd object and add parms to it
cmd.Parameters.AddWithValue(@var, obj.var)
cmd.Parameters.AddWithValue(@var2, obj.var2) can do this for multiple values just change the var

SqlDataReader reader = cmd.ExecuteReader();
int
make sure close connect prob just use using statement

can save object to session 
HttpContext.Session.SetString("var", var.ToString();) this writes to the session
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/app-state?tabs=aspnetcore2x&view=aspnetcore-2.2

HttpContext.Session.GetString("var"); this reads from the session
i need to utilize pages more
on return of db write to object