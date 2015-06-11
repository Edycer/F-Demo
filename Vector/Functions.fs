module Functions

open Types

// Functions.

let subtract vector1 vector2 =
    let x = vector1.X - vector2.X
    let y = vector1.Y - vector2.Y
    let z = vector1.Z - vector2.Z
    { X = x; Y = y; Z = z }

let magnitude vector =
    sqrt ( (vector.X * vector.X) + (vector.Y * vector.Y) + (vector.Z * vector.Z) )

// Pipe 

let distanceBetween vector1 vector2 = 
    subtract vector1 vector2 |>
    magnitude


// List Module

let vector1 = {X = 1.0<m>; Y = 0.0<m>; Z = 0.0<m>}
let vector2 = {X = 2.0<m>; Y = 0.0<m>; Z = 0.0<m>}
let vecList = [vector1; vector2]


let vectorsMagnitudes vectors =
    List.map(fun v -> magnitude v) vectors

///
/// Section 2
///   

//Partial Application

let isWithinRange range vector1 vector2 =
    distanceBetween vector1 vector2 < range
    
let vector3 = {X = 3.0<m>; Y = 0.0<m>; Z = 0.0<m>}
let vector4 = {X = 4.0<m>; Y = 0.0<m>; Z = 0.0<m>}

let spline = [vector1; vector2; vector3; vector4]
let sphereCenter = {X = 2.5<m>; Y = 0.5<m>; Z = 0.0<m>}
let range = 1.0<m>

//A Linq style mapping function can only take one argument. We can partially apply our isWithinRange function
//to give us a function that takes one argument in. 
let withinRange = List.map(isWithinRange range sphereCenter) spline

//Pattern Matching
//We could use pattern matching for our within range function
let patternMatchWithinRange range vector1 vector2 = 
    match distanceBetween vector1 vector2 with
    | result when result <= range -> true
    | _ -> false

let withinRange2 = List.map(patternMatchWithinRange range sphereCenter) spline