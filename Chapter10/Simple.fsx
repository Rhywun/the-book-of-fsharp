query { for n in [1..100] do
        where (n % 2 = 0)
        sortByDescending n }
