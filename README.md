Project name: Testing Webshop

Project description: Testing some basic functionality of webshop

Prerequisites:
- have windows machine
- chrome browser installed
  
Tool used:
- have Visual Studio installed
- installed: Microsoft.Net.Test.Sdk, nUnit, nUnit3.TestAdapter, SeleniumSupport, SeleniumWebDriver, DotNetSeleniumExtras.WaitHelpers

How this project was setup:
- go to github link: https://github.com/elmavp1982/TestProjectElmaVP and clone repository localy on your windows machine (i.e. somwhere on C: drive)

Running tests:
  All the tests are present in SeleniumTest.cs. Run tests in a way to go in VisualStudio on Test->Test Explorer and 
  run  individual or all test cases
  
What this test does:
  This test opens up chrome browser and loads a website - https://www.amazon.com (webshop)

Test cases are:
1. Verify Logo
   - verify logo on home page
  
3. Menu items count
   - verify how many items exist on menu on home page
  
4. Go to sell page
   - click and navigate on one sub-page (in this case Sell page)
     
5. Login to the webshop with correct username and password
   - on home page try to sign in using correct creds and verify that user is properly logged in
     
7. Login to the webshop with incorrect username or password
   - on home page try to sign in using incorrect creds and verify that user cannot be logged in, appropriate message appears
     
9. Search an item
    - click in search editbox and enter name of one product
      
11. Add item to cart
    - add this item to cart by click on appropriate button
      
13. Remove item from cart
    - go to cart and click on delete item from the cart
      
15. Proceed invalid visa card number
    - proceed to checkout and then try to provide incorrect visa card number
      
17. Verify price of item in cart
    - verify that price is the same on found product after search it and in cart once when you added it there


