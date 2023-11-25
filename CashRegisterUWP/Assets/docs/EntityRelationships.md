---
title: EntityRelationships
author: Corey Thompson
description: Depiction of the inventory and purchasing entities
keywords: entity, diagram, sql, db, database, inventory, products
dev_langs:
  - csharp
---

# Conceptual Model

I have adopted the online shop example model from [here](https://vertabelo.com/blog/er-diagram-for-online-shop/) to accomodate the concept of inventory and drop wishlists.

The relationships between the entities are as follows:

- A customer can place several orders, therefore between `customer` and `order` there must be a one-to-many relationship
- An order can contain one or several items, each of which is a single product. 
- `order_item` is dependent on `order` and is related to `product` through a one-to-many.
- An order is associated with one payment and shipment. In-store purchases are immediately-fulfilled shipments.
- A `location` can carry none or many unique `product` skus
- A `shipment` is fullfilled by a `location` with sufficient product quantity
- A product can belong to a single category; one-to-many relationship between `product` and `category`
- A `cart` belongs to and is dependent on a `customer`. Each instance of `cart` is related to a product, so both have a many-to-one relationship with `product`
- A `payment` is placed by a single `customer` to apply to an `order`

![Conceptual Entity Relationship](er_store_transactions.png)

# Logical Model

# Physical Model