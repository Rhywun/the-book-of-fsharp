[<Struct>]
type Circle(diameter : float) =
  member __.GetRadius() = diameter / 2.0
  member __.Diameter = diameter
  member __.GetArea() = System.Math.PI * (__.GetRadius() ** 2.0)
