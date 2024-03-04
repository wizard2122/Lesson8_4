using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class GameplayHUD : MonoBehaviour
{
    [SerializeField] private Button _mainMenuButton;

    private SceneLoadMediator _sceneLoader;

    [Inject]
    private void Construct(SceneLoadMediator sceneLoadMediator, LevelLoadingData levelLoadingData)
    {
        _sceneLoader = sceneLoadMediator;
        Debug.Log($"LevelNumber: {levelLoadingData.Level}");
    }

    private void OnEnable()
        => _mainMenuButton.onClick.AddListener(OnMainMenuClick);

    private void OnDisable()
        => _mainMenuButton.onClick.RemoveListener(OnMainMenuClick);

    private void OnMainMenuClick() => _sceneLoader.GoToMainMenu();
}
