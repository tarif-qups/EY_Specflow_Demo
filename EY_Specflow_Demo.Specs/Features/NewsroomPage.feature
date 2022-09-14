Feature: NewsroomPage

#  TC-EY-08
  @EY
  Scenario: Newsroom Page
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    When User scrolls down to the end
    Then Footer section should be visible
    And Site map link should be visible
    When User clicks on Site map link
    Then Site map page should be loaded
    And News section should be displayed
    And Press releases link should be displayed
    When User clicks on Press Releases link
    Then Newsroom page should be loaded
    And Media inquiries section should be visible
    And Get in touch button should be available
    When User clicks on Get in touch button
    Then Get in touch form should be visible