using UnityEngine;

namespace GnosticDev
{
    public class SimpleUpdateManager : MonoBehaviour
    {
        public static SimpleUpdateManager instance;

        public delegate void OnTick();

        /// <summary>
        /// Global Tick Event
        /// </summary>
        public static event OnTick onTick;

        public delegate void OnFixedTick();

        /// <summary>
        /// Global FixedTick Event
        /// </summary>
        public static event OnFixedTick onFixedTick;

        public delegate void OnLateTick();

        /// <summary>
        /// Global LateTick Event
        /// </summary>
        public static event OnLateTick onLateTick;

        public bool ShouldTick;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(this);
        }

        private void Update()
        {
            if (ShouldTick)
            {
                onTick?.Invoke();
            }
        }

        private void FixedUpdate()
        {
            if (ShouldTick)
            {
                onFixedTick?.Invoke();
            }
        }

        private void LateUpdate()
        {
            if (ShouldTick)
            {
                onLateTick?.Invoke();
            }
        }
    }
}