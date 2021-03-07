namespace PlantIT.API.Services.Queries
{
    public interface ICommandText
    {
       string Get { get; }
       string GetById { get; }
       string Add { get; }
       string Update { get; }
       string Remove { get; }
    }
}