using System.ServiceModel;
namespace Models
{
    [ServiceContract]
    public interface IWiskundeServiceContract
    {
        [OperationContract]
        Vergelijking maakVergelijking(string vergelijking);
        [OperationContract]
        string afleiding(string wiskunde);
    }
}