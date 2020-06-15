using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance; // 1

    //Counter Ball
    private int blueDown;
    private int greenDown;
    private int redDown; 
    private int yellowDown;

    //Counters Text
    public Text blueDroppedText;
    public Text greenDroppedText;
    public Text redDroppedText;
    public Text yellowDroppedText;

    //Counter Time
    public Text counter;
    private float time = 0f;


    //Initialization
    void Start()
    {
        blueDown = 0;
        greenDown = 0;
	redDown = 0;
	yellowDown = 0;
	counter.text = " " + time;
    }
    
    // Start is called before the first frame update
    void Awake()
    {
       Instance = this;
       SetCountTextBlue ();
       SetCountTextGreen ();
       SetCountTextRed ();
       SetCountTextYellow ();

    }

    void Update()
    {
        //Update the time
	time += Time.deltaTime;
	counter.text = " " + time.ToString("f0");

	//Change the scene when the user win
	if (blueDown + greenDown + redDown + yellowDown == 8) // 2
    	{
	    SceneManager.LoadScene("Final");
    	}
    }

    //Ball Blue Saved
    public void SavedBlue()
    {
	time = time - 2;
	blueDown ++;
	SetCountTextBlue ();
    }

    //Ball Green Saved
    public void SavedGreen()
    {
	time = time - 2;
	greenDown ++;
	SetCountTextGreen ();
    }

    //Ball Red Saved
    public void SavedRed()
    {
	time = time - 2;
	redDown ++;
	SetCountTextRed ();
    }

    //Ball Yellow Saved
    public void SavedYellow()
    {
	time = time - 2;
	yellowDown ++;
	SetCountTextYellow ();
    }


    //Modify the counters in the game
    void SetCountTextBlue ()
    {
	blueDroppedText.text = " " + blueDown.ToString ();
    }

    void SetCountTextGreen ()
    {
	greenDroppedText.text = " " + greenDown.ToString ();
    }

    void SetCountTextRed ()
    {
	redDroppedText.text = " " + redDown.ToString ();
    }

    void SetCountTextYellow ()
    {
	yellowDroppedText.text = " " + yellowDown.ToString ();
    }



}
