using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expo : MonoBehaviour {

	public GameObject expo;

	void Crbomb()
	{
		Instantiate (expo);
	}


	// Use this for initialization
	void Start () 
	{
		Crbomb ();

		Invoke ("CreateBomb", 4f);

		Destroy (expo);

	}
	

}
