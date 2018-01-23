// Automatic generalization
let toTriple a b c = (a, b, c)

// Explicit generalization
let toTriple' (a : 'A) (b : 'B) (c : 'C) = (a, b, c)

// Constraints
let myFuncWithSubtypeConstraint (stream : 'T when 'T :> System.IO.Stream) = ()
let inline myFuncWithNullnessConstraint (a : ^T when ^T : null) = ()

// etc. see book for the rest

// Flexible types (shortcut for subtype constraint)
let myFuncWithFlexibleType (stream : #System.IO.Stream) = ()

// Wildcard pattern
let printList (l : List<_>) = l |> List.iter (fun i -> printfn "%O" i)
printList [1; 2; 3; 4]
