let stateCapitals =
  Map [("Indiana", "Indianapolis")
       ("Michigan", "Lansing")
       ("Ohio", "Columbus")
       ("Kentucky", "Frankfort")
       ("Illinois", "Springfield")]

stateCapitals |> Map.tryFindKey (fun _ v -> v = "Indianapolis")
stateCapitals |> Map.tryFindKey (fun _ v -> v = "Olympia")
