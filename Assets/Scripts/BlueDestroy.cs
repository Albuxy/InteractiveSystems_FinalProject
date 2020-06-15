using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDestroy : MonoBehaviour
{

    //Destroy when enter in Collider with a Goal
    void OnTriggerEnter(Collider other) // 1 
    {
  	//Confirm that the goal is Blue
	if (other.gameObject.CompareTag("DropBallBlue")) // 2 
	{
		//Destroy de object and add 1 in the counter
		GameStateManager.Instance.SavedBlue();
		Destroy(other.gameObject); // 3

	}

    }


}