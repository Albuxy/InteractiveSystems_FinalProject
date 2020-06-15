using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowDestroy : MonoBehaviour
{

    //Destroy when enter in Collider with a Goal
    void OnTriggerEnter(Collider other) // 1 
    {
	//Confirm that the goal is Yellow
	if (other.gameObject.CompareTag("DropBallYellow")) // 2 
	{	
		//Destroy de object and add 1 in the counter
		GameStateManager.Instance.SavedYellow();
		Destroy(other.gameObject); // 3

	}

    }
}
