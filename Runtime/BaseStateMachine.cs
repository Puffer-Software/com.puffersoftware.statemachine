using PufferSoftware.EventSystem;
using UnityEngine;

namespace PufferSoftware.StateMachine
{
    public class BaseStateMachine : Actor
    {
        #region Private Variables

        private State _currentState;

        #endregion

        #region MonoBehaviour Methods

        private void Update()
        {
            _currentState?.OnUpdate(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            _currentState?.OnFixedUpdate(Time.fixedDeltaTime);
        }

        private void LateUpdate()
        {
            _currentState?.OnLateUpdate(Time.deltaTime);
        }

        private void OnDrawGizmos()
        {
            _currentState?.OnDrawGizmos();
        }

        #endregion

        #region Public Methods

        public void SwitchState(State newState)
        {
            _currentState?.OnExit();
            _currentState = newState;
            _currentState.OnEnter();
        }

        #endregion
    }
}