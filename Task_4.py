import requests


URL = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"

response = requests.get(URL)
print(response.text)