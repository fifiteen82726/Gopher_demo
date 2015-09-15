using UnityEngine;
using System.Collections;

public class Timmer : MonoBehaviour {

	// set time counter here
	public int time ;
	float time_counter =0f;

	public bool StartOrNot ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (StartOrNot == true)
		{
			if(time_counter<1)
				time_counter +=Time.deltaTime;
			else 
			{
				time_counter = 0;
				time--;
				//print (time);
				//GetComponent<textMesh>().enabled = false;
				GetComponent<TextMesh>().text = time.ToString();
			}

		}
	}
}
