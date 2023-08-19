Feature: Invoice-IVA-Fee-Percentage

A short summary of the feature

@tag1
Scenario: Setting IVA Fee Percentage
    Given logged-in user with admin privileges
    When accessing the settings panel
    And configuring the IVA fee percentage
    Then the configured percentage is stored in the database
