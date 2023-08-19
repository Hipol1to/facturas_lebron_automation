Feature: Users-Management-for-Admins

A short summary of the feature

@tag1
Scenario: Viewing Existing Users
    Given logged-in administrator
    When accessing the users management page
    Then the list of existing users is displayed

  Scenario: Updating User Information
    Given logged-in administrator
    When selecting a user to update
    And modifying user details
    Then the user's information is updated in the database
