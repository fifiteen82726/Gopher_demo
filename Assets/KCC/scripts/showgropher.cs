using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showgropher : MonoBehaviour {

//	public GameObject gropher;
//	private GameObject good_gropher;
	private float timer = 0.0f;
	private float showtimer = 0.0f;

	private bool rnd;
	private int cgropher;
	private int showtime;	//3~5
	private int showwords;
	private GameObject[] gropher = new GameObject[8];
	private string[] words = {"舒緩壓力", "情緒良好", "精神充足", "增加自信", "增強記憶", "學業進步", "值夜班", "喝咖啡", "念書", "聊天", "看電視", "打電動"};
	// Use this for initialization
	void Start () {

		rnd = true;

		Random.seed = System.Guid.NewGuid ().GetHashCode ();
		gropher [0] = GameObject.Find ("goodgropher1"); 
		gropher [1] = GameObject.Find ("goodgropher2"); 
		gropher [2] = GameObject.Find ("goodgropher3"); 
		gropher [3] = GameObject.Find ("goodgropher4"); 
		gropher [4] = GameObject.Find ("badgropher1"); 
		gropher [5] = GameObject.Find ("badgropher2"); 
		gropher [6] = GameObject.Find ("badgropher3"); 
		gropher [7] = GameObject.Find ("badgropher4"); 
		//good_gropher = (GameObject)Instantiate (gropher, new Vector2 (-7.5f, 991.5f), Quaternion.identity);
		gropher [0].SetActive (false);
		gropher [1].SetActive (false);
		gropher [2].SetActive (false);
		gropher [3].SetActive (false);
		gropher [4].SetActive (false);
		gropher [5].SetActive (false);
		gropher [6].SetActive (false);
		gropher [7].SetActive (false);
//		good_gropher.transform.parent = GameObject.Find ("Canvas").transform;
//		good_gropher.transform.localScale -= new Vector3(0.666f, 0.666f, 0);
	//	good_gropher.transform.position = new Vector3 (-570.0f, 270.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		if (timer >= 2) {

			showtimer += Time.deltaTime;
			if (rnd)
			{
				cgropher = Random.Range(1, 8);
				showtime = Random.Range (3, 5);
				if (cgropher <= 4)	{
					showwords = Random.Range (1, 6);
				}
				else {
					showwords = Random.Range (7, 12);
				}
				gropher [cgropher-1].SetActive (true);

				Text[] word = gropher [cgropher-1].GetComponentsInChildren<Text>();// = words[showwords-1];
				Debug.Log(cgropher);
					Debug.Log(showwords);
				word[0].text = words[showwords-1];
				rnd = false;
			}
			//Debug.Log(cgropher);

			if (showtimer>=showtime)	{
				gropher [cgropher-1].SetActive (false);
				rnd = true;
				timer = 0;
				showtimer = 0;
			}
		}
	//	Debug.Log(timer);
		//good_gropher [0].SetActive (false);

	}
}
