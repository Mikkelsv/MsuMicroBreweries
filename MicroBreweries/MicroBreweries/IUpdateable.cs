namespace MicroBreweries
{
    internal interface IUpdateable<T>
    {
        void Update(T newInstance);
        string Name { get; }
    }
}