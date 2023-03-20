using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEnterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            Debug.Log("Event triggered");

        }
    }
}
