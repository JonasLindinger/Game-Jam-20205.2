using UnityEngine;
using JonasLindinger.SceneManagement;
using JonasLindinger.Singletons;
using UnityEngine.SceneManagement;

namespace JonasLindinger.SceneManagement
{
    public class Bootstrapper : MonoBehaviourSingleton<Bootstrapper>
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static async void Init()
        {
            if (SceneManager.GetActiveScene().name == "Bootstrapper")
                return;
            await SceneManager.LoadSceneAsync("Bootstrapper", LoadSceneMode.Single);
        }   
    }
}