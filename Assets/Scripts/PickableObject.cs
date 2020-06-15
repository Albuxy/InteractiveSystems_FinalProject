using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{
   public bool isPickable = true;

   //Enter to the Collider zone of the hand
   private void OnTriggerEnter(Collider other)
   {
	if (other.tag == "PlayerInteractionZone")
	{
	   other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = this.gameObject;
	}
   }

   
   private void OnTriggerExit(Collider other)
   {
	if (other.tag == "PlayerInteractionZone")
	{
	   other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = null;
	} 
   }
}
