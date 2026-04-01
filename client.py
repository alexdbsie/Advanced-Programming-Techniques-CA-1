import socket

HOST = "127.0.0.1"
PORT = 65432

client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

client_socket.connect((HOST, PORT))

name = input("Enter Name: ")
address = input("Enter Address: ")
pps = input("Enter PPS Number: ")
license_file = input("Enter License File Name: ")

data = name + "," + address + "," + pps + "," + license_file

client_socket.send(data.encode())

print("Customer data sent to server")

client_socket.close()