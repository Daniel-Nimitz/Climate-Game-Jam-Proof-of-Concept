using UnityEngine;

public class Encounter_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = -2000f;
   

    void FixedUpdate()
    {
        //Encounters move from right to left on x axis
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);

       
    }

}
