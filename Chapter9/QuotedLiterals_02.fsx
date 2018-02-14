open Microsoft.FSharp.Quotations

let expr = <@ fun a b -> a * b @>
// val expr : Expr<(int -> int -> int)> =
//   Lambda (a, Lambda (b, Call (None, op_Multiply, [a, b])))

let expr' = <@ (*) @>;;
// val expr' : Expr<(int -> int -> int)> =
//   Lambda (x, Lambda (y, Call (None, op_Multiply, [x, y])))