import socket

HOST = "127.0.0.1"
PORT = 65432

server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server_socket.bind((HOST, PORT))
server_socket.listen(1)

print("Server started... Waiting for client")

conn, addr = server_socket.accept()
print("Connected:", addr)

conn.close()
server_socket.close()