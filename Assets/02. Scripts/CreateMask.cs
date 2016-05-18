using UnityEngine;
using System.Collections;

public class CreateMask : MonoBehaviour {

    public GameObject Maska;
    public GameObject Maskb;

    private GameObject[] Masks;

    private bool movingFlag;

    private int k = 0;

	// Use this for initialization
	void Start () {

        movingFlag = GameObject.Find("Base").GetComponent<CreateBase>().getmovingFlag();

        Masks = new GameObject[100];

        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                GameObject obj = Instantiate(Maskb, new Vector3(-67.5f + 5 * i, 5, -22.5f + 5 * j),
                        Quaternion.identity) as GameObject;
                obj.transform.parent = transform.FindChild("MaskA").transform;
                k++;
                Masks[10 * i + j] = obj;
                /*
                if (CreateMaskBtn.selectedButtons.Contains(k)) {
                    GameObject obj = Instantiate(Maska, new Vector3(-67.5f + 5 * i, 5, -22.5f + 5 * j),
                        Quaternion.identity) as GameObject;
                    obj.transform.parent = transform.FindChild("MaskA").transform;
                    k++;
                    Masks[10 * i + j] = obj;
                }
                else {
                    GameObject obj = Instantiate(Maskb, new Vector3(-67.5f + 5 * i, 5, -22.5f + 5 * j),
                        Quaternion.identity) as GameObject;
                    obj.transform.parent = transform.FindChild("MaskB").transform;
                    k++;
                    Masks[10 * i + j] = obj;
                }
                */
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
        if (movingFlag) {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    Masks[10 * i + j].GetComponent<Transform>().Translate(Vector3.right * 0.5f);
                }
            }
        }

        if (Masks[0].GetComponent<Transform>().position.x == -22.5f) {
            movingFlag = false;
        }
    }

}
