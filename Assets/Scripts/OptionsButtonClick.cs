using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsButtonClick : MonoBehaviour
{
    public void BackToMainMenuClick()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
