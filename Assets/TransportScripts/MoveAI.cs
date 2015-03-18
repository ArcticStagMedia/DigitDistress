using UnityEngine;
using System.Collections;

public class MoveAI : MonoBehaviour {
	public int speed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, -speed * Time.deltaTime);
	}
}
