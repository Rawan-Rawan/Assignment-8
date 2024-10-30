using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
   
{
   while (true)
    {
    int rollDice = Random.Range(1,21);
    if (rollDice == 5) 
    {
    continue;
    }
    if (rollDice == 15)
    {
    break;
    }
    Debug.Log(rollDice);
   
    }

 }
    // Update is called once per frame
    void Update()
    {
        
    }
}
