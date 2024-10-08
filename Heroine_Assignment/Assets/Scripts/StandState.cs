using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public class StandState : MonoBehaviour, IBikeState
    {
        private BikeController _bikeController;

        public void Handle(BikeController bikeController)
        {
            if (!_bikeController)
                _bikeController = bikeController;

            _bikeController.CurrentSpeed =
                _bikeController.maxSpeed;

            bikeController.transform.localScale = new Vector3(1, 1, 1);
            if (bikeController.mr.enabled == false)
                bikeController.mr.enabled = true;
            bikeController.rave.SetActive(false);
        }
    }
}