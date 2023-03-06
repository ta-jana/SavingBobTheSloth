using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;

    PlayerLook playerLook;

    private void Awake()
    {
        playerLook = GetComponent<PlayerLook>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraOne();
            playerLook.TurnONCamera = false;
            gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);

        }

        if (Input.GetKeyDown("2"))
        {
            
            CameraTwo();
            playerLook.TurnONCamera = true;
           

        }

    }

    void CameraOne()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);

    }

    void CameraTwo()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
    }
}
