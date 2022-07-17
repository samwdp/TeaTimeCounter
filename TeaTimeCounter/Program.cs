switch (args[0])
{
    case "increment":
        Increment();
        break;
    case "reset":
        Reset();
        break;
}

void Increment()
{
    try
    {
        var template = File.ReadAllText("Template.html");
        int.TryParse(File.ReadAllText("tea.txt"), out var count);
        count = count + 1;
        File.WriteAllText("tea.txt", count.ToString());
        var html = String.Format(template, count);
        File.WriteAllText("TeaTime.html", html);
    }
    catch (Exception e) { Console.WriteLine(e.Message); }
}

void Reset()
{
    var template = File.ReadAllText("Template.html");
    File.WriteAllText("tea.txt", "0");
    var html = String.Format(template, "0");
    File.WriteAllText("TeaTime.html", html);
}
