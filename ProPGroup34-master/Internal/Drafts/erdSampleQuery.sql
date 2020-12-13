/* Total visitors */
SELECT COUNT(*)
FROM VISITOR;

/* Visitors that left t/m the point of making the query */
SELECT COUNT(*)
FROM VISITOR 
WHERE checkedOut = 'Y';

/* Visitors that are still present t/m the point of making the query */
SELECT COUNT(*)
FROM VISITOR
WHERE checkedOut = 'N';

/* Visitors that didn't stay for the whole event */
SELECT COUNT(*)
FROM VISITOR
WHERE checkoutDate < #dd-mon-yy#;

/* Check items not returned for a visitor and where to return them */
SELECT itemID, itemName, storeName, storeLocation
FROM ITEMS i, LOAN_ITEMS l, STORE s
WHERE i.itemID = l.itemID
AND l.storeID = s.storeID 
AND returned = 'N'
AND visitorID = &enter_visitor_ID;

/* SOME QUERIES FROM THE WORKBOOK */

SELECT SUM(cardBalance) "Total balance"
FROM CARD;	

SELECT SUM(itemPrice * quantity) "Total spent money"
FROM ORDER_LINE;

SELECT storeID, SUM(orderTotal) "Total sold per shop"
FROM ORDER
GROUP BY storeID;

SELECT itemID, SUM(itemPrice * quantity) "Total sold per product"
FROM ORDER_LINE
GROUP BY itemID;

SELECT campID, campName
FROM CAMP
WHERE booked = 'N';