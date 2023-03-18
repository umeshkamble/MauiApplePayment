# MauiApplePayment
Apple payment with MAUI application

1) Add Entitlements.plist file in project
2) Turn on the apple pay option
<img width="800" height="500" alt="OnApplepayoption" src="https://user-images.githubusercontent.com/5494166/226097993-899defeb-7d0c-4b4b-af0a-77dc62c2bac8.png">

3) Add merchant id in Merchants options
4) Set Entitlements.plist file in the bundle Signing section
<img width="800" height="500" alt="setentitlementsplistfile" src="https://user-images.githubusercontent.com/5494166/226098024-113fd65f-7fac-47f5-b9a3-dd4e9a3ba731.png">

5)Set the merchant id in platform code file

<img width="800" height="500" alt="setmerchantid in platform code file" src="https://user-images.githubusercontent.com/5494166/226098155-b9426f4d-8c48-4cee-9e47-e1476980c65a.png">

6)Build Application

7)Launch App 


|<img width="300" height="500" alt="homeSceen" src="https://user-images.githubusercontent.com/5494166/226098230-2ccc334f-03aa-4f96-80fa-b43e2f9b3fab.png">
|<img width="300" height="500" alt="PaymentAuthorizationView" src="https://user-images.githubusercontent.com/5494166/226098238-556add01-7963-4304-ba3c-edd143e620d5.png">
|<img width="300" height="500" alt="CompletePayment" src="https://user-images.githubusercontent.com/5494166/226098245-dc28b2f7-4ab9-4df5-bbdd-78f87684bfe3.png">

8)If you launch on simulator payment data will come null

9)If you launch on device it will return payment data.


Note: On the device running you need development and apple pay certificates install on device
