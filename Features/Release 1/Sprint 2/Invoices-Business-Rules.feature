Feature: Invoices-Business-Rules

A short summary of the feature

@tag1
Scenario: Sorting Invoices
    Given existing invoices with various dates
    When sorting invoices by date ascending
    Then the invoices are displayed in ascending date order

  Scenario: Assigning Invoice Numbers
    Given an existing invoice
    When assigning a specific invoice number
    Then the invoice is associated with the assigned number

  Scenario: Automatic Tax Calculation
    Given a product with a price
    When adding the product to an invoice
    Then the total amount and taxes are calculated automatically