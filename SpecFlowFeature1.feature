Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sinus/cosinus/tanges of numbers

@mytag
Scenario: Sinus of a number
	Given the first number is <number>
	When the sinus is calculated
	Then the result should be <result>

Examples:
| number     |  result |
| 3.1415     |  0      |

Scenario Outline: Kosinus of a number
	Given the first number is <number>
	When the cosinus is calculated
	Then the result should be <result>

Examples:
| number     |  result |
| 3.1415     |  -1     |

Scenario Outline: Tangens of a number
	Given the first number is <number>
	When the tangens is calculated
	Then the result should be <result>

Examples:
| number     |  result |
| 3.1415     |  0      |