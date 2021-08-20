using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public string NextScene;
    public void PlayClick()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void ExitClick()
    {
        Application.Quit();
    }

    public void OptionsClick()
    {
        SceneManager.LoadScene("Options");
    }
}
