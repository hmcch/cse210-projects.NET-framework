public class Address
{
    // The Private members variables are to store address data
    // By being private the principle of encapsulation is applied

    private string _street;

    private string _city;

    private string _state;

    private string _country;


    // Constructor

    public Address(string street, string city, string state, string country)
    {
        _street = street;

        _city = city;

        _state = state;

        _country = country;
    }

    // Checking method to verify if the address is within the USA territory

    public bool IsInUSA()
    {
        // Converting to lowercase before comparison to avoid any bugs that could result while the costumer is typing

        return _country.ToLower() == "usa";
    }

    // Method returning single formatted string of the full postal address

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}