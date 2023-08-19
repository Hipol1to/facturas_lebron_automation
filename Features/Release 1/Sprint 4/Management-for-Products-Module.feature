Feature: Management-for-Products-Module

A short summary of the feature

@tag1
Scenario: Viewing and Updating Product Details
    Given a logged-in user
    When the user navigates to the products management page
    And selects an existing product
    And updates the product details
    Then the product's updated details should be saved in the database
