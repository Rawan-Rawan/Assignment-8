using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     string [] funnyArray ={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
     int funnyArrayIndex =Random.Range(0,9);
     string space=" ";
     string funnySentence;
     Debug.Log(funnySentence=funnyArray[funnyArrayIndex]+space+funnyArray[funnyArrayIndex]+space+funnyArray[funnyArrayIndex]+space+funnyArray[funnyArrayIndex]+space+funnyArray[funnyArrayIndex]+space+funnyArray[funnyArrayIndex]+space+funnyArray[funnyArrayIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
