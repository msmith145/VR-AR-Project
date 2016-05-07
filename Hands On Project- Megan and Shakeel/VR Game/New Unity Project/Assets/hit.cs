using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hit : MonoBehaviour {
    public static int rockScore;
    public Text countText;

    // Use this for initialization
    void Start () {
        rockScore = tele.sendScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void boom()
    {
        
        GetComponent<MeshRenderer>().enabled = false;
        rockScore = tele.sendScore() + 100;
        SetCountText();
        tele.getScore(rockScore);
    }
    public void SetCountText()
    {
        countText.text = "Score: " + rockScore.ToString();

    }

}
