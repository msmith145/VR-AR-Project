

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]

public class Teleport : MonoBehaviour {
  private Vector3 startingPosition;
 

    void Start() {
    startingPosition = transform.localPosition;
    SetGazedAt(false);
  }

  void LateUpdate() {
    Cardboard.SDK.UpdateState();
    if (Cardboard.SDK.BackButtonPressed) {
      Application.Quit();
    }
  }

  public void SetGazedAt(bool gazedAt) {
    GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
  }

  public void Reset() {
    transform.localPosition = startingPosition;
  }

  public void ToggleVRMode() {
    Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
  }

  public void TeleportRandomly() {
 
    Vector3 direction = Random.onUnitSphere;
    direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);
    float distance = 2 * Random.value;
    

         if (GameObject.FindGameObjectWithTag("monster").transform.position.x == 30)
        {
      
          
            transform.localPosition = new Vector3(27, 1, 45);
            transform.eulerAngles = new Vector3(
transform.eulerAngles.x,
transform.eulerAngles.y +205,
transform.eulerAngles.z
);

        }

        else if (GameObject.FindGameObjectWithTag("monster").transform.localPosition.x == 27)
        {
            transform.localPosition = new Vector3(31, 0, 51);


        }

        else if (GameObject.FindGameObjectWithTag("monster").transform.localPosition.x == 31)
        {
            transform.localPosition = new Vector3(31, 1.5f, 60);

        }


    }


}
