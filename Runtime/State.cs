namespace PufferSoftware.StateMachine
{
    public abstract class State
    {
        public abstract void OnEnter();
        public abstract void OnUpdate(float deltaTime);
        public abstract void OnFixedUpdate(float deltaTime);
        public abstract void OnLateUpdate(float deltaTime);
        public abstract void OnExit();
        public abstract void OnDrawGizmos();
    }
}