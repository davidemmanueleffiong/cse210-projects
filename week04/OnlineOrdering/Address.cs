public class Address
{
    private readonly string _street;
    private readonly string _city;
    private readonly string _stateProvince;
    private readonly string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA", System.StringComparison.OrdinalIgnoreCase)
            || _country.Equals("United States", System.StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}
