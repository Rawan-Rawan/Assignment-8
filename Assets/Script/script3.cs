using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       string [] funnyArray ={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
     
     string funnySentence;
     while (true)
     {
     int arrayIndex1 =Random.Range(0,funnyArray.Length);
     string arrayWord1 = funnyArray[arrayIndex1]+" ";
    
     int arrayIndex2 =Random.Range(0,funnyArray.Length);
     string arrayWord2 = funnyArray[arrayIndex2]+" ";
     if (arrayWord2== arrayWord1)continue;

     int arrayIndex3 =Random.Range(0,funnyArray.Length);
     string arrayWord3 = funnyArray[arrayIndex3]+" ";
     if (arrayWord3==arrayWord1)continue;
     if (arrayWord3==arrayWord2)continue;

     int arrayIndex4 =Random.Range(0,funnyArray.Length);
     string arrayWord4 = funnyArray[arrayIndex4]+" ";
     if (arrayWord4==arrayWord1)continue;
     if (arrayWord4==arrayWord2)continue;
     if (arrayWord4==arrayWord3)continue;

     int arrayIndex5 =Random.Range(0,funnyArray.Length);
     string arrayWord5 = funnyArray[arrayIndex5]+" ";
     if (arrayWord5==arrayWord1)continue;
     if (arrayWord5==arrayWord2)continue;
     if (arrayWord5==arrayWord3)continue;
     if (arrayWord5==arrayWord4)continue;

     int arrayIndex6 =Random.Range(0,funnyArray.Length);
     string arrayWord6 = funnyArray[arrayIndex6]+" ";
     if (arrayWord6==arrayWord1)continue;
     if (arrayWord6==arrayWord2)continue;
     if (arrayWord6==arrayWord3)continue;
     if (arrayWord6==arrayWord4)continue;
     if (arrayWord6==arrayWord5)continue;
   
     int arrayIndex7 =Random.Range(0,funnyArray.Length);
     string arrayWord7 = funnyArray[arrayIndex7]+" ";
     if (arrayWord7==arrayWord1)continue;
     if (arrayWord7==arrayWord2)continue;
     if (arrayWord7==arrayWord3)continue;
     if (arrayWord7==arrayWord4)continue;
     if (arrayWord7==arrayWord5)continue;
     if (arrayWord7==arrayWord6)continue;
     
     Debug.Log(funnySentence=arrayWord1+arrayWord2+arrayWord3+arrayWord4+arrayWord5+arrayWord6+arrayWord7);
     break;
    } 
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
