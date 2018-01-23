open System

type Person (name : string, dob : DateTime) =
  let age = (DateTime.Now - dob).TotalDays / 365.25
  do printfn "Creating person: %s (Age: %f)" name age

  member x.Name = name
  member x.DateOfBirth = dob
  member x.Age = age

let p = Person("Pat", DateTime(1969, 4, 15))
