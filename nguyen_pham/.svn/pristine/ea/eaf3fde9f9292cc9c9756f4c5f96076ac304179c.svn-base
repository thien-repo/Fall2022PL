module isFirstRepeated 

let rec FindFirstRepeated (input : string) = 
    let rec FindFirstRepeatedHelper input (seen : string) = 
        match input with
        | "" -> ""
        | _ -> 
            let firstChar = input.[0].ToString()
            if seen.Contains(firstChar) then firstChar
            else FindFirstRepeatedHelper (input.Substring(1)) (seen + firstChar)
        
    FindFirstRepeatedHelper input ""