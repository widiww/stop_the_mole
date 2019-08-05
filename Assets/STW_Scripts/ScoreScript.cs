using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour
{
	static private tk2dTextMesh textMesh;
	static private int score;
    public static int highscore;

    static public int Score
	{
		get
		{
			return score;	
		}
		
		set
		{
			score = value;	
		}
	}
	
	// Use this for initialization
	void Start ()
	{
		score = 0;
		textMesh = GetComponent<tk2dTextMesh>();
        highscore = PlayerPrefs.GetInt("Highscore", highscore);
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (score > highscore) ;
        highscore = score;
        textMesh.text = string.Format("Score: {0}", score);
		textMesh.Commit();
        PlayerPrefs.SetInt("highscore", highscore);
    }
}
