using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ModifyInfoButton : MonoBehaviour
{
    public Button moreInfoButton;
    public TMP_Text newText;
    public TextMeshProUGUI buttonLabel;
    public static string global_TextForNewScene;
    public static string global_PlaqueInfo;
    
    public void changeButtonText(string plaqueInfo) {
        moreInfoButton = GameObject.Find("NewInfoButton").GetComponent<Button>();
        moreInfoButton.interactable = true;
        global_PlaqueInfo = plaqueInfo;
        Debug.Log(global_PlaqueInfo);
        newText = GameObject.Find("InfoButtonText").GetComponent<TMP_Text>();
        newText.text = global_PlaqueInfo;
        Debug.Log(newText.text);
    }

    public void goToMoreInfoRoom() {
        Debug.Log("Going to " + global_PlaqueInfo);
        changeTextForNewScene();
        // Go to scene
    }

    public void changeTextForNewScene() {
        switch(global_PlaqueInfo) {
            case "RB350":
                global_TextForNewScene = "This is Roger Bacon 350. It is the open lab where you can come to do homework and study. You might also have a class or exam in here.";
            break;
            default:
                global_TextForNewScene = "Either you forgot to set the room, the room you set does not exist or you spelt it wrong, or it is not in the switch statement yet.";
            break;
        }
    }

    public void disableButton() {
        global_PlaqueInfo = "Waiting...";
        newText.text = "Waiting...";
        moreInfoButton.interactable = false;
    }
}