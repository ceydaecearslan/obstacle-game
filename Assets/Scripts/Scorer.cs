using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Scorer : MonoBehaviour
{
    int bonkCounter = 0;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            
        }
        else if (other.gameObject.tag != "Hit")
        {
            bonkCounter++;
            Debug.Log($"You have bonked {bonkCounter} times");
        }
        
    }
}
