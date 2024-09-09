using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public class BikeController : MonoBehaviour
    {

        public float maxSpeed = 2.0f;
        public float turnDistance = 2.0f;
        public Rigidbody rb;
        public bool _isGrounded
        {
            get { return Physics.Raycast(transform.position, -Vector3.up, 1f, groundLayer); }
        }
        public LayerMask groundLayer;
        public float JumpVelocity = 7.0f;
        public float DiveVelocity = 2.0f;

        public float CurrentSpeed { get; set; }

        public Direction CurrentTurnDirection
        {
            get; private set;
        }

        private IBikeState
            /*_startState, _stopState,*/ _turnState, _jumpState, _diveState, _duckState, _standState, _melonState, _growState, _raveState;

        private BikeStateContext _bikeStateContext;

        private void Start()
        {
            _bikeStateContext =
                new BikeStateContext(this);

            /*
            _startState =
                gameObject.AddComponent<BikeStartState>();
            _stopState =
                gameObject.AddComponent<BikeStopState>();
            

            _bikeStateContext.Transition(_stopState);*/

            _turnState =
                gameObject.AddComponent<BikeTurnState>();

            _jumpState =
                gameObject.AddComponent<JumpState>();

            _diveState =
                gameObject.AddComponent<DiveState>();

            _duckState =
                gameObject.AddComponent<DuckState>();

            _standState =
                gameObject.AddComponent<StandState>();

            _melonState =
                gameObject.AddComponent<MelonState>();

            _growState =
                gameObject.AddComponent<GrowState>();

            _raveState =
                gameObject.AddComponent<RaveState>();
        }

        public void Jump()
        {
            _bikeStateContext.Transition(_jumpState);
        }

        public void Dive()
        {
            _bikeStateContext.Transition(_diveState);
        }

        public void Turn(Direction direction)
        {
            CurrentTurnDirection = direction;
            _bikeStateContext.Transition(_turnState);
        }

        public void Duck()
        {
            _bikeStateContext.Transition(_duckState);
        }

        public void Stand()
        {
            _bikeStateContext.Transition(_standState);
        }

        public void Melon()
        {
            _bikeStateContext.Transition(_melonState);
        }

        public void Grow()
        {
            _bikeStateContext.Transition(_growState);
        }

        public void Rave()
        {
            _bikeStateContext.Transition(_raveState);
        }
    }
}
