using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    // we need an array we can access from the inspector
    public float[] BoxPositions;

    // Start is called before the first frame update
    void Start()
    {
        // if assigned here, it won't be overwritten by the inspector-value
        BoxPositions = new float[5];


        for (var i = 0; i < BoxPositions.Length; i++)
        {
            BoxPositions[i] = 1 + 0.5f*i; 
            //BoxPositions[i] = (i / 2.0f) + 1.0f; // f(x) = x*c + d ... c = 0,5, d = 1
        }

        /*
        var number = 5;
        var text = "Hello";
        var floatingPointNumber = 10.12f;

        var vectorPosition = new Vector3(1, 2, 3);
        // why do we need new Vector3? Vector is a class, to instantiate from the class we need the new-keyword

        number = 3;
        number = 10;

        // Array - new-keyword
        int[] numbers = new int[5];

        // to access the array, we use indices - it starts with 0
        numbers[0] = 5;
        numbers[1] = 3;
        numbers[2] = 8;
        numbers[3] = -10;
        numbers[4] = 9;

        var sum = numbers[1] + numbers[3];
        Debug.Log("Our sum is: " + sum);

        var totalsum = 0;

        // output all elements from the array using a for loop
        for (var i=1; i < numbers.Length; i++)
        {
            Debug.Log("Array index: " + i);
            Debug.Log("Array value: " + numbers[i]);

            totalsum = totalsum + numbers[i];
        }

        // output all elements from the array using a foreach loop // DOWNSIDE no Index! so can't put values back to index
        foreach (var n in numbers)
        {
            Debug.Log("Value using foreach: " + n);
            
            totalsum += n;
            Debug.Log("the total sum of the values in the array is: " + totalsum);
        }
        */



        
    }

    // Update is called once per frame
    void Update()
    {
        for (var i = 0; i < BoxPositions.Length && i < transform.childCount; i++)
        {
                var currentBox = transform.GetChild(i);

                //currentBox.position.y = BoxPositions[i];

                currentBox.position = new Vector3(
                    currentBox.position.x,
                    BoxPositions[i],
                    currentBox.position.z
                );
        }    
    }
}
