import socket
import sqlite3

HOST = "127.0.0.1"
PORT = 65432

server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server_socket.bind((HOST, PORT))
server_socket.listen(1)
conn_db = sqlite3.connect("customers.db")
cursor = conn_db.cursor()

cursor.execute("""CREATE TABLE IF NOT EXISTS customers (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, address TEXT, pps TEXT, license TEXT)""")

print("Server started... Waiting for client")

conn, addr = server_socket.accept()
print("Connected:", addr)

data = conn.recv(1024)
message = data.decode()
print("Received from client:", message)


name, address, pps, license_file = message.split(",")


cursor.execute("INSERT INTO customers (name, address, pps, license) VALUES (?, ?, ?, ?)", (name, address, pps, license_file))

conn_db.commit()


reg_id = cursor.lastrowid
print("Generated Registration ID:", reg_id)


conn.send(str(reg_id).encode())

conn.close()
server_socket.close()