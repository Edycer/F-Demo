module Types

[<Measure>] type m
[<Measure>] type cm
[<Measure>] type mm

//type Vector3 =
//    struct
//        val X: float<m>
//        val Y: float<m>
//        val Z: float<m>
//        new (x, y, z) = {X = x; Y = y; Z = z}
//    end

type Vector3 =
    {
        X: float<m>
        Y: float<m>
        Z: float<m>
    }