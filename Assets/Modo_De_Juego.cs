using UnityEngine;
using UnityEngine.SceneManagement;

public class Modo_De_Juego : MonoBehaviour
{
    public void mode_game1()
    {
        SceneManager.LoadSceneAsync("Solo_Jugador");
    }
    public void mode_game2()
    {
        SceneManager.LoadSceneAsync("JugadorIA");
    }
    public void quit()
    {
        Application.Quit();
    }
    public void volver()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
