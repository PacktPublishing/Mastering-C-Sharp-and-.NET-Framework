module WindowsForms

open System
open System.Windows.Forms
open System.Drawing.Drawing2D

// Form definition
let form = new Form()
form.Width  <- 600
form.Height <- 350
form.Visible <- true 
form.BackColor <- System.Drawing.Color.AliceBlue
form.Text <- "Basic Form launch by F# code"

// Menu 
let mainMenu = form.Menu <- new MainMenu()
let firstItem = form.Menu.MenuItems.Add("&Home")
let exit  = new MenuItem("&Exit")
firstItem.MenuItems.Add(exit) |> ignore

// Button
let oneButton = new Button()
oneButton.Width <- 200
oneButton.Text <- "Click here"
oneButton.TextAlign <- System.Drawing.ContentAlignment.MiddleCenter
form.Controls.Add (oneButton)

// Assignment of events
oneButton.Click.Add(fun _ -> oneButton.Text <- "Text changed" )
exit.Click.Add(fun _ -> form.Close())

// Entry point
[<STAThread>]    
do Application.Run(form)

