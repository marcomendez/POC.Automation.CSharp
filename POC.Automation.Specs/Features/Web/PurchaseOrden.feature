@Smoke
Feature: Purchase Orden

Background: Login
Given I navigate to Login
When I set '[UserName]' in UserName on Login
And I set '[Password]' in Password 
And I click Login
    

  @Login
  Scenario: Verify that can process a purchase order 
  Given I add 'Sauce Labs Backpack' to cart
  And I add 'Sauce Labs Bolt T-Shirt' to cart
  And I add 'Sauce Labs Onesie' to cart
  And I add 'Sauce Labs Bike Light' to cart
  When I click Cart Icon on Products
  And I click Checkout on Purchase Order
  And I set 'Test Fist Name' in First Name
  And I set 'Test Last Name' in Last Name
  And I set '000666' in Zip / Postal Code
  And I click Continue
  And I click Finish
  Then I should see the following text 'THANK YOU FOR YOUR ORDER' displayed
  And I should see the following text 'Your order has been dispatched, and will arrive just as fast as the pony can get there!' displayed
  And I should see 'Pony express image' displayed
