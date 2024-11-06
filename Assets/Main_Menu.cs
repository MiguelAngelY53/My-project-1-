using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void jugar()
    {
        SceneManager.LoadSceneAsync("Modo de juegos");
    }
    public void quit()
    {
        Application.Quit();
    }
}
