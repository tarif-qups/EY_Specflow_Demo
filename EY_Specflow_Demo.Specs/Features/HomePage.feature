Feature: Home Page

#  TC-EY-01
  @EY
  Scenario: Displayed Home Page
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup