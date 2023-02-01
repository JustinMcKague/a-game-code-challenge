using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Question2 : MonoBehaviour
{
    int K = 0; //Time elapsed
    int X = 5; //Final position

    int[] A = new int[8] { 1, 2, 5, 2, 3, 3, 2, 3 };

    public int WhenCanFrogCross(int X, int[] A)
    {
        int highestValue = A.Max();
        HashSet<int> set = new HashSet<int>();

        HashSet<int> numbersInSequence = new HashSet<int>();

        // if the frog can never reach the final position return -1
        if (highestValue < X)
        {
            Debug.Log($"frog cannot cross the river {-1}");
            return -1;
        }

        // run through the list and find the first instance of a new number
        for (int i = 0; i < A.Length; i++)
        {
            if (!numbersInSequence.Contains(A[i]))
            {
                numbersInSequence.Add(A[i]); // add the new number to a set
                K = i; // last new number added is K
            }
        }

        for (int i = 1; i < X + 1; i++)
        {
            set.Add(i); // store needed leaf positions as a set
        }

        // if the frog can never cross the river return -1
        for (int i = 0; i < X; i++)
        {
            int[] arraySet = set.ToArray(); // convert the leaf positions set to an array
            if (!A.Contains(arraySet[i])) // if there is no instance of a leaf position in the array provided return -1
            {
                Debug.Log($"frog cannot cross the river {-1}");
                return -1;
            }
        }
        Debug.Log(K);
        return K;
    }

    private void Start()
    {
        WhenCanFrogCross(X, A);
    }
}
