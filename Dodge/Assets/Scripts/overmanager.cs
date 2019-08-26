using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class overmanager : MonoBehaviour
{
    public Button  ExitButton, RestartButton;
    // Start is called before the first frame update
    void Start()
    {
        ExitButton.onClick.AddListener(exit);
        RestartButton.onClick.AddListener(restart);
    }
    void exit()
    {
        SceneManager.LoadScene("Main");
    }
    void restart()
    {
        SceneManager.LoadScene("Dodge");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
