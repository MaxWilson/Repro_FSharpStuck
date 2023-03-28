// For more information see https://aka.ms/fsharp-console-apps
let xyz() = 7

let inline f g = g()

printfn $"{f xyz}"
