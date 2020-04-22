
using UnityEngine;

public class Trigger_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public void FixedUpdate()
    {
       
        
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
        
    }
}
