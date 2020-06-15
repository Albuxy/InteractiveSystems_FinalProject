using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDestroy : MonoBehaviour
{

    //Destroy when enter in Collider with a Goal
    void OnTriggerEnter(Collider other) // 1 
    {
	//Confirm that the goal is Red
	if (other.gameObject.CompareTag("DropBallRed")) // 2 
	{
		//Destroy de object and add 1 in the counter
		GameStateManager.Instance.SavedRed();
		Destroy(other.gameObject); // 3

	}

    }
}
