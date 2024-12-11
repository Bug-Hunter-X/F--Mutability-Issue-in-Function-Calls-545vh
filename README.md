# F# Mutability Issue in Function Calls

This example demonstrates a common issue in F# related to mutability and how it interacts with function calls.  The `add` function does not update the global mutable variables `x` and `y`, demonstrating the immutability of values within function scopes. 

## Bug
The `bug.fs` file contains code that attempts to modify global mutable variables within a function, which does not work as expected in F#.

## Solution
The `bugSolution.fs` file provides a correct solution that demonstrates how to correctly handle mutability and update values within a function or use different approaches that might achieve the same outcome (e.g. using a tuple).