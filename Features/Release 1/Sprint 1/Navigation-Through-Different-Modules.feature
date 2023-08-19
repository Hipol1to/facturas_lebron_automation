Feature: Navigation-Through-Different-Modules

A short summary of the feature

@tag1
Scenario: Navigating to Clients Module
    Given a logged-in user
    When the user clicks on the 'Clients' module shortcut
    Then the user is taken to the Clients module page

  Scenario: Navigating to Products Module
    Given a logged-in user
    When the user clicks on the 'Products' module shortcut
    Then the user is taken to the Products module page