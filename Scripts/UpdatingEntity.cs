using UnityEngine;

namespace GnosticDev

{
    public class UpdatingEntity : MonoBehaviour, ITick
    {
        private void OnEnable()
        {
            SimpleUpdateManager.onTick += Tick;
            SimpleUpdateManager.onFixedTick += FixedTick;
            SimpleUpdateManager.onLateTick += LateTick;
        }

        private void OnDisable()
        {
            SimpleUpdateManager.onTick -= Tick;
            SimpleUpdateManager.onFixedTick -= FixedTick;
            SimpleUpdateManager.onLateTick -= LateTick;
        }

        public void Tick() => Debug.Log("Ticking");

        public void FixedTick() => Debug.Log("Fixed Ticking");

        public void LateTick() => Debug.Log("Late Ticking");
    }
}