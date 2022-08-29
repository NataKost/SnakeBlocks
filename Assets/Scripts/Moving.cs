using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speedGroundMoving = 15.0f;
    public float speedplayer = 5.0f;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        player.transform.position = player.transform.position + new Vector3 (0, 0, speedGroundMoving * Time.deltaTime);

        if (Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.position = player.transform.position - new Vector3 (speedplayer * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.position = player.transform.position + new Vector3(speedplayer * Time.deltaTime, 0, 0);
        }
        else
        {
            return;
        }
    }
}
