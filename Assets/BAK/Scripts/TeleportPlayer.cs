using UnityEngine;
using System.Collections;

public class TeleportPlayer : MonoBehaviour {

	private GameObject playerOBJ;


    public GameObject boulSign;

    public GameObject circleSign;

    public GameObject hospitalSign;

    public GameObject endSign;

	


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

        playerOBJ.transform.position = boulSign.transform.position;


	}

	public void MyClick2()
	{

        playerOBJ.transform.position = circleSign.transform.position;

		
	}

    public void MyClick3()
    {

        playerOBJ.transform.position = hospitalSign.transform.position;


    }


    public void MyClick4()
    {


        playerOBJ.transform.position = endSign.transform.position;

    }




		
	

						
				

	}

