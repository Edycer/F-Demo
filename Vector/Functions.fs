﻿module Functions

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






///
/// Section 2
///   

//Partial Application

let isWithinRange range vector1 vector2 =
    distanceBetween vector1 vector2 < range
    

let vector1 = {X = 1.0<m>; Y = 0.0<m>; Z = 0.0<m>}
let vector2 = {X = 2.0<m>; Y = 0.0<m>; Z = 0.0<m>}
let vector3 = {X = 3.0<m>; Y = 0.0<m>; Z = 0.0<m>}
let vector4 = {X = 4.0<m>; Y = 0.0<m>; Z = 0.0<m>}

let spline = [vector1; vector2; vector3; vector4]
let sphereCenter = {X = 2.5<m>; Y = 0.5<m>; Z = 0.0<m>}
let range = 1.0<m>

//A Linq style mapping function can only take one argument. We can partially apply our isWithinRange function
//to give us a function that takes one argument in. 
let withinRange = List.map(isWithinRange range sphereCenter) spline

//Functional Composition


//Option

//Pattern Matching

//Disciminated Union?

//Type Provider