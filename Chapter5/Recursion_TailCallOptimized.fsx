let factorial v =
  let rec factorial' c p =
    match c with | 0L -> p
                 | _  -> factorial' <| c - 1L <| c * p
  factorial' v 1L

factorial 5L
