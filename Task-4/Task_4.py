import requests
from bs4 import BeautifulSoup
import csv

URL = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"

response = requests.get(URL)
soup = BeautifulSoup(response.text, "html.parser")

books = []

for article in soup.find_all("article", class_="product_pod"):
    name = article.h3.a["title"]
    rating = article.p["class"][1]
    price = article.find("p", class_="price_color").text.strip()

    books.append({
        "Name": name,
        "Rating": rating,
        "Price": price
    })

print("Data saved to books.csv\n")

with open("books.csv", "w", newline="", encoding="utf-8") as f:
    writer = csv.DictWriter(f, fieldnames=["Name", "Rating", "Price"])
    writer.writeheader()
    writer.writerows(books)

print("CSV file created successfully")

with open("books.csv", newline="", encoding="utf-8") as f:
    reader = csv.DictReader(f)
    print(f"{'Name':<50} {'Rating':<10} {'Price'}")
    print("-" * 70)
    for row in reader:
        print(f"{row['Name']:<50} {row['Rating']:<10} {row['Price']}")