using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateBase : MonoBehaviour {

    public GameObject Base;

    public static GameObject[] Bases;

    private bool movingFlag;

    void Awake() {
        movingFlag = true;
    }

	// Use this for initialization
	void Start () {

        Bases = new GameObject[100];
        for(int i = 0; i<10; i++) {
            for(int j = 0; j<10; j ++) {
                GameObject obj = Instantiate(Base,
                                    new Vector3(22.5f + 5 * i, 1, -22.5f + 5 * j), new Quaternion()) as GameObject;
                obj.transform.parent = gameObject.transform;
                Bases[10 * i + j] = obj;

            }
        }
	}

    // Update is called once per frame
    void Update() {

        if (movingFlag) {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    Bases[10 * i + j].GetComponent<Transform>().Translate(Vector3.left * 0.5f);
                }

            }
        }
        if (Bases[99].GetComponent<Transform>().position.x == 22.5f) {
            movingFlag = false;
        }
    }

    public void displaycoll() {
        Debug.Log("displaycoll");
        for (int i = 0; i < Bases.Length; i++) {
            GameObject obj = Bases[i];
            float countcoll = obj.GetComponent<BaseCtrl>().getCountcoll();
            Bases[i].GetComponent<Renderer>().material.color =
                new Color(0 + (32f / 255f) * countcoll, 1 - (32f / 255f) * countcoll, 0 + (32f / 255f) * countcoll, 1.0f);
        }
    }

    public void turnoffButton() {
        GameObject Stepperbtn = GameObject.Find("Button");
        Stepperbtn.tag = "chbase";
        // set the camera
        Transform main = GameObject.Find("Main Camera").GetComponent<Transform>();
        main.position = new Vector3(0f, 55f, 0);
        main.Rotate(new Vector3(90, 0, 0));

        // stop spawning
        GameObject Light = GameObject.Find("LightSource");
        Light.GetComponent<SpawnCtrl>().setonGoing(false);

        Light.GetComponent<Transform>().FindChild("Photons").gameObject.SetActive(false);

        // remove mask
        GameObject.Find("Mask").SetActive(false);

        // change Text
        GameObject.Find("Text").GetComponent<Text>().text = "";
    }

    public bool getmovingFlag() {
        return movingFlag;
    }
}
