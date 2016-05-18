using UnityEngine;
using System.Collections;

public class BaseCtrl : MonoBehaviour {

    private float countcoll;

    void Start() {
        countcoll = 0;
    }
    void OnTriggerEnter(Collider coll) {
        if (coll.tag == "PHOTON") {
            Destroy(coll.gameObject);
            this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            countcoll = countcoll + 1.0f;
        }
    }

    public float getCountcoll() {
        return countcoll;
    }
}
