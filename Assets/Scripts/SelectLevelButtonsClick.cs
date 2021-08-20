using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevelButtonsClick : MonoBehaviour
{
    public void Level1Click()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2Click()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3Click()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Level4Click()
    {
        SceneManager.LoadScene("Level4");
    }
    public void Level5Click()
    {
        SceneManager.LoadScene("Level5");
    }
    public void Level6Click()
    {
        SceneManager.LoadScene("Level6");
    }
    public void Level7Click()
    {
        SceneManager.LoadScene("Level7");
    }
    public void Level8Click()
    {
        SceneManager.LoadScene("Level8");
    }

    public void BackToMainMenuClick()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
