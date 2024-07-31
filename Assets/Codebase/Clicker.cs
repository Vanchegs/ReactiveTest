using R3;
using UnityEngine;
using UnityEngine.UI;

namespace Codebase
{
    public class Clicker : MonoBehaviour
    {
        private const string ScorePattern = "Score: {0}";

        [SerializeField] private Text text;
        [SerializeField] private Button button;
        [SerializeField] private ColorChanger colorChanger;

        private ReactiveProperty<int> score;

        private void Awake() => 
            button.onClick.AddListener(OnClick);

        private void Start()
        {
            score = new ReactiveProperty<int>(0);

            score.Subscribe(_ => { colorChanger.ChangeColor(); });
        }

        private void OnDestroy()
        {
            button.onClick.RemoveListener(OnClick);
            
            score.Dispose();
        }

        private void OnClick() =>
            text.text = string.Format(ScorePattern, score.Value++);
    }
}
