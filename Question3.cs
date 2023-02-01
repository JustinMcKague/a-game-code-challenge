using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question3 : MonoBehaviour
{
    int[] A = new int[10] { 0, 1, 0, 1, 1, 1, 0, 0, 1, 1 };

    public int NumberOfCarsPassed(int[] A)
    {
        int carsPassed = 0;
        int multiplier = 0;

        foreach (int car in A) // cycle through values in the array
        {
            if (car == 0) // if a car is going east
            {
                multiplier += 1; // give the car going east a value to add to our carsPassed variable
            }
            if (multiplier > 0) // if there are cars going east in the array
            {
                if (car == 1) // if a car is going west
                {
                    carsPassed += multiplier; // add every car going west to the count if it follows after the car going east in the array
                    if (carsPassed > 1000000000) // if the amount of cars exceeds 1 billion return -1
                    {
                        return -1;
                    }
                }
            }
        }
        Debug.Log(carsPassed);
        return carsPassed;
    }

    // Start is called before the first frame update
    void Start()
    {
        NumberOfCarsPassed(A);
    }
}
