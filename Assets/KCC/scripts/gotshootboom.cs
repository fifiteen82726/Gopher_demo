using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gotshootboom : MonoBehaviour {

	private Text score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (ChosePositionAndForce.displayCarrierOrNot  == false)
			ChosePositionAndForce.displayCarrierOrNot = true;

		score = GameObject.Find ("score").GetComponent<Text>();
		score.text = showgropher.gropherpoint.ToString();

		Destroy(gameObject);
	}
}
