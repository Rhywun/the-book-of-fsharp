open System.Drawing

module Drawing =
  let w, h = using (Image.FromFile(@"/Users/pat/Pictures/me/foto-caravaggio3.jpg"))
                   (fun img -> (img.Width, img.Height))
  do
    printfn "Dimensions: %i x %i" w h
