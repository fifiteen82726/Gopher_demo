using UnityEngine;
using System.Collections;

public class ShootBoom : MonoBehaviour {


	public GameObject DisplayCarrier;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	//print (ChosePositionAndForce.displayCarrierOrNot);
	}

	void OnTriggerEnter2D(Collider2D other){

		if (ChosePositionAndForce.displayCarrierOrNot  == false)
			ChosePositionAndForce.displayCarrierOrNot = true;

        Destroy(gameObject);
    }
}
