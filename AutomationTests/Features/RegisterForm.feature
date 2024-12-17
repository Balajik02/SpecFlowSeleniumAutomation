@register
Feature: RegisterForm

  As a user,
  I want to fill out the registration form with all required details
  So that I can register successfully.

 Background: 
   Given I navigate to the registration page

 Scenario: Successful registration with all valid inputs
    When I fill out the register form
    #When I enter "John Doe" into the "Full Name" textbox
    #And I enter "john.doe@example.com" into the "Email" textbox
    #And I enter "password123" into the "Password" textbox
    #And I re-enter "password123" into the "Confirm Password" textbox
    #And I select "Male" from the radio buttons for "Gender"
    #And I check the checkbox for "I agree to the terms and conditions"
    #And I select "India" from the "Country" dropdown
    #And I select "1990-12-25" as the "Date of Birth" using the date picker
    #And I click on the "Register" button
    #Then I should see a success message "Registration completed successfully"
