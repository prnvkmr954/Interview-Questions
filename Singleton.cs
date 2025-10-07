
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

sealed class SingletonThreadSafe
{
    private SingletonThreadSafe() { }

    private static SingletonThreadSafe _instance;
    private static readonly object _lock = new object();

    public static SingletonThreadSafe GetInstance()
    {
        if (_instance == null) // First check (no lock)
        {
            lock (_lock)
            {
                if (_instance == null) // Second check (with lock)
                {
                    _instance = new SingletonThreadSafe();
                }
            }
        }
       
        return _instance;
    }
}