using JonasLindinger.SceneManagement;
using UnityEngine;

namespace Project.SceneManagement
{
    public class AutomaticSceneLoader : MonoBehaviour
    {
        [Header("Settings")] 
        [SerializeField] private int sceneGroupId;
        
        private async void Start()
        {
            await SceneLoader.GetInstance().LoadSceneGroup(sceneGroupId);
        }
    }
}