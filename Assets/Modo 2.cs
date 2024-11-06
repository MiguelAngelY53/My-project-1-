using UnityEngine;
using TMPro;

public class Modo2 : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField username;
    public void ButtonDemo()
    {
        output.text = username.text;

    }
}