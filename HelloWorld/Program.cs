

using Avalonia;
using Avalonia.Controls;
using Avalonia.Themes.Fluent;

Application app = Application.Current ?? AppBuilder.Configure<Application>().UsePlatformDetect().SetupWithoutStarting().Instance;
app.Styles.Add(new FluentTheme());
app.Run(new Window() { Title = "Avalonia Basic Example", Content = "Hello Avalonia!" });
