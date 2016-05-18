using UnityEngine;
using System.Collections;

public class SpawnCtrl : MonoBehaviour {

    public GameObject photon;

    private Transform firePos;

    private bool onGoing = true;

	// Use this for initialization
	void Start () {

        firePos = GetComponent<Transform>();
        StartCoroutine(this.Spawn());
	}
    public IEnumerator Spawn() {
        while (onGoing) {
            yield return new WaitForSeconds(1.0f);
            for (int i = 0; i < 5; i++) {
                GameObject obj = Instantiate(photon, firePos.position, firePos.rotation) as GameObject;
                obj.transform.parent = transform.FindChild("Photons").transform;
            }
        }
    }

    public bool getonGoing() {
        return onGoing;
    }

    public bool setonGoing(bool boolean) {
        onGoing = boolean;
        return onGoing;
    }
}
