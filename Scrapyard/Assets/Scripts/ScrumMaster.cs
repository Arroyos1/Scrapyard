using UnityEngine;
using System.Collections;
//using UnityEngine . UI;


public class ScrumMaster : MonoBehaviour
{
     public GameObject scrumbag;
     public GameObject spawnPlayer1;
     public GameObject spawnPlayer2;

     Vector3 startPlayer1; 
     Vector3 startPlayer2;
     Quaternion spawnRotation = Quaternion . identity;

	// Use this for initialization
	void Start ()
     {
          Vector3 startPlayer2 = spawnPlayer2 . transform . position;
     }
	
	// Update is called once per frame
	void Update ()
     {
         if ( Input . GetKeyDown ( "f" ) )
               {
               SpawnPlayer1 ( );
               }

     }

   void SpawnPlayer1()
     {
          Vector3 startPlayer1 = spawnPlayer1 . transform . position;
          Debug . Log ( "Vector3 startPlayer1 = " + startPlayer1 );
          Instantiate ( scrumbag , startPlayer1 , spawnRotation );
     }

         
}
