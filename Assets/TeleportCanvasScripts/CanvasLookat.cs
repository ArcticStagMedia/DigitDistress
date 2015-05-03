using UnityEngine;
using System.Collections;

public class CanvasLookat : MonoBehaviour {
	public GameObject m_Player;
	public GameObject TeleportCanvas;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		TeleportCanvas.transform.LookAt(m_Player.transform.position + new Vector3(0f, 0.5f, 0f));
		TeleportCanvas.transform.Rotate(0f, 180f, 0f);
	}
}
