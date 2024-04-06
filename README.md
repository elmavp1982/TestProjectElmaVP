Project name: Testing Webshop

Project description: Testing some basic functionality of webshop

Prerequisites:
- have windows machine
- chrome browser installed
  
Tool used:
- have Visual Studio installed
- installed: Microsoft.Net.Test.Sdk,nUnit, nUnit3.TestAdapter, SeleniumSupport, SeleniumWebDriver

How this project was setup:
- have C:\TARepo\elmavp1982 folder created localy on your C: disk
- go to github link: https://github.com/elmavp1982/TestProjectElmaVP and clone repository on location from previous step

Running tests:
  All the tests are present in SeleniumTest.cs. Run tests in a way to go in VisualStudio on Test->Test Explorer and 
  run  individual or all test cases
  
What this test does:
  This test opens up chrome browser and loads a website - https://www.amazon.com (webshop)

Test cases are:
1. Verify Logo
2. Menu items count
3. Go to sell page
4. Login to the webshop with correct username and password
5. Login to the webshop with incorrect username or password
6. Search an item
7. Add item to cart
8. Remove item from cart
9. Proceed invalid visa card number
10. ...


