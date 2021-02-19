Feature: LoginAndLogoutFeature
	Description: This feature will test a LogIn and LogOut functionality



@mytag
Scenario Outline: LoginAndLogout
	Given I navigate to my authentication page
	When I login with following credentials
	| userEmail             |   userPassword		|
	| <userEmailValue>		|   <userPasswordValue> |
	Then I am successfully logged ou


	Examples: 
| userEmailValue        | userPasswordValue |
| alytestare@gmail.com  | Test12345         |
