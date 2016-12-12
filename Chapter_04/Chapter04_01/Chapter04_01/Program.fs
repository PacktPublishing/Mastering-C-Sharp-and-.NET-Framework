// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let a = 1 + 2
let b = a * 3
printfn "Expression a equals to %i" a
printfn "Expression b equals to %i" b
printfn "So, expression b (%i) depends on a (%i)" b a

let hypo (x:float) (y:float) = 
    let legsSquare = x*x + y*y
    // System.Math.Sqrt(legsSquare) 
    sqrt(legsSquare)  // an alias of the former
printfn "The hypotenuse for legs 3 and 4 is: %f" (hypo 3.0 4.0)


/// A list of the numbers from 0 to 99
let sampleNumbers = [ 0 .. 99 ]

/// A sequence
seq {5..3..15} |> ignore

/// Lists
let sampleTableOfSquares = [ for i in 0 .. 99 -> (i, i*i) ]

let initialList = [9.0; 4.0; 1.0]
let sqrootList = List.map (fun x -> sqrt(x)) initialList

printfn "Square root list: %A" sqrootList

/// Functions
let func1 x = x*x + 3

let result1 = func1 4573
printfn "The result of squaring the integer 4573 and adding 3 is %d" result1

let func2 (x:int) = 2*x*x - x/5 + 3

let func3 x = 
    if x < 100.0 then 
       2.0*x*x - x/5.0 + 3.0
    else 
       2.0*x*x + x/5.0 - 37.0

let daysList = 
        [ for month in 1 .. 12 do
              for day in 1 .. System.DateTime.DaysInMonth(2012, month) do 
                  yield System.DateTime(2012, month, day) ]

/// Pipeline operator
let sum a b = a + b
let chainOfSums = sum 1 2 |> sum 3 |> sum 4

let numberList = [ 1 .. 1000 ]  /// list of integers from 1 to 1000
let squares = 
    numberList 
    |> List.map (fun x -> x*x)

/// Computes the sum of the squares of the numbers divisible by 3.
let sumOfSquares = 
    numberList
    |> List.filter (fun x -> x % 3 = 0)
    |> List.sumBy (fun x -> x * x)

/// Pattern matching
let rec factorial n =
    match n with
    | 0 -> 1
    | _ -> n * factorial (n - 1)
let factorial5 = factorial 5 

/// Classes and types
type numberOfEntries = int
type response = string * int 

// define a record type
type ContactCard = 
    { Name     : string;
        Phone    : string;
        Verified : bool }
let contact1 = { Name = "Alf" ; Phone = "(206) 555-0157" ; Verified = false }
let contact2 = { contact1 with Phone = "(206) 555-0112"; Verified = true }

/// Converts a 'ContactCard' object to a string
let showCard c = 
        c.Name + " Phone: " + c.Phone + (if not c.Verified then " (unverified)" else "")
let stringifyedCard = showCard contact1

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

