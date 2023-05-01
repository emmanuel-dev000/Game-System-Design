using VContainer;
using VContainer.Unity;

public class BrickBreakerLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<AudioPresenter>();
        builder.Register<AudioService>(Lifetime.Scoped);
        builder.Register<IAudioPlayer, NormalAudioPlayer>(Lifetime.Singleton);
    }
}