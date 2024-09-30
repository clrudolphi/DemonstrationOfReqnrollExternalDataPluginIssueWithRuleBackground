Feature: Calculator

Simple calculator for adding two numbers
Rule: Can also use Rule Backgrounds
	Background: 
	Given the password is KEVIN
@DataSource:externaldata.csv
Scenario Outline: by using a table for inputs and outputs
	Given the first number is <first>
	And the second number is <second>
	When the two numbers are added
	Then the result should be <sum>
	And the password should be KEVIN
	Examples: 
	| first | second | sum |
	| 50    | 70     | 120 |
	