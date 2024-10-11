<div style="display: flex; gap: 1rem">

| Order                                |
|--------------------------------------|
| - _products: List<Product>           |
| - _customer: Customer                |
|                                      |
| + getPackingLabel(): String          |
| + getShippingLabel(): String         |
| + calculateTotalCost(): double       |

| Product                              |
|--------------------------------------|
| - _name: String                      |
| - _productId: String                 |
| - _price: double                     |
| - _quantity: int                     |
|                                      |
| + getTotalCost(): double             |

| Customer                             |
|--------------------------------------|
| - _name: String                      |
| - _address: Address                  |
|                                      |
| + isInUSA(): bool                    |

| Address                              |
|--------------------------------------|
| - _street: String                    |
| - _city: String                      |
| - _state: String                     |
| - _country: String                   |
|                                      |
| + isInUSA(): bool                    |
| + getFullAddress(): String           |

</div>