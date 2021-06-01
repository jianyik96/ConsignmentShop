Consignment Shop Demo

Create an application that can be used by consignment shops to run their business. 
You need to know who the individuals/ vendors are who have items in the shop and 
you need to associate these vendors with their items. 
Each vendor should be assigned a standard commission, but that may need to be 
changed on a per-vendor basis. The application should track how much should be paid 
to each vendor as well as how much money should be paid to the store.

Requirements
1.	List of Vendors
2.	List of items per vendor
3.	Each vendor should have a default commission rate
4.	Commission can change
5.	Track how much to pay the vendor
6.	Track how much to pay the store

Vendor
FirstName string
LastName string
Commission double

Item
Title string
Description string
Price decimal
Sold boolean
Owner Vendor

Store
Vendors Vendor
Items Item