type Circle(diameter : float) =
  member private __.GetRadius() = diameter / 2.0
  member __.Diameter = diameter
  member __.GetArea() = System.Math.PI * (__.GetRadius() ** 2.0)

let c = Circle 5.0
c.GetArea()
