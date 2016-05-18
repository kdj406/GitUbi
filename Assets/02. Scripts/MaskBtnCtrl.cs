using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MaskBtnCtrl : MonoBehaviour {
    private bool isClicked;

    private Button button;
    private ColorBlock color;


    // Use this for initialization
    void Start() {
        isClicked = false;

        button = gameObject.GetComponent<Button>();
        color = button.colors;

        //GameObject UIManager = GameObject.Find("UIManager");
        //gameObject.GetComponent<Button>().onClick.AddListener(() => UIManager.GetComponent<UIMgr>().onButtonClicked(gameObject));
    }

    public void ChangeColor() {
        color.normalColor = Color.white;
        button.colors = color;
    }


    public bool getIsClicked() {
        return isClicked;
    }

    public bool setIsClicked(bool boolean) {
        isClicked = boolean;
        return isClicked;
    }
}
