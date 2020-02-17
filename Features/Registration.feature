Feature: Registration
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Registration
	Given a user launch Giftrete App
	When a user click on register
	And a user enter firstname "Tester"
	And a user enter lastname "Giftrete"
	And a user enter email 
	And a user enter mobile "070070707000"
	And a user enter password 
	And a user confirm password "TestPass!23"
	And a user click register
	#Then a user is registered
	