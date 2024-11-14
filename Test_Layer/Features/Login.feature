Feature: Login Functionality
  In order to access the product page
  As a user of the website
  I want to log in to the website

  Scenario: Successful Login
    Given I am on the login page
    When I enter valid credentials
    And I click the login button
    Then I should be redirected to the product page

  Scenario: Unsuccessful Login
    Given I am on the login page
    When I enter invalid credentials
    And I click the login button
    Then I should see an error message