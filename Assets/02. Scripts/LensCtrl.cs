using UnityEngine;
using System.Collections;

public class LensCtrl : MonoBehaviour {

    void OnTriggerEnter(Collider coll) {
        if (coll.tag == "PHOTON") {
            coll.gameObject.GetComponent<PhotonCtrl>().setContactLens(true);
            coll.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
