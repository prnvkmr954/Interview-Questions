
//Thread Unsafe
sealed class SingletonThreadUnSafe
{
    private SingletonThreadUnSafe() { }

    private static SingletonThreadUnSafe _instance;

    public static SingletonThreadUnSafe GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SingletonThreadUnSafe();
        }

        return _instance;
    }

}




// Thread Safe
sealed class SingletonThreadSafe
{
    private SingletonThreadSafe() { }

    private static SingletonThreadSafe _instance;
    private static readonly object _lock = new object();

    public static SingletonThreadSafe GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new SingletonThreadSafe();
                }
            }
        }

        return _instance;
    }

}

