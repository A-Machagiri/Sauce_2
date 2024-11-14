Feature: Login Functionality

  Scenario: Successful Login
    Given I navigate to the login page at 'https://www.saucedemo.com/'
    When I enter valid credentials
    Then I should be redirected to the product page

  Scenario: Unsuccessful Login
    Given I navigate to the login page at 'https://www.saucedemo.com/'
    When I enter invalid credentials
    Then I should see an error message
