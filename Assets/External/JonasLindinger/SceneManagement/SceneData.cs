using System;
using Eflatun.SceneReference;

namespace JonasLindinger.SceneManagement
{
    [Serializable]
    public class SceneData
    {
        public SceneReference reference;
        public string Name => reference.Name;
        public SceneType sceneType;
    }
}