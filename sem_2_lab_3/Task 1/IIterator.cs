using System;
namespace ForAll
{
    public interface IIterator<T>
    {
        bool HasNext { get; }
        T MoveNext();
    }
}

