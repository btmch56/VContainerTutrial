using VContainer.Unity;

namespace VContainerTutrial
{
    public class GamePresenter : IStartable
    {
        HelloWorldService _helloWorldService;
        HelloWorldScreen _helloWorldScreen;

        public GamePresenter(
            HelloWorldService helloWorldService,
            HelloWorldScreen helloWorldScreen
        )
        {
            _helloWorldService = helloWorldService;
            _helloWorldScreen = helloWorldScreen;
        }

        void IStartable.Start()
        {
            _helloWorldScreen.HelloButton.onClick.AddListener(() => _helloWorldService.Hello());
        }
    }
}
