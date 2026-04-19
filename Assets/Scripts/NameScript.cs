using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{
    private string text;
    private string[] sampeText = {"Hello", "HAve a nice day", "Nice to meet you", "Look where are you going", "CYA"};
    int ranndomIx;
    public GameObject inputField;
    public GameObject outputField;
    public GameObject reverseTextToggle;

    public void GetText(){
        ranndomIx = Random.Range(0, sampeText.Length);
        text = inputField.GetComponent<TMP_InputField>().text;
        outputField.GetComponent<TMP_Text>().text = sampeText[ranndomIx] + " " + text.ToUpper() + "!";

        reverseTextToggle.GetComponent<Toggle>().interactable = true;

        if (reverseTextToggle.GetComponent<Toggle>().isOn) {
            ReverseText();
        }
    }

    public void ReverseText() {
        char[] charArray =outputField.GetComponent<TMP_Text>().text.ToCharArray();
        System.Array.Reverse(charArray);
        outputField.GetComponent<TMP_Text>().text = new string(charArray);  
    }
}
