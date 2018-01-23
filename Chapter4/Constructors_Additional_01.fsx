type Person (name, age) =
  do printfn "Creating person: %s (Age: %i)" name age
  new (name) = Person(name, 0)
  new () = Person("")
  member x.Name = name
  member x.Age = age

let p1 = Person()
let p2 = Person("Pat")
let p3 = Person("Pat", 46)
