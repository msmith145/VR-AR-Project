

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(AudioSource))]
public class tele : MonoBehaviour
{
    private Vector3 startingPosition;
    public AudioClip punch;
    public AudioClip roar;
    public static int score;
    public Text countText;
    public Text winText;
    public int count;
    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;
    public GameObject rock4;




    void Start()
    {


        startingPosition = transform.localPosition;
        SetGazedAt(false);
        score = 0;
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void LateUpdate()
    {
        Cardboard.SDK.UpdateState();
        if (Cardboard.SDK.BackButtonPressed)
        {
            Application.Quit();
        }
    }

    public void SetGazedAt(bool gazedAt)
    {
        GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
    }

    public void Reset()
    {
        transform.localPosition = startingPosition;
    }

    public void ToggleVRMode()
    {
        Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
    }

    public void TeleportRandomly()
    {

        Vector3 direction = Random.onUnitSphere;
        direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);
        float distance = 2 * Random.value;
        AudioSource audio = GetComponent<AudioSource>();

        if (GameObject.FindGameObjectWithTag("monster").transform.position.x == 30)
        {


            transform.localPosition = new Vector3(27, 1, 45);
            transform.eulerAngles = new Vector3(
transform.eulerAngles.x,
transform.eulerAngles.y + 205,
transform.eulerAngles.z
);
            
            score = score + 300;
            count++;
            SetCountText();


        }

        else if (GameObject.FindGameObjectWithTag("monster").transform.localPosition.x == 27)
        {
            transform.localPosition = new Vector3(38, 2, 56);
            transform.eulerAngles = new Vector3(
transform.eulerAngles.x,
transform.eulerAngles.y + 205,
transform.eulerAngles.z
);
           
            score = score + 300;
            count++;
            SetCountText();
        }

        else if (GameObject.FindGameObjectWithTag("monster").transform.localPosition.x == 38)
        {
            transform.localPosition = new Vector3(24, 4f, 52);
            transform.eulerAngles = new Vector3(
transform.eulerAngles.x,
transform.eulerAngles.y -120,
transform.eulerAngles.z
);
          
            score = score + 300;
            count++;
            SetCountText();
            

        }

        else if (GameObject.FindGameObjectWithTag("monster").transform.localPosition.x == 24)
        {
            GameObject.FindGameObjectWithTag("monster").SetActive(false);
            rock1.SetActive(false);
            rock2.SetActive(false);
            rock3.SetActive(false);
            rock4.SetActive(false);
            score = score + 300;
            count++;
            SetCountText();
            winText.text = "You Win!";
          
           

        }


    }


   public void SetCountText()
    {
        countText.text = "Score: " + score.ToString();
        
    }

    public static int sendScore()
    {
        int current = score;
        return current;
    }

    public static void getScore(int rock)
    {
        score = rock;

    }



}
