Feature: Management-for-Clients-Module

A short summary of the feature

@tag1
Scenario: Viewing and Updating Client Details
    Given a logged-in user
    When the user navigates to the clients management page
    And selects an existing client
    And updates the client details
    Then the client's updated details should be saved in the database
