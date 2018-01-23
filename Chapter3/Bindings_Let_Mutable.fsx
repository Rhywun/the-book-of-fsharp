let mutable name = "Dave"
name <- "Nadia"

(*
// Horrible, invalid code
let addSomeNumbers nums =
    let mutable sum = 0
    let add = (fun num -> sum <- sum + num)
    Array.iter (fun num -> add num) [| 1..10 |]
 *)
