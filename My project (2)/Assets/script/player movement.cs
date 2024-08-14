using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public GameObject Player;
    public float turnspeed;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       float y = Input.GetAxis ("Mouse X") * turnspeed;
       Player .transform.eulerAngles = new Vector3(0, Player.transform.eulerAngles.y + y, 0);
    }
}
