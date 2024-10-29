using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         string[] funnyArray = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
    System.Random randomArray = new System.Random();
    string funnySentence ="";
    int wordCounter =0;
    while (wordCounter<7)
    { 
    int randomArrayIndex = randomArray.Next (funnyArray.Length);
    funnySentence += funnyArray[randomArrayIndex] + " ";
    ++wordCounter;    
    }
    funnySentence = funnySentence.TrimEnd() + ".";
    Debug.Log (funnySentence); 
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}  
