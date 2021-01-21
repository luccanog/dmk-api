using DMKit.WebApi;

#nullable enable
public class Address : BaseModel
{
    public string Street { get; private set; }
    public string Neighborhood { get; private set; }
    public string CEP { get; private set; }
    public string Number { get; private set; }
    public string? AdditionalInfo { get; private set; }

    public Address(string street, string neighborhood, string cep, string number, string? additionalInfo = null)
    {
        Street = street;
        Neighborhood = neighborhood;
        CEP = cep;
        Number = number;
        AdditionalInfo = additionalInfo;
    }
}