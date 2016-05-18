using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIMangement : MonoBehaviour {


    public void onButtonClicked(GameObject button) {

        switch (button.tag) {
            case "EnterBtn":
                SceneManager.LoadScene("Stepper");
                break;
            case "TurnoffBtn":
                GameObject.Find("Base").GetComponent<CreateBase>().turnoffButton();
                break;
            case "chbase":
                GameObject.Find("Base").GetComponent<CreateBase>().displaycoll();
                break;
            case "StepperBtn":
                SceneManager.LoadScene("SelectMask");
                break;
            case "BackBtn":
                SceneManager.LoadScene("MenuScene");
                break;
            case "ResetBtn":
                string Scene = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(Scene);
                if (Scene == "SelectMask") {
                    CreateMaskBtn.selectedButtons.Clear();
                }
                break;
            default:

                MaskBtnCtrl buttonCtrl = button.GetComponent<MaskBtnCtrl>();
                if (!CreateMaskBtn.selectedButtons.Contains(int.Parse(button.name))) {
                    CreateMaskBtn.selectedButtons.Add(int.Parse(button.name));
                    buttonCtrl.setIsClicked(true);
                    buttonCtrl.ChangeColor();
                }
                break;
        }
    }
}
