using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject cameraMain;
    [SerializeField] private GameObject cones;

    [SerializeField]private Vector3 spawnRight;
    [SerializeField]private Vector3 spawnLeft;
    public float distanceToHoizon;
    Movement movement;
    UI_Button uiButton;


    void Awake()
    {
        movement = FindObjectOfType<Movement>();
        uiButton = FindObjectOfType<UI_Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float distanceToHoizon = Vector3.Distance(cameraMain.transform.position, spawnRight);
        if (distanceToHoizon < 60f)
        {
            if (uiButton.sceneNumber == 1)
                SpawnCones();
            else if (uiButton.sceneNumber == 2)
                SpawnFence();
        }
    }

    private void SpawnCones() // Level one
    {
        spawnRight = new Vector3(7.8f, 0, spawnRight.z + 10);
        GameObject spawnRightEdges = Instantiate(cones, spawnRight, Quaternion.Euler(-90f,0f,0f));

        spawnLeft = new Vector3(-9f, 0, spawnLeft.z + 10);
        GameObject spawnLeftEdges = Instantiate(cones, spawnLeft, Quaternion.Euler(-90f,0f,0f));
    }
    private void SpawnFence() // Level two
    {
        spawnRight = new Vector3(7.8f, 1.5f, spawnRight.z + 3f);
        GameObject spawnRightEdges = Instantiate(cones, spawnRight, Quaternion.Euler(-90f, 0f, 0f));

        spawnLeft = new Vector3(-9f, 1.5f, spawnLeft.z + 3f);
        GameObject spawnLeftEdges = Instantiate(cones, spawnLeft, Quaternion.Euler(-90f, 0f, 0f));
    }

}
