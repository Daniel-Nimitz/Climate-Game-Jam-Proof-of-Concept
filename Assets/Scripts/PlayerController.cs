using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //we decide where the lanes will be along the y coordinate
    public float laneOneY = 0.3f;
    public float laneTwoY = 5;
    //we create a variable to track which lane we are in right now
    public float currentLaneY;
    //I made a variable to track which enemy the player is currently immune to
    public string immunity;
    //Then we need to let the controller know there is a Rigid Body Componant or else our physics won't work
    private Rigidbody playerRb;
    //We put in some variables we will need to make sounds with
    public AudioClip pointSound;
    public AudioClip jumpSound;
    private AudioSource playerAudio;
    void Start()
    {   //Defining the rigid body of the object
        playerRb = GetComponent<Rigidbody>();
        //Setting  starting position
        currentLaneY = laneOneY;

        transform.position = new Vector3(transform.position.x, currentLaneY, transform.position.z);
        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //This function makes it where pressing space switches which lane we are in
        SwitchLane();


        //We need a function which will tell us to change between types of immunity based on key input, WE WILL CHANGE THIS TO LET PLAYERS DO INPUT THROUGH TYPING
        if (Input.GetKeyDown(KeyCode.A))
        {
            immunity = "immuneClimate";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            immunity = "immuneDenier";
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            immunity = "immuneEndangered";
        }
    }
    //This is code which will make the climate change, denier, and endangered species dissapear when they contact the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Climate") && immunity == "immuneClimate")
        {
            Destroy(other.gameObject);
            playerAudio.PlayOneShot(pointSound, 1.0f);

        }
        if (other.gameObject.CompareTag("Denier") && immunity == "immuneDenier")
        {
            Destroy(other.gameObject);
            playerAudio.PlayOneShot(pointSound, 1.0f);
        }
        if (other.gameObject.CompareTag("Endangered") && immunity == "immuneEndangered")
        {
            Destroy(other.gameObject);
            Score.scoreValue += 1;
            Debug.Log("Score!");
            playerAudio.PlayOneShot(pointSound, 1.0f);
        }

    }


    //If we press the spacebar then we will switch lanes between lane one and two by switching y position
    void SwitchLane()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentLaneY == laneOneY)
        {
            currentLaneY = laneTwoY;
            transform.position = new Vector3(transform.position.x, currentLaneY, transform.position.z);
            //This makes a sound happen when we jump
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

        else if (Input.GetKeyDown(KeyCode.Space) && currentLaneY == laneTwoY)
        {
            currentLaneY = laneOneY;
            transform.position = new Vector3(transform.position.x, currentLaneY, transform.position.z);
            //This makes a sound happen when we jump
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }


}
/*SomeNotes from Daniel: To get this script to work we need a few things.
 * 1. We need the climate change object to be tagged "Climate"
 * 2. We need the Denier object to be tagged "Denier"
 * 3. We need the Endanged Species object to be tagged "Endangered"
 * 4. Endangered animals, Climate Change, and Deniers must be given the trigger property, rigid bodies, and collider componants
 *5. Im not sure but player, climate change, denier, and endangered species need rigid bodies
 * 
 * 
 * Some Notes on what I need to do:
 * 1. Add in the typing system instead od A, D, and W
*/
