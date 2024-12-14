using System;

public class Customer {
    private string _name;
    private Address _address;
    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }
    public bool IsDomesticUSA(Address address) {
        if (address.IsDomesticUSA()) {
            return true;
        }
        else {
            return false;
        }
    }
    public string GetName() {
        return _name;
    }
    public Address GetAddressLabel() {
        return _address;
    }
    public string GetAddress() {
        return _address.GetAddressLabel();
    }
}