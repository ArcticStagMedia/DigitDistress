using UnityEngine;
using System.Collections;

public class TeleportPlayer : MonoBehaviour {

	private GameObject playerOBJ;

	public Vector3 movePlay1 = new Vector3 (0, 0, 0);

	public Vector3 movePlay2 = new Vector3 (0, 0, 0);

	public Vector3 movePlay3 = new Vector3 (0, 0, 0);
	
	public Vector3 movePlay4 = new Vector3 (0, 0, 0);


	public float roY;


	// Use this for initialization
	void Start () 
	{
		playerOBJ = GameObject.FindGameObjectWithTag ("Player");


	
	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}

	public void MyClick1()
	{

		playerOBJ.transform.position = movePlay1;



//		if(i == 1)
//		{
//			print ("FALSE");
//
//			clicked = false;
//
//			playerOBJ.transform.position = movePlay2;
//			if (clicked == false)
//			{
//				i = 0;
//          }


		}

	public void MyClick2()
	{
		
		playerOBJ.transform.position = movePlay2;

		//playerOBJ.transform.rotation = new Quaternion(0,roY,0,0);
		

		
	}

	public void MyClick3()
	{
		playerOBJ.transform.position = movePlay3;
	}

	public void MyClick4()
	{
		playerOBJ.transform.position = movePlay4;
	}



		
	

						
				

	}

