Feature: User-Administration

A short summary of the feature

@tag1
Scenario: Adding New User
    Given logged-in administrator
    When adding a new user with appropriate permissions
    Then the new user's information is stored in the database

  Scenario: Unauthorized User Creation
    Given logged-in user without admin privileges
    When attempting to add a new user
    Then the system rejects the user creation request
