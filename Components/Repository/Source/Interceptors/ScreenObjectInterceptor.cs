using Bricks.RuntimeFramework;

namespace Repository.Interceptors
{
    using Castle.DynamicProxy;

    public class ScreenObjectInterceptor : IInterceptor
    {
        private readonly ReflectedObject reflectedScreen;

        public ScreenObjectInterceptor(AppScreen appScreen)
        {
            reflectedScreen = new ReflectedObject(appScreen);
        }

        public virtual void Intercept(IInvocation invocation)
        {
            reflectedScreen.Invoke(invocation.Method, invocation.Arguments);
        }
    }
}