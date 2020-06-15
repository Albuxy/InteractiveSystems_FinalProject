using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenDestroy : MonoBehaviour
{

    //Destroy when enter in Collider with a Goal
    void OnTriggerEnter(Collider other) // 1 
    {
	//Confirm that the goal is Green
	if (other.gameObject.CompareTag("DropBallGreen")) // 2 
	{
		//Destroy de object and add 1 in the counter
		GameStateManager.Instance.SavedGreen();
		Destroy(other.gameObject); // 3


	}
    }
}
