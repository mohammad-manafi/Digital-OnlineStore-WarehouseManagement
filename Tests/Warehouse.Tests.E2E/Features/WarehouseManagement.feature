@api
Feature: Warehouse Management
	As A Aarehouse Keeper
	I Want To Keep Track Of My Inventory
	So That I Always Have Accurate Info About Products Stock


Scenario: Defining New Warehouse
	Given I want to add the following inventory to my warehouse
		|ProductName |Brand   |Model         |UnitPrice |
		|Mobile      |IPhone  |Pro max 13    |1100      |
		|Tablet      |Samsung |Galaxy Tab S8 |960       |
	When I Try To Define This Inventory
	Then The Inventory Should Be Created
	And It Should Be Empty
