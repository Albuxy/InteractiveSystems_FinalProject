using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    //Function to change the scene
    public void CargaNivel(string pNombre)
    {
	SceneManager.LoadScene(pNombre);
    }

    //Load the last scene
    public void Salir(string pNombre1)
    {
	SceneManager.LoadScene(pNombre1);
	Application.Quit();
	Debug.Log("Se ha salido del juego");
    }

}
