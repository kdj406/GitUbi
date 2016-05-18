using UnityEngine;
using System.Collections;

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

    public bool getmovingFlag() {
        return movingFlag;
    }
}
