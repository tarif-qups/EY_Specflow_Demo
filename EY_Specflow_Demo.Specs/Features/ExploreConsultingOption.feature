Feature: ExploreConsultingOption
    
#    TC-EY-13
  @EY
  Scenario: explore consulting option from services options
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    Given Services option is visible in the nav bar
    And User clicks Services option
    Then Services wrapper should be displayed
    And Consulting option should be displayed
    When user clicks on Consulting option
    Then Analytics Consulting Service option should be visible
    When User clicks on Analytics Consulting Service
    Then Analytics Consulting Service page should loaded
    And Related topics section should be displayed
    When User clicks consulting button
    Then Consulting page should be loaded