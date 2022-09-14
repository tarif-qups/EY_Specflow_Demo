Feature: TrendingNowTopics

#  TC-EY-03
  @EY
  Scenario: Trending now topics
    Given user enters the url
    And Welcome popup window should be displayed
    When user clicks I accept all cookies button
    Then home page should be displayed without popup
    When User scrolls down to Trending now section
    Then Trending now section should be displayed
    And Article on Metaverse should be displayed
    And Learn more button should be displayed
    When User clicks on learn more button
    Then Metaverse article page should be displayed
    When User scrolls down to Upvote section
    Then Upvote button should be displayed
    When User clicks on Upvote button
    Then Vote count should be increased