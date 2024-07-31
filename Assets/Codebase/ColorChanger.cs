using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Codebase
{
    public class ColorChanger : MonoBehaviour
    {
        [SerializeField] private Image background;

        private Color[] colors = new[]
        {
            Color.black, 
            Color.blue, 
            Color.cyan, 
            Color.gray, 
            Color.magenta, 
        };

        public void ChangeColor() => 
            background.color = colors[Random.Range(0, colors.Length)];
    }
}