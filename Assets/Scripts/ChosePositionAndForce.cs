using UnityEngine;
using System.Collections;

public class ChosePositionAndForce : MonoBehaviour {


	public GameObject Star,Luncher,Boom,Display_Carrier;
	public iTween.EaseType StareaseType;
	public iTween.LoopType StarloopType;
	public float StarPosition,StarendPosition;
	public float Starspeed;


	public iTween.EaseType LunchereaseType;
	public iTween.LoopType LuncherloopType;
	public float LuncherPosition,LuncherendPosition;
	public float Luncherspeed;


	public iTween.EaseType BoomeaseType;
	public iTween.LoopType BoomloopType;
	public float BoomPosition,BoomendPosition;
	public float Boomspeed;



	bool ChosePosition = false ;
	bool ChoseForce = false;

	float PowerDegree = 0f;

	public static bool displayCarrierOrNot = true;
	public static bool CarrierReset = false;

	// Use this for initialization
	void Start () {
		iTween.MoveTo (Luncher, iTween.Hash ("x", LuncherendPosition,"speed",Luncherspeed,"EaseType",LunchereaseType,"LoopType",LuncherloopType));
		
	}
	
	// Update is called once per frame
	void Update () {

		if (ChosePosition == true && ChoseForce == false  ) 
		{
			iTween.Pause (Luncher);
			iTween.MoveTo (Star, iTween.Hash ("y", StarendPosition, "speed", Starspeed, "EaseType", StareaseType, "LoopType", StarloopType));
		} 
		else if (ChosePosition == true && ChoseForce == true) 
		{
			iTween.Pause(Luncher);
			iTween.Pause(Star);	
		}

		//if(displayCarrierCount  == true)
		//	Display_Carrier.GetComponent<SpriteRenderer>().enabled = true;
		//else 
		//	Display_Carrier.GetComponent<SpriteRenderer>().enabled = false;

		Display_Carrier.GetComponent<SpriteRenderer>().enabled = displayCarrierOrNot;
		 



	}

	
	void OnMouseDown() {	
		
		if (ChosePosition == false){
			ChosePosition = true;
			if(CarrierReset==true)
			{
				iTween.Resume(Star);
			}
		}

		// make Star stop
		else if (ChosePosition == true && ChoseForce == false) {
			ChoseForce = true;
			//Compute Force power 
			PowerDegree = Mathf.Abs (Star.transform.position.y - StarPosition)/ Mathf.Abs(StarendPosition - StarPosition) * 100;
			
			//print (PowerDegree);

			Vector3 NewBoomPostion = new Vector3 (Luncher.transform.position.x, BoomPosition, 85);
			
			GameObject newBoom = Instantiate(Boom, NewBoomPostion , Quaternion.identity) as GameObject;
			iTween.MoveTo (newBoom, iTween.Hash 
				("y",BoomPosition+((BoomendPosition-BoomPosition)/100*PowerDegree),
				"speed",Boomspeed,
				"EaseType",BoomeaseType,
				"LoopType",BoomloopType,
				"oncomplete","BoomComplete",
				"oncompletetarget", gameObject,
				"oncompleteparams", newBoom
				));

			displayCarrierOrNot = false;
			CarrierReset = true;
			ChosePosition  = false;
			ChoseForce = false;
			
			//After Shot, Luncher will move
			iTween.Resume(Luncher);
			iTween.Pause(Star);	
			
			//After Shot, Luncher Carrier will display
			displayCarrierOrNot = true;
		}
	}


	void BoomComplete(GameObject boom){
		print("complete");
		Destroy(boom);
	}
}
