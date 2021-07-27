Description

Suppose there is a long straight road between cities A and B with nonnegative integer coordinates c_A and c_B, respectively. There are several petrol stations on the road. The location of each station is described by its nonnegative integer coordinate s_i.
Note: Two stations can have the same coordinates.
We are going to drive from city A to city B. Our car’s tank can hold petrol for k miles. At the beginning of the trip, the tank is full. During the route, we can stop at stations to refill the petrol. The goal is to minimize the number of stops along the route.

Input
 Coordinate c_A of city A, a nonnegative integer.
 Coordinate c_B of city B, a nonnegative integer.
 Quantity of miles k that we can drive without refilling.
 Quantity n of the petrol stations, a nonnegative integer.
 Coordinate s_i for each station, a nonnegative integer.

Output
An integer, the minimum quantity of stops during the trip. If it is impossible to get from A to B, return  -1.

Complexity:
O(n*log(n)).

Additional memory:
O(1).

Tags: #Greedy algorithm


Project code: PetrolStations

Requirements 

Examples:
Input:
3 16 5 4 15 10 12 8
Output:
2

Input:
3 16 15 4 15 10 12 8
Output:
0

Input:
3 18 5 3 12 10 15
Output:
-1

Calculations
Example 1. The start point is {3}, the end point is {16}, and the petrol station’s coordinates are {15,10,12,8}. It is possible to drive 5 km without refilling. Since the car needs to travel 13 km, at least 2 stops are required. The trip can be made with the stops at stations {8} and {12}.
Example 2. It is required to drive 13 km, and there is petrol for 15 km in a car’s tank. The trip can be made without stops.
Example 3. The start point is {3} and the petrol station’s coordinates are {12, 10, 15}. It is possible to drive 5 km without refilling. So, the farthest point that can be reached is {8} that is less than the closest station’s coordinate ({10}). Thus, the finish point cannot be reached.
