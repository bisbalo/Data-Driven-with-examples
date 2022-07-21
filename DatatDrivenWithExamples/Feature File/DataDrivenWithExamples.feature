Feature: DataDrivenWithExamples

To be be able to enter different data for the same Scenario on the website
	

	Scenario Outline: Valid Registration
	Given I navigate to the website "https://angularjs.realworld.io/#/"
	And I click on sign up 
	And I enter my username "<username>"
	And I enter my email address "<email>"
	And i enter my password "<password>"
	When I click on the sign up button
	Then I should be able to sign up successfully

	Examples:
	| username | email           | password |
	| Ade      | ade@yahoo.com   | dodo1    |
	| Meena    | meena@gmail.com | nana101  |
	| Morry    | morry@yahoo.com | didi     |
	| Bisi     | bisi@aol.com    | bisbis   |
	| Tola     | dodo@yahoo.com  | tolitoli |
	| Sola     | ola@yahoo.com   | lalala   |