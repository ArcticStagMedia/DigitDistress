using UnityEngine;
using System.Collections;

public class DialougueScript : MonoBehaviour {

    private AudioSource aSource;


    public AudioClip Happy1;
    public string HappyText1;

    public AudioClip Frustrated1;
    public string FrustratedText1;


    public AudioClip Explore1;
    public string ExploreText1;

    public AudioClip Angry1;
    public string AngryText1;

    public AudioClip Hungry1;
    public string HungryText1;

    public AudioClip Corrupt1;
    public string CorruptText1;

    public AudioClip Random1;
    public string RandomText1;




	// Use this for initialization
	void Start () 
    {
        aSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update ()
    {
      
	
	}

    public void Happy()
    {

        aSource.clip = Happy1;

        aSource.Play();

    }

    public void Frustrated()
    {
        aSource.clip = Frustrated1;

        aSource.Play();

    }

    public void Explore()
    {
        aSource.clip = Explore1;

        aSource.Play();

    }

    public void Angry()
    {
        aSource.clip = Angry1;

        aSource.Play();

    }

    public void Corrupt()
    {
        aSource.clip = Corrupt1;

        aSource.Play();

    }


    public void Hungry()
    {
        aSource.clip = Hungry1;

        aSource.Play();

    }




    public void Random()
    {
        aSource.clip = Random1;

        aSource.Play();

    }



}
