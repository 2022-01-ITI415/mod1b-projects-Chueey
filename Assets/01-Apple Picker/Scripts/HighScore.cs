using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score = 1000
    // Start is called before the first frame update
    void Awake () {
        if (PlayersPrefs.HasKey("HighScore")) {
            score = PlayersPrefs.GetInt("HighScore");
        }
        PlayersPrefs.SetInt("HighScore", score);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: "+score;
        if (score > PlayersPrefs.GetInt("HighScore")) {
            PlayersPrefs.SetInt("HighScore", score);
        }
    }
}
