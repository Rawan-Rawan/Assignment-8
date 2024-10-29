using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     string [] funnyArray ={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
     int funnyArrayIndex =Random.Range(0,9);
     string space=" ";
     string funnySentence;
     Debug.Log(funnySentence=funnyArray[0]+space+funnyArray[1]+space+funnyArray[2]+space+funnyArray[3]+space+funnyArray[4]+space+funnyArray[5]+space+funnyArray[6]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
