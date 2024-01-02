namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://learn.microsoft.com/pt-br/dotnet/maui/tutorials/notes-app/?view=net-maui-8.0&tutorial-step=4";
    public string Message => "Esse aplicativo foi feito com base nos ensinamentos contidos em:";
}