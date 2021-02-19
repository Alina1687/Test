Feature: FavoriteListFeature
	In order to see the Favorite List
	I need to login first on https://www.nobilacasa.ro
	And then I can see the favorites list

@ViewFavoriteList
Scenario: ViewFavoriteList
	Given I navigate to my authentication page
	When I login with following credentials
	| userEmail             |   userPassword		|
	| <userEmailValue>		|   <userPasswordValue> |
	Then I can go to FavoriteList


	Examples: 
| userEmailValue        | userPasswordValue |
| alytestare@gmail.com  | Test12345         |