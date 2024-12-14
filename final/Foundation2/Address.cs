using System;

public class Address {
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country) {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public bool IsDomesticUSA() {
        if (_country != "USA") {
            return false;
        }
        else {
            return true;
        }
    }
    public string GetAddressLabel() {
        return $"{_streetAddress}\n{_city}, {_stateProvince} {_country}";
    }
}