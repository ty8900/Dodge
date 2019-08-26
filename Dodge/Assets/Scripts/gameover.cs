using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public Text overtext;
    int score;
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    void Start()
    {
        score = GameObject.Find("Gamemanager").GetComponent<Gamemanager>().ctr;
        overtext.text = "Your score : " + score + " s";
        Destroy(GameObject.Find("Gamemanager"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
