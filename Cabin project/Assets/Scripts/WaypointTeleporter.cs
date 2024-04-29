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
            waypoints[0].GetComponent<NavigationWaypoint>().Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            waypoints[1].GetComponent<NavigationWaypoint>().Activate();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            waypoints[2].GetComponent<NavigationWaypoint>().Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            waypoints[3].GetComponent<NavigationWaypoint>().Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            waypoints[4].GetComponent<NavigationWaypoint>().Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            waypoints[5].GetComponent<NavigationWaypoint>().Activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            waypoints[6].GetComponent<NavigationWaypoint>().Activate();
        }
    }
}
