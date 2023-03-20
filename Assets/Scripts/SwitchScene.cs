using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public GameObject player;
    public GameObject ForHidingPurposes;

    public void Awake()
    {
        ForHidingPurposes = GameObject.Find("ForHidingPurposes");
    }


    [SerializeField] RectTransform transition;
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            OpenCombatScene();

        }
    }

    public void OpenCombatScene()
    {

            ForHidingPurposes.SetActive(false);
            SceneManager.LoadScene(1, LoadSceneMode.Additive);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
