type MyException(message, category) =
  inherit exn(message)
  member x.Category = category
  override x.ToString() = sprintf "[%s] %s" category message

try
  raise <| MyException("blah", "debug")
with
  | :? MyException as ex -> printfn "My Exception: %s" <| ex.ToString() 
  | _ as ex -> printfn "General Exception: %s" <| ex.ToString()