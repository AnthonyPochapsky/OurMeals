# About the app

## Basic info
Smart Fridge-like prototype comprised strictly of a functioning frontend created for the purpose of UX testing the following high-level features: fridge inventory management, recipe creation, shopping list management, and shopping.

## Constraints when interacting with the app
Certain areas of the application are incomplete in terms of how free-form the user can act for specific use cases. The following guidelines should be considered when interacting with this application:

- The only recipe that can be created requires the selection of apple and tomato inventory supply boxes that are both 2 or more in quantity.

- When accessing the sales on all missing supplies since the refrigerator inventory domain consists of just an apple, tomato, and leek, it means that if all three of these were to exist in the fridge no supplies would be considered missing and no sales for missing supplies would be created. Also, the missing sale items produced appear in the same menu as all existing sales and so will complement or supplement the already existing sales.

- The shopping Itinerary can only be specified by selecting both the cheapest apple sale item and the cheapest tomato sale item. Otherwise, if other sale items are selected alone or alongside these, the resulting itinerary will not make sense.

- The purchase of shopping list items that result in the subsequent updation of the home inventory only works if the purchased item box corresponds to an apple, tomato, or leek box. The way a specific box corresponds to one of these three supplies depends on whether the supply name is written in the box (case-insensitive). One supply name per box.

- Likewise when adjusting a specific shopping list based on current inventory supplies by removing items from the shopping list that are already in inventory will be based on the case-insensitive written names of these supplies like mentioned previously.

- Routine Shopping lists are implemented such that only one may exist at a time. This means that when you create a new routine shopping list or turn an existing one into a routine shopping list it will convert the previous one out of its special routine state and make the newly created one routine in its place.

- Every item box that may be purchased from some shopping list corresponds to exactly one unit of quantity for that particular type of item without there being a means to have one item box align with multiple units of quantity.

# How to run it
Upon downloading a zip of the repo and extracting the project files locally you can then access the executable at the following location within the project:
**OurMeals/bin/Release/net6.0-windows/OurMeals.exe**

