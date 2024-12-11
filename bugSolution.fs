let add x y = x + y

let mutable x = 10
let mutable y = 20

let z = add x y
printf "%d\n" z

// Correct way to update the mutable variables
x <- x + 5
y <- y + 5
printf "%d\n" (add x y)

//Alternative solution using tuples
let updateAndAdd (x,y) = let x = x + 5 in let y = y + 5 in (x,y,x+y) 
let (x1,y1,z1) = updateAndAdd (x,y)
printf "x: %d, y: %d, sum: %d\n" x1 y1 z1