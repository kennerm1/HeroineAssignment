using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public class ClientState : MonoBehaviour
    {
        private BikeController _bikeController;

        void Start()
        {
            _bikeController =
                (BikeController)
                FindObjectOfType(typeof(BikeController));
        }

        void OnGUI()
        {
            if (Input.GetKeyDown(KeyCode.Space) && _bikeController._isGrounded)
            {
                Debug.Log("Jump");
                _bikeController.Jump();
            }

            if (Input.GetKeyDown(KeyCode.S) && !_bikeController._isGrounded)
            {
                Debug.Log("Dive");
                _bikeController.Dive();
            }

            if (Input.GetKeyDown(KeyCode.S) && _bikeController._isGrounded)
            {
                Debug.Log("Duck");
                _bikeController.Duck();
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                Debug.Log("Stand");
                _bikeController.Stand();
            }

            if (Input.GetKeyUp(KeyCode.M))
            {
                Debug.Log("Melancholy");
                _bikeController.Melon();
            }

            if (Input.GetKeyUp(KeyCode.G))
            {
                Debug.Log("Grow");
                _bikeController.Grow();
            }

            if (Input.GetKeyUp(KeyCode.R))
            {
                Debug.Log("Rave");
                _bikeController.Rave();
            }
            /*
            if (GUILayout.Button("Start Bike"))
                _bikeController.StartBike();

            if (GUILayout.Button("Turn Left"))
                _bikeController.Turn(Direction.Left);

            if (GUILayout.Button("Turn Right"))
                _bikeController.Turn(Direction.Right);

            if (GUILayout.Button("Stop Bike"))
                _bikeController.StopBike();*/
        }
    }
}
