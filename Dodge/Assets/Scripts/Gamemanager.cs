using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public float time;
    public int ctr;
    public Text timetext;
    public Text roundtext;
    // Start is called before the first frame update

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        time = 0;
        ctr = 0;
    }

   
    // Update is called once per frame
    void Update()
    {
        if (time>1)
        {
            time = 0;
            ctr++;
        }
        timetext.text = ctr + " s";
        if (ctr > 10)
            roundtext.text = "Round 2";
        if (ctr > 20)
            roundtext.text = "Round 3";
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Pause");
        }
        time += Time.deltaTime;
    }
    void Restartgame()
    {
        SceneManager.LoadScene("Dodge");
    }
}
