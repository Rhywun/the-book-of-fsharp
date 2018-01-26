type RgbColor = { R : byte; G : byte; B : byte }
open System.Drawing
type Color = { R : byte; G : byte; B : byte }

let red = { RgbColor.R = 255uy; G = 0uy; B = 0uy }
let green : Color = { R = 0uy; G = 255uy; B = 0uy}
