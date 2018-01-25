open System

type Circle(diameter : float) =
  member __.Diameter = diameter
  member __.GetArea() =
    let r = diameter / 2.0
    Math.PI * (r ** 2.0)

let c = Circle 5.0
c.GetArea()
