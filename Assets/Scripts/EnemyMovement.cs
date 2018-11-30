using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Transform playerModel;
    CharacterController controller;

    [SerializeField] float moveSpeed = 5.0f;
    [SerializeField] float distance = 5.0f;

    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        playerModel = playerGameObject.transform;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if ((playerModel.position - transform.position).magnitude > distance)
        {
            Vector3 direction = playerModel.position - transform.position;
            controller.Move((direction * Time.deltaTime * moveSpeed));
        }
    }

}
