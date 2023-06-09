Feature: TestYopMail
	Scenario: Log in web page of post office YopMail
		Given I have the website
		When Create user
		Then I see the control panel
	Scenario: Send email
		Given Open Mail Screen
		When Write Email to send
		Then Check mail delivery
	Scenario: Verify arrival of mail in the mailbox
		Given Switch to Inbox Section
		When Check mail sent in the mailbox
		Then Close browser
