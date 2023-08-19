Feature: Create-New-Invoices

A short summary of the feature

@tag1
Scenario: Adding Products to Invoice
    Given existing products
    When creating a new invoice and adding products
    Then the selected products are included in the invoice

  Scenario: Selecting Client for Invoice
    Given existing clients
    When creating a new invoice and selecting a client
    Then the client's information is associated with the invoice

  Scenario: Calculating Total Amount
    Given products with prices
    When adding products to an invoice
    Then the total amount is calculated accurately based on product prices
