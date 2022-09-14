Feature: ExplorePeoplePage

#    TC-EY-20
  @EY
  Scenario: Explore people page
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    Given About option is available in the nav bar
    And User clicks About option
    Then About wrapper should be visible
    And Our people option should be visible
    When User clicks on Our people option
    Then Our people section should be displayed
    When User clicks Read more button in people section
    Then More information about people should be displayed
    And EY Badges link should be displayed
    When User clicks on EY Badges link
    Then Personalized career development page should be loaded