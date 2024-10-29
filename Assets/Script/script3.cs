using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       string [] funnyArray ={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
     int counter =0;
     string funnySentence;
     while (counter<7)
     {
     int arrayIndex1 =Random.Range(0,funnyArray.Length);
     string arrayWord0 = funnyArray[arrayIndex1]+" ";
     ++counter;
     int arrayIndex2 =Random.Range(0,funnyArray.Length);
     string arrayWord1 = funnyArray[arrayIndex2]+" ";
     ++counter;
     int arrayIndex3 =Random.Range(0,funnyArray.Length);
     string arrayWord2 = funnyArray[arrayIndex3]+" ";
     ++counter;
     int arrayIndex4 =Random.Range(0,funnyArray.Length);
     string arrayWord3 = funnyArray[arrayIndex4]+" ";
     ++counter;
     int arrayIndex5 =Random.Range(0,funnyArray.Length);
     string arrayWord4 = funnyArray[arrayIndex5]+" ";
     ++counter;
     int arrayIndex6 =Random.Range(0,funnyArray.Length);
     string arrayWord5 = funnyArray[arrayIndex6]+" ";
     ++counter;
     int arrayIndex7 =Random.Range(0,funnyArray.Length);
     string arrayWord6 = funnyArray[arrayIndex7]+" ";
     Debug.Log(funnySentence=arrayWord0+arrayWord0+arrayWord2+arrayWord3+arrayWord4+arrayWord5+arrayWord6);
     break;
    } 
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
