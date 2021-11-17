using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    public Score Controller;
    

    private void OnTriggerEnter(Collider other)
    {      
        if (other.gameObject.tag == "Goal")
        {
            Debug.Log("Goal");
            Controller.IncrementScore();
            
        }

    }
}
