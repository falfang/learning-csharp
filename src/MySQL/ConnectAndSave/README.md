# Create Database table in command line

```sql
CREATE DATABASE testdb;
USE testdb;

CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

```

# Result

```
mysql -u root -p

mysql> USE testdb;
mysql> SELECT * FROM users;
+----+----------+------------+---------------------+
| id | name     | email      | created_at          |
+----+----------+------------+---------------------+
|  1 | HogeFuga | pyon.co.jp | 2025-03-08 15:00:13 |
+----+----------+------------+---------------------+1
```