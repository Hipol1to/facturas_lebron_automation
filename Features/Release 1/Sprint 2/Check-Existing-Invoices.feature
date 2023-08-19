Feature: Check-Existing-Invoices

A short summary of the feature

@tag1
Scenario: Viewing Invoice Details
    Given existing invoices
    When selecting an invoice
    Then the invoice details are displayed, including client and items

  Scenario: Tracking Payment Status
    Given paid and unpaid invoices
    When checking invoice payment status
    Then the payment status for each invoice is accurately displayed
