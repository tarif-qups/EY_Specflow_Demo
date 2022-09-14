Feature: SearchTopic
    
#  TC-EY-02
  @EY
  Scenario: Search a topic
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    And Search button should be visible in the nav bar
    When user clicks on search button
    Then Search input field should be displayed
    And Trending Section should be displayed
    When User inserts "Career" in the input field
    Then Topic section should be displayed
    And General section should be displayed
    And People section should be displayed
    When user presses enter
    Then Search results page should be loaded
    And Sorting options should be visible
    And Filtering options should be visible
    When User clicks About checkbox from filters options
    Then Filtered topics should be displayed