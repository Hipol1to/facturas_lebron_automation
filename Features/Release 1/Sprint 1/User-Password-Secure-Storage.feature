Feature: User-Password-Secure-Storage

Ensure that the password decription is secure

Scenario: Password encryption
    Given a user with credentials
    When the user's password is saved
    Then the password is encrypted using a strong algorithm
    And the encrypted password is stored in the database

  Scenario: Password decryption is not possible
    Given an encrypted password in the database
    When attempting to decrypt the password
    Then the decrypted password is not readable
    And the decrypted password does not match the original password


