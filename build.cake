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
   NormalizeTextFile("./markdown_output/Manual.html");
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

    StartProcess(ResolvePandocPath(), processSettings);
}

private string ResolvePandocPath()
{
    var configured = Argument("pandocPath", EnvironmentVariable("PANDOC_PATH") ?? string.Empty).Trim('"');
    var candidates = new List<string>();

    if (!string.IsNullOrWhiteSpace(configured))
    {
        candidates.Add(configured);
    }

    candidates.Add(@"C:\Program Files\Pandoc\pandoc.exe");
    candidates.Add(@"C:\Program Files (x86)\Pandoc\pandoc.exe");

    var localAppData = EnvironmentVariable("LOCALAPPDATA") ?? string.Empty;
    if (!string.IsNullOrWhiteSpace(localAppData))
    {
        candidates.Add(System.IO.Path.Combine(localAppData, "Pandoc", "pandoc.exe"));
    }

    var path = EnvironmentVariable("PATH") ?? string.Empty;
    foreach (var dir in path.Split(new [] { ';' }, StringSplitOptions.RemoveEmptyEntries))
    {
        candidates.Add(System.IO.Path.Combine(dir.Trim('"'), "pandoc.exe"));
    }

    foreach (var candidate in candidates)
    {
        if (System.IO.File.Exists(candidate))
        {
            return candidate;
        }
    }

    throw new Exception("Pandoc executable not found. Install Pandoc, set PANDOC_PATH, or pass -pandocPath=\"C:\\Path\\To\\pandoc.exe\".");
}

private void NormalizeTextFile(string path)
{
    var text = System.IO.File.ReadAllText(path);
    text = text.Replace("\r\n", "\n").Replace("\r", "\n");

    var lines = text.Split(new [] { '\n' });
    for (var i = 0; i < lines.Length; i++)
    {
        lines[i] = lines[i].TrimEnd();
    }

    var normalized = string.Join("\n", lines).TrimEnd() + "\n";
    System.IO.File.WriteAllText(path, normalized, new System.Text.UTF8Encoding(false));
}
