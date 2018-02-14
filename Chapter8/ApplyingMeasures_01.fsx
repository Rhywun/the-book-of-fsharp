[<Measure>] type ft
[<Measure>] type sqft = ft ^ 2;;

let length = 10.0<ft>
let area = 10.0<sqft>

//

open Microsoft.FSharp.Data.UnitSystems.SI.UnitSymbols

let length' = 1.5<m>
let area' = 20<m^2>
