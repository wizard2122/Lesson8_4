using System;

public class LevelLoadingData
{
    private int _level;

    public LevelLoadingData(int level)
        => Level = level;

    public int Level
    {
        get => _level;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("value");

            _level = value;
        }
    }
}
