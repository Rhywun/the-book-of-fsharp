[<Literal>]
let Zero = 0

[<Literal>]
let One = 1

[<Literal>]
let Two = 2

[<Literal>]
let Three = 3

let numberToString =
  function
  | Zero -> "zero"
  | One -> "one"
  | Two -> "two"
  | Three -> "three"
  | _ -> "unknown"
