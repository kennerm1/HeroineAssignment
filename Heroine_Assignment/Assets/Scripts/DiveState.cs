using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public class DiveState : MonoBehaviour, IBikeState
    {
        private BikeController _bikeController;

        public void Handle(BikeController bikeController)
        {
            if (!_bikeController)
                _bikeController = bikeController;

            _bikeController.CurrentSpeed =
                _bikeController.maxSpeed;

            bikeController.rb.AddForce(Vector3.down * _bikeController.JumpVelocity, ForceMode.Impulse);
        }
    }
}