import socket

HOST = "127.0.0.1"
PORT = 65432

client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

client_socket.connect((HOST, PORT))

message = "Hello Server"
client_socket.send(message.encode())

print("Message sent to server")

client_socket.close()