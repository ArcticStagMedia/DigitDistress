using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

    public int recourceMoney;
    private int time;
    private float timeF;

    public Text Timer,money;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeF+=Time.deltaTime;
        time = (int)timeF; // time += Mathf.RoundToInt(timeF);
        Timer.text = "Time: " + time.ToString();
        money.text = "Current Money: " + recourceMoney.ToString();
	}

    public int RecourceMoney
    {
        get;
        set;
    }

    
}
