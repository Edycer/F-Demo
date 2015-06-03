module Functions

open Types

let subtract vector1 vector2 =
    let x = vector1.X - vector2.X
    let y = vector1.Y - vector2.Y
    let z = vector1.Z - vector2.Z
    { X = x; Y = y; Z = z }

let magnitude vector =
    sqrt ( (vector.X * vector.X) + (vector.Y * vector.Y) + (vector.Z * vector.Z) )

let distanceBetween vector1 vector2 = 
    subtract vector1 vector2 |>
    magnitude
