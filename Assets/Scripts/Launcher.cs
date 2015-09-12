using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

	public iTween.EaseType easeType;
	public iTween.LoopType loopType;
	public float startPosition,endPosition;
	public float speed;
	 
	// Use this for initialization
	void Start () {
		iTween.MoveTo (gameObject, iTween.Hash ("x", endPosition,"speed",speed,"EaseType",easeType,"LoopType",loopType));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
