using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjects : MonoBehaviour
{
   
   public GameObject ObjectToPickUp;   
   public GameObject PickedObject;
   public Transform interactionZone;
   private int time;
 

   void Start ()
   {
	time = 0;
   }
   


   // Update is called once per frame
   void Update()
   {
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
