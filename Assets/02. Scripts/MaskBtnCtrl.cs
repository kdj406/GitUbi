using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GUITest : MonoBehaviour {

    public GameObject UIMask;

    public static List<int> selectedButtons;

    private int k = 0;

    void Start() {

        selectedButtons = new List<int>();
        GameObject panel = transform.FindChild("Panel").gameObject;
        Vector3 panelPosition = panel.GetComponent<Transform>().position;
        for (float i = -4.5f; i < 5; i++) {
            for (float j = -4.5f; j < 5; j++) {
                GameObject obj =
                    Instantiate(UIMask, panelPosition + new Vector3(25 * i, 25 * j), Quaternion.identity) as GameObject;
                obj.name = k + "";
                obj.transform.SetParent(panel.transform);
                k++;
            }

        }
    }
}
