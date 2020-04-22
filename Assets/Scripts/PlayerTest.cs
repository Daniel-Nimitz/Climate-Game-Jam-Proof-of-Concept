using UnityEngine;

public class PlayerTest : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        Score.scoreValue += 1;
        Debug.Log("Score!");
    }

    
        
}

