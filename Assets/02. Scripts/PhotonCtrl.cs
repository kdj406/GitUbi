using UnityEngine;
using System.Collections;

public class PhotonCtrl : MonoBehaviour {

    private bool ContactLens;

    private int ForceX;
    private int ForceZ;

    // Use this for initialization
    void Start() {
        ForceX = Random.Range(-20, 20);
        ForceZ = Random.Range(-20, 20);
        ContactLens = false;
    }

    void FixedUpdate() {
        if (!ContactLens) {
            GetComponent<Rigidbody>().AddForce(new Vector3(ForceX, 0, ForceZ));
        }

        if (GetComponent<Transform>().position.y < -10) {
            Destroy(this.gameObject);
        }
    }

    public void setContactLens(bool boolean) {
        ContactLens = boolean;
    }
}
