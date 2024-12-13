Feature: RegisterForm

  As a user,
  I want to fill out the registration form with all required details
  So that I can register successfully.

  Background: 
   Given I navigate to the registration page

  Scenario: Successful registration with all valid inputs
    When I enter "John Doe" into the "Full Name" textbox
    And I enter "john.doe@example.com" into the "Email" textbox
    And I enter "password123" into the "Password" textbox
    And I re-enter "password123" into the "Confirm Password" textbox
    And I select "Male" from the radio buttons for "Gender"
    And I check the checkbox for "I agree to the terms and conditions"
    And I select "India" from the "Country" dropdown
    And I select "1990-12-25" as the "Date of Birth" using the date picker
    And I click on the "Register" button
    Then I should see a success message "Registration completed successfully"

  #Scenario: Registration with missing mandatory fields
  #  When I leave the "Full Name" textbox empty
  #  And I enter "john.doe@example.com" into the "Email" textbox
  #  And I leave the "Password" textbox empty
  #  And I select "Female" from the radio buttons for "Gender"
  #  And I check the checkbox for "I agree to the terms and conditions"
  #  And I select "USA" from the "Country" dropdown
  #  And I click on the "Register" button
  #  Then I should see error messages indicating the required fields

#  Scenario: Registration with invalid email format
#    Given I navigate to the registration page
#    When I enter "John Doe" into the "Full Name" textbox
#    And I enter "invalid-email" into the "Email" textbox
#    And I enter "password123" into the "Password" textbox
#    And I re-enter "password123" into the "Confirm Password" textbox
#    And I select "Male" from the radio buttons for "Gender"
#    And I check the checkbox for "I agree to the terms and conditions"
#    And I select "Canada" from the "Country" dropdown
#    And I select "1985-08-15" as the "Date of Birth" using the date picker
#    And I click on the "Register" button
#    Then I should see an error message "Invalid email format"
#
#  Scenario: Registration with mismatched passwords
#    Given I navigate to the registration page
#    When I enter "Jane Smith" into the "Full Name" textbox
#    And I enter "jane.smith@example.com" into the "Email" textbox
#    And I enter "password123" into the "Password" textbox
#    And I enter "differentpassword" into the "Confirm Password" textbox
#    And I select "Female" from the radio buttons for "Gender"
#    And I check the checkbox for "I agree to the terms and conditions"
#    And I select "Australia" from the "Country" dropdown
#    And I select "1995-03-30" as the "Date of Birth" using the date picker
#    And I click on the "Register" button
    Then I should see an error message "Passwords do not match"                 

