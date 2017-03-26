namespace UsefulTools

open System

type Tools() = 
    static let random = Random(0)

    static member RandomSubsetBySize n (a : 'a array) = 
        match a.Length with
        | count when count <= n -> a
        | count ->  
            let randoms = 
                Seq.initInfinite (fun _ -> random.Next(count))
                |> Seq.distinct
                |> Seq.take n
                |> Seq.toArray
            randoms 
            |> Array.map (fun i -> a.[i]) 

        
