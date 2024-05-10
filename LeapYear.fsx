// Usage:
// % dotnet fsi LeapYear.fsx 2024

// Long version of type annotation
// let isLeapYear : 
//         uint32 -> bool =
//     fun year ->
// Short version of type annotation
let isLeapYear (year:uint32) :bool =
        match year with
        | y when y%400u = 0u -> true
        | y when y%100u = 0u -> false
        | y when y%4u = 0u -> true
        | _ -> false

printfn "%A" (fsi.CommandLineArgs[1] |> uint32 |> isLeapYear)

// You can use this in shell script like this:
// if [ `dotnet fsi LeapYear.fsx 2024` = "true" ];then echo "Happy Leap Year"; else echo "Happy New Year";fi
//
// If you add the following alias to your .bashrc or .zshrc
// alias dnfsi='dotnet fsi'
// you can call the script just like this:
// % dnfsi LeapYear.fsx 2024
