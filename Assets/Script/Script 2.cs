using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     string [] funnyArray ={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
     int funnyArrayIndex1 =Random.Range(0,9);
     int funnyArrayIndex2 =Random.Range(0,9);
     int funnyArrayIndex3 =Random.Range(0,9);
     int funnyArrayIndex4 =Random.Range(0,9);
     int funnyArrayIndex5 =Random.Range(0,9);
     int funnyArrayIndex6 =Random.Range(0,9);
     int funnyArrayIndex7 =Random.Range(0,9);
     
     string space=" ";
     string funnySentence;
     Debug.Log(funnySentence=funnyArray[funnyArrayIndex1]+space+funnyArray[funnyArrayIndex2]+space+funnyArray[funnyArrayIndex3]+space+funnyArray[funnyArrayIndex4]+space+funnyArray[funnyArrayIndex5]+space+funnyArray[funnyArrayIndex6]+space+funnyArray[funnyArrayIndex7]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
