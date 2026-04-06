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

print(books)

with open("books.csv", "w", newline="", encoding="utf-8") as f:
    writer = csv.DictWriter(f, fieldnames=["Name", "Rating", "Price"])
    writer.writeheader()
    writer.writerows(books)

print("CSV file created successfully")