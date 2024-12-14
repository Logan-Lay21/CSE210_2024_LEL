using System;

public class Order {
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer) {
        _customer = customer;
    }
    public void AddItem(Product product) {
        _products.Add(product);
    }
    public decimal GetTotalCost() {
        decimal totalCost = 0;
        foreach (Product product in _products) {
            totalCost += product.GetTotalCost(_customer);
        }
        int shipping;
        if (_customer.IsDomesticUSA(_customer.GetAddressLabel())) {
            shipping = 5;
        }
        else {
            shipping = 35;
        }
        totalCost += shipping;
        return totalCost;
    }
    public string GetPackingLabel() {
        string packingLabel = "";
        foreach (Product product in _products) {
            packingLabel += product.GetPackingLabel() + "\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel() {
        return _customer.GetName() + "\n" + _customer.GetAddress() + "\n\n";
    }

}