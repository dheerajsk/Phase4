Feature: LoginFeature
	LOgin Page redirection

@mytag
Scenario: Redirect to login page
	Given Our home page has login button
	When User clicks on login button
	Then Redirect to login page