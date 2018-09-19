///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

///////////////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
///////////////////////////////////////////////////////////////////////////////

Setup(ctx =>
{
   // Executed BEFORE the first task.
   Information("Running tasks...");
});

Teardown(ctx =>
{
   // Executed AFTER the last task.
   Information("Finished running tasks.");
});

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Default")
.Does(() => {
   Pandoc(
       "-s",
       "-f", "markdown", 
       "-t", "html5", 
       "-o", "./markdown_output/Manual.html", 
       "./markdown_output/Manual.md", 
       "--css=./css/style.css",
       "--lua-filter=links-to-html.lua");
});

RunTarget(target);

private void ViewPage()
{
    var processSettings = new ProcessSettings();

    var builder = new ProcessArgumentBuilder();

    processSettings.Arguments = builder;

    StartProcess(@"./markdown_output/Manual.html", processSettings);
}

private void Pandoc(params string[] arguments)
{
    var processSettings = new ProcessSettings();

    var builder = new ProcessArgumentBuilder();

    foreach(var a in arguments) builder.Append(a);

    processSettings.Arguments = builder;

    StartProcess(@"C:\Program Files (x86)\Pandoc\pandoc.exe", processSettings);
}