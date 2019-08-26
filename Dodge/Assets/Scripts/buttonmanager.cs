using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonmanager : MonoBehaviour
{
    public Button ResumeButton, ExitButton, RestartButton;
    // Start is called before the first frame update
    void Start()
    {
        ExitButton.onClick.AddListener(exit);
        ResumeButton.onClick.AddListener(resume);
        RestartButton.onClick.AddListener(restart);

    }
    void exit()
    {
        SceneManager.LoadScene("Main");
    }
    void resume()
    {

    }
    void restart()
    {
        SceneManager.LoadScene("Dodge");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            resume();
        }
    }
}
