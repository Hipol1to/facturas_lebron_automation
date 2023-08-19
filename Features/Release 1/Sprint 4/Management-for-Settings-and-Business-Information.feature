Feature: Management-for-Settings-and-Business-Information

A short summary of the feature

@tag1
Scenario: Configuring Company Information
    Given a logged-in user
    When entering company information in the settings panel
    And the user saves the configuration
    Then the company information should be saved in the database