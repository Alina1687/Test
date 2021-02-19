Feature: GotoBlogPageFeature
	From Home go to Blog Page

@GotoBlogPage
Scenario: GotoBlogPage
	Given I am on the site
	And from the home page
	When I press the Blog button
	Then I am sent to Blog page
	