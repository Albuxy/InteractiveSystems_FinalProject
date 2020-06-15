using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEscenario : MonoBehaviour
{
    //Rotate the escensario in the menu
    void Update()
    {
        transform.Rotate (new Vector3(0,0.5f,0));
    }

}
