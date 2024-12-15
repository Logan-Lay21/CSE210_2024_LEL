using System;
public class Address {
    public string _streetAddress;
    public string _city;
    public string _stateProvince;
    public string _country;
    public Address(string streetAddress, string city, string stateProvince, string country) {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public string GetAddressLabel() {
        return $"{_streetAddress}\n{_city}, {_stateProvince} {_country}";
    }
    public bool IsDomesticUSA() {
        if (_country != "USA") {
            return false;
        }
        else {
            return true;
        }
    }
}