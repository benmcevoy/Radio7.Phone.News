namespace Rss.Manager.RelatedLinks
{
    public interface IResolver<out T>
    {
        T Resolve(string key);
    }
}