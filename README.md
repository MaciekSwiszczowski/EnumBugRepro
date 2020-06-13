# EnumBugRepro
A repro for a WPF issue: https://github.com/dotnet/wpf/issues/3137

Contains two indentical projects, for .NET Core and .NET Framework.

- check `ResourceDictionary.xaml` - to see the xaml causing issues
- check `MainWindow.xaml.cs` - to see the code that checks if resources are being found.
