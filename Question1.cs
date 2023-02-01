using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question1 : MonoBehaviour
{
    int[] ints = new int[4] { 5, 3, 6, 2 };
    int lowestValue = 1000001;

    public int LowestIntNotIncluded(int[] A)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < A.Length; i++) // go through the array
        {
            if (A[i] > 0) // if the value is above zero, continue
            {
                set.Add(A[i]); // add the above zero value to a set
            }
        }
        for (int i = 1; i <= A.Length + 1; i++) // starting from 1 (the lowest possible value) continue up for the length of the array
        {
            if (!set.Contains(i)) // if the index value is not included in the array
            {
                if (i < lowestValue) // and the index value is lower than the current lowest value from the array
                    lowestValue = i; // the index value replaces the value of the previous lowest value
            }
        }
        if (set.Count == 0) // if no numbers are above zero, return 1
        {
            return 1;
        }
        return lowestValue;
    }

    private void Start()
    {
        LowestIntNotIncluded(ints);
    }
}
