module Types

// Units of measure

[<Measure>] type m
[<Measure>] type cm
[<Measure>] type mm

//let mDivideCm = 3.0<m> - 3.0<cm>
let mSquared = 3.0<m> * 3.0<m>

// Object

type Vector3 =
    {
        X: float<m>
        Y: float<m>
        Z: float<m>
    }