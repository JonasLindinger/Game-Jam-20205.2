using JonasLindinger.Singletons;
using UnityEngine;

namespace Project.Application
{
    public class FrameLimiter : MonoBehaviourSingleton<FrameLimiter>
    {
        [Header("Settings")]
        [SerializeField] private uint maxFPS = 240;
        
        private void Start()
        {
            UnityEngine.Application.targetFrameRate = (int) maxFPS;
        }
    }
}