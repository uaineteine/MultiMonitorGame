# Multi Monitor Game <img src="https://raw.githubusercontent.com/uaineteine/MultiMonitorGame/release/icon/MMG.png" alt="drawing" width="60"/>

A game template for MonoGame that allows the window to be set to a monitor index from the constructor

## Getting Started

Add project to solution with reference to get started or via [NuGet](https://www.nuget.org/packages/Uaine.ScreenScraper/)

##### Use with game class inheritance::
```csharp
public class Game1 : MMG
{
    public(int monitorIndex) : base(monitorIndex)
    {
        //extra info here
    }
}
```

#### This project is packaged with libraries:

* CoordLibrary [ [github](https://github.com/uaineteine/Coord) | [bitbucket](https://bitbucket.org/uaineteinestudio/coordlibrary/) ] by [UaineTeine](https://bitbucket.org/uaineteinestudio/) - A coordinate library with extra functions
* ScreenInfo [ [github](https://github.com/uaineteine/ScreenInfo) | [bitbucket](https://bitbucket.org/uaineteinestudio/screeninfo) ] by [UaineTeine](https://bitbucket.org/uaineteinestudio/) - A C# .NET framework project to get screen information (size and position) based on the monitor index in a Windows environment

## Version 1.0.1

See the [changelog](changelog.txt) for details.

## Authors

* **Daniel Stamer-Squair** - *UaineTeine*

Copyright © 2020-2021 Daniel Stamer-Squair

## Donate

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/C0C43PQ0I)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

