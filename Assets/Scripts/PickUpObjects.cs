using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjects : MonoBehaviour
{
   //Variables
   public GameObject ObjectToPickUp;   
   public GameObject PickedObject;
   public Transform interactionZone;
   private int time = 0;
 

   //To pick up an object
   void Update()
   {
      //Follow the conditions if the object can be pickable
      if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<PickableObject>().isPickable == true && PickedObject == null)
      {
	  if(Input.GetKeyDown(KeyCode.Space))
	   {
		PickedObject = ObjectToPickUp;
		PickedObject.GetComponent<PickableObject>().isPickable = false;
		PickedObject.transform.SetParent(interactionZone);
		PickedObject.transform.position = interactionZone.position;
		PickedObject.GetComponent<Rigidbody>().useGravity = false;
		PickedObject.GetComponent<Rigidbody>().isKinematic = true;
	   }
      }
   }

   
}
