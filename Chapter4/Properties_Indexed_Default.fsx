type Sentence(text : string) =
  let mutable words = text.Split ' '
  let mutable text = text
  member val Text = text with get, set
  member x.Item
    with get i = words.[i]
    and set i v =
      words.[i] <- v
      text <- System.String.Join(" ", words)

let s = Sentence "Don't forget to drink your Ovaltine"
s.[1] <- "remember"
