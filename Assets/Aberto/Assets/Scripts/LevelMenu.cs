using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void OpenLevel(int level01)
    {
        string levelName = "Level0" + level01;
        SceneManager.LoadScene(levelName);
        Debug.Log(levelName);
    }

}

