using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class DoorInteraction : MonoBehaviour
{
    [SerializeField] private GameObject connectedRoom;
    [SerializeField] private GameObject currRoom;
    [SerializeField] private CinemachineVirtualCamera mainCamera;
    [SerializeField] private GameObject player;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            connectedRoom.SetActive(true);
            currRoom.SetActive(false);
            mainCamera.Follow = player.transform;
            mainCamera.LookAt = player.transform;
        }
    }

}
