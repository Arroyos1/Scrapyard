using UnityEngine;
using System.Collections;

public class ProtoController : MonoBehaviour //a controller referencing the camera
    {
    public Camera cam; //reference to the main camera



	// Use this for initialization
	void Start ()
        {
        if ( cam == null )
            cam = Camera . main;  //if we haven't assigned another camera, this one is the default
	
	    }
	
	// Update is called once per frame
	void FixedUpdate ()
        {
        Vector3 a = cam . ScreenToWorldPoint ( Input . mousePosition );//convert the position of the mouse on the screen to the position in the world
        Vector3 b = new Vector3 ( a . x, 0f , 0f ); //set a variable for the x value of this vector leaving the others at 0, screen out the y and z values
        GetComponent<Rigidbody2D> ( ) . MovePosition ( b ); //Reference the rigidbody and set the current position of the sprite to the x value of the mouse location
        }
    }
