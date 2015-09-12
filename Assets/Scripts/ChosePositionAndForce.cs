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




	// Use this for initialization
	void Start () {
		iTween.MoveTo (Luncher, iTween.Hash ("x", LuncherendPosition,"speed",Luncherspeed,"EaseType",LunchereaseType,"LoopType",LuncherloopType));
		
		iTween.MoveTo (Star, iTween.Hash ("y", StarendPosition,"speed",Starspeed,"EaseType",StareaseType,"LoopType",StarloopType));


		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
