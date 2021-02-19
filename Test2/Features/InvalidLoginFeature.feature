Feature: InvalidLoginFeature
	In order to invalidate login
	I need to authenticate into https://www.nobilacasa.ro/ with incorrect crdeentials


@mytag
Scenario Outline: InvalidLogin
	Given I navigate to my authentication page
	When I login with following credentials
	| userEmail             |   userPassword		|
	| <userEmailValue>		|   <userPasswordValue> |
	Then error message appear


	Examples: 
| userEmailValue        | userPasswordValue |
| alytestare@gmail.com  | Test12345778      |
