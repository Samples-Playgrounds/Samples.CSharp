#!/usr/local/share/dotnet/dotnet run
#:package NXUI.Desktop@11.3.0

/*
dotnet run App.ca
*/
/*
chmod +x App.cs
./App.cs
*/
// Console.Write("Hi");


int count = 0;

Window Build()
    => Window(out var window)
        .Title("NXUI").Width(400).Height(300)
        .Content
            (
                StackPanel()
                    .Children
                        (
                            Button(out var button)
                                .Content("Welcome to Avalonia, please click me!"),
                            TextBox(out var tb1)
                                .Text("NXUI"),
                            TextBox()
                                .Text(window.BindTitle()),
                            Label()
                                .Content
                                    (
                                        button
                                            .ObserveOnClick()
                                            .Select(_ => ++count)
                                            .Select(x => $"You clicked {x} times.")
                                    )
                        )
            )
        .Title
            (
                tb1
                    .ObserveText()
                    .Select(x => x?.ToUpper())
            );

AppBuilder
    .Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("NXUI")
    .StartWithClassicDesktopLifetime(Build, args);
