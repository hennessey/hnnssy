Feature: Core
	In order to know where the hell I am on the internet
	As someone interested in who the hell I am
	I want to know that I am in fact on John Hennessey's personal

@Core
Scenario: Access the website
	Given I am on the homepage
	Then the title tag should indicate that it's my site