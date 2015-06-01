// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
//module Application
open System
open System.Collections.Generic
open System.CodeDom
open System.Windows


let loadWindows() =
    let resourceLocator = new Uri("/HelloWorldWPF;component/MainWindow.xaml", UriKind.Relative)
    let window = Application.LoadComponent(resourceLocator) :?> Window
    (window.FindName("clickButton") :?> Button).Click.Add(
        fun _ -> MessageBox.Show("Hello World") |> ignore)
    window

[<STAThread>]
(new Applicatiom()).Run(loadWindow()) |> ignore
//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0 // return an integer exit code
