using UnityEngine;
using TMPro;

public class Modo1 : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField username;
    public void ButtonDemo()
    {
        output.text = "Numero de jugadores es" + username.text;

    }
}
