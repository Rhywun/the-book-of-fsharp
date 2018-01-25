type Repository() =
  member __.Commit(files, desc, branch) =
    printfn "Committed %i files (%s) to \"%s\"" (List.length files) desc branch
  member __.Commit(files, desc) =
    __.Commit(files, desc, "default")
