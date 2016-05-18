using UnityEngine;
using System.Collections;

public class CreateBase : MonoBehaviour {

    public GameObject Base;

    public static GameObject[] Bases;

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
	void Update () {
	
	}
}
