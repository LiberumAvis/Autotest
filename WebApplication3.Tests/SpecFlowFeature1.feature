Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Search with MaxiMArkets
    Given Launch Chrome
    And Navigate to fxtrends
    When Enter MaxiMarkets
    And Click on Search Button
    Then Results should be visible and Browser shold close
