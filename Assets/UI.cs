using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField username;
    public void ButtonDemo()
    {
        output.text = username.text;

    }
}
 