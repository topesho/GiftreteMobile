Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Login
	Given a user launch Giftrete App
	When a user enter email "test@giftrete.com"
	And a user enter password "TestPass!23"
	And a user click login 
	Then a user is signed in


