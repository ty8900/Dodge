using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanager : MonoBehaviour
{
    public Button ExitButton, StartButton;
    // Start is called before the first frame update
    void Start()
    {
        ExitButton.onClick.AddListener(exit);
        StartButton.onClick.AddListener(start);
    }
    void exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    void start()
    {
        SceneManager.LoadScene("Dodge");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
