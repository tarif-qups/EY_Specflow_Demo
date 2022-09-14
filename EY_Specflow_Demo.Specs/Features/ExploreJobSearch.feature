Feature: ExploreJobSearch

#    TC-EY-17
  @EY
  Scenario: Explore Job Search option from Career options
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    Given Career Option is visible in the nav bar
    And user clicks on Career option
    Then Career option wrapper should be visible
    And Job Search option should be visible
    When user clicks on Job search option
    Then Job search page should be loaded
    And Experienced professionals section should be visible
    When user clicks on Search job link
    Then EY Jobs page should be loaded
    And Search input field should be visible
    When user inputs "Manager" in the search field
    And Clicks Search button
    Then Jobs list should be visible
    When user clicks on Clear button
    Then Search input field should be cleared
    And Project manager job should be visible
    When user clicks on project manager
    Then Project manger job page should be loaded