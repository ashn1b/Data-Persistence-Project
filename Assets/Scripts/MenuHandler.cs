using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    public static MenuHandler instance;

    public InputField inputField;
    string playerName = "N/A";
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);

    }

    public void SetName()
    {
        playerName = inputField.text;
        LoadGame();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public string GetName()
    {
        return playerName;
    }

}
