using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showgropher : MonoBehaviour {

	public GameObject goodgropher;
	public GameObject badgropher;
	public static int gropherpoint;

	private GameObject gropher;
	private float timer = 0.0f;
	private float showtimer = 0.0f;
	private bool rnd;
	private int cgropher;
	private int showtime;	//3~5
	private int showwords;
	//private GameObject[] gropher = new GameObject[8];
	private string[] words = {"舒緩壓力", "情緒良好", "精神充足", "增加自信", "增強記憶", "學業進步", "值夜班", "喝咖啡", "念書", "聊天", "看電視", "打電動"};
	// Use this for initialization
	void Start () {

		rnd = true;

		Random.seed = System.Guid.NewGuid ().GetHashCode ();

		/*gropher [0] = GameObject.Find ("goodgropher1"); 
		gropher [1] = GameObject.Find ("goodgropher2"); 
		gropher [2] = GameObject.Find ("goodgropher3"); 
		gropher [3] = GameObject.Find ("goodgropher4"); 
		gropher [4] = GameObject.Find ("badgropher1"); 
		gropher [5] = GameObject.Find ("badgropher2"); 
		gropher [6] = GameObject.Find ("badgropher3"); 
		gropher [7] = GameObject.Find ("badgropher4"); 
		gropher [0].SetActive (false);
		gropher [1].SetActive (false);
		gropher [2].SetActive (false);
		gropher [3].SetActive (false);
		gropher [4].SetActive (false);
		gropher [5].SetActive (false);
		gropher [6].SetActive (false);
		gropher [7].SetActive (false);*/
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
				cgropher = Random.Range(1, 8);	//選擇地鼠(位置及好壞)
				showtime = Random.Range (5, 15);	//出現的持續時間
				if (cgropher <= 4)	{
					showwords = Random.Range (1, 6);
				}
				else {
					showwords = Random.Range (7, 12);
				}
				//gropher [cgropher-1].SetActive (true);
				comeongropher(cgropher, showwords);

				TextMesh[] word = gropher.GetComponentsInChildren<TextMesh>();// = words[showwords-1];
		//		Debug.Log(cgropher);
		//		Debug.Log(showwords);
				word[0].text = words[showwords-1];
				rnd = false;
			}
			//Debug.Log(cgropher);

			if (showtimer>=showtime)	{
				//gropher [cgropher-1].SetActive (false);
				Destroy(gropher);
				rnd = true;
				timer = 0;
				showtimer = 0;
			}


		}
		//Debug.Log(timer);
		//good_gropher [0].SetActive (false);

	}

	void comeongropher(int which, int point)
	{
		switch (point) {
		case 1:
			gropherpoint = 2;
			break;
		case 2:
			gropherpoint = 4;
			break;
		case 3:
			gropherpoint = 4;
			break;
		case 4:
			gropherpoint = 6;
			break;
		case 5:
			gropherpoint = 8;
			break;
		case 6:
			gropherpoint = 10;
			break;
		case 7:
			gropherpoint = 1;
			break;
		case 8:
			gropherpoint = 3;
			break;
		case 9:
			gropherpoint = 3;
			break;
		case 10:
			gropherpoint = 5;
			break;
		case 11:
			gropherpoint = 7;
			break;
		case 12:
			gropherpoint = 9;
			break;
		}

		switch (which) {
		case 1:
			gropher = (GameObject)Instantiate (goodgropher, new Vector3 (-6.8f, 4.3f, 60.0f), Quaternion.identity);
			break;
		case 2:
			gropher = (GameObject)Instantiate (goodgropher, new Vector3 (-3.5f, 2.0f, 60.0f), Quaternion.identity);
			break;
		case 3:
			gropher = (GameObject)Instantiate (goodgropher, new Vector3 (-0.2f, 4.3f, 60.0f), Quaternion.identity);
			break;
		case 4:
			gropher = (GameObject)Instantiate (goodgropher, new Vector3 (-3.0f, 2.0f, 60.0f), Quaternion.identity);
			break;
		case 5:
			gropher = (GameObject)Instantiate (badgropher, new Vector3 (-6.8f, 4.3f, 60.0f), Quaternion.identity);
			break;
		case 6:
			gropher = (GameObject)Instantiate (badgropher, new Vector3 (-3.5f, 2.0f, 60.0f), Quaternion.identity);
			break;
		case 7:
			gropher = (GameObject)Instantiate (badgropher, new Vector3 (-0.2f, 4.3f, 60.0f), Quaternion.identity);
			break;
		case 8:
			gropher = (GameObject)Instantiate (badgropher, new Vector3 (-3.0f, 2.0f, 60.0f), Quaternion.identity);
			break;

		}

	}
}
