Feature: Signin into mars portal

As a mars portal user I want to be able to login into mars portal successfully


 Scenario Outline: Login into mars portal using valid credentials
	Given I login into mars portal using valid credentials'<username>' and '<password>' 
	Then I should be able to validate that I logged in successfully
	Examples: 
	| username                  | password |
	| truptisharma105@gmail.com | Trisha@105|
	
	
	

	

	

