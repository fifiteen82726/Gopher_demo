using UnityEngine;
using System.Collections;

public class ChosePositionAndForce : MonoBehaviour {

	public GameObject Star,Luncher;
	public iTween.EaseType StareaseType;
	public iTween.LoopType StarloopType;
	public float StarPosition,StarendPosition;
	public float Starspeed;


	public iTween.EaseType LunchereaseType;
	public iTween.LoopType LuncherloopType;
	public float LuncherPosition,LuncherendPosition;
	public float Luncherspeed;

	bool ChosePosition = false ;
	bool ChoseForce = false;

	// Use this for initialization
	void Start () {


		
		iTween.MoveTo (Luncher, iTween.Hash ("x", LuncherendPosition,"speed",Luncherspeed,"EaseType",LunchereaseType,"LoopType",LuncherloopType));
		


		
	
	}
	
	// Update is called once per frame
	void Update () {



		if (ChosePosition == true && ChoseForce == false) 
		{
			iTween.Stop (Luncher);
			iTween.MoveTo (Star, iTween.Hash ("y", StarendPosition, "speed", Starspeed, "EaseType", StareaseType, "LoopType", StarloopType));
		} 
		else if (ChosePosition == true && ChoseForce == true) 
		{
			iTween.Stop(Luncher);
			iTween.Stop(Star);	
		}

	}

	void OnMouseDown() {	
		if (ChosePosition == false)
			ChosePosition = true;
		else 
			ChoseForce = true;


	}
}
