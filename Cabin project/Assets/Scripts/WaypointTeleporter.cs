//Isaac Southgate
//last updated 14/4/2024

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class WaypointTeleporter : MonoBehaviour
{
    [SerializeField] GameObject player;
    private bool waypointMenuState = true;
    [SerializeField] GameObject waypointMenu;
    [SerializeField] Transform[] waypoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
        //Diables and Enables the menu when E is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {            
            if (waypointMenuState == true)
            {
                waypointMenu.SetActive(false);
                waypointMenuState = false;
            }
            else
            {
                waypointMenu.SetActive(true);
                waypointMenuState = true;              
            }
        }
        //teleports the player to the waypoints when the number buttons are pressed
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.transform.position = waypoints[0].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player.transform.position = waypoints[1].position;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player.transform.position = waypoints[2].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            player.transform.position = waypoints[3].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            player.transform.position = waypoints[4].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            player.transform.position = waypoints[5].position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            player.transform.position = waypoints[6].position;
        }
    }
}
