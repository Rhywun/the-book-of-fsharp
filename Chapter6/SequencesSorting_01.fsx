let rand = System.Random()
printfn "%A" Seq.init 10 (fun _ -> rand.Next 10) |> Seq.sort
