using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalLanguge : MonoBehaviour
{
    public int language;
    // Start is called before the first frame update
    void Start()
    {
        language = PlayerPrefs.GetInt("language", language);

    }

    public void RussianLanguage()
    {
        language = 1;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene("Language");
    }

    public void EnglishLanguage()
    {
        language = 0;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene("Language");
    }
}
