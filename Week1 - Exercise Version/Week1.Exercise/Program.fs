module Program

open Exercise

[<EntryPoint>]
let main args = 
    ExerciseOptional.executeExercise()
    System.Console.ReadLine() |> ignore
    0