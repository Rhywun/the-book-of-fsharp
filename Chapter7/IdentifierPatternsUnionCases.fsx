type Radius = float
type Width = float
type Height = float
type Side1 = float
type Side2 = float
type Side3 = float

type Shape =
| Circle    of Radius
| Rectangle of Width * Height
| Triangle  of Side1 * Side2 * Side3

let getPerimeter =
  function
  | Circle(r)            -> 2.0 * System.Math.PI * r
  | Rectangle(w, h)      -> 2.0 * (w + h)
  | Triangle(l1, l2, l3) -> l1 + l2 + l3
