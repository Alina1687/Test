Feature: AuthenticationFeature
	In order to validate login
	As an  user
	I need to authenticate into https://www.nobilacasa.ro/


@mytag
Scenario Outline: LoginWithValidUser
	Given I navigate to my authentication page
	When I login with following credentials
	| userEmail             |   userPassword		|
	| <userEmailValue>		|   <userPasswordValue> |
	Then I am successfully logged in


	Examples: 
| userEmailValue        | userPasswordValue |
| alytestare@gmail.com  | Test12345         |


#@LoginUsingCredentials
#Scenario: ValidateLoginUsingCredentials
#	Given I navigate to authentication page
#	When I login with user 'alytestare@gmail.com '
#		And password 'Test12345'
#	Then I am logged in