# PEsoapC-
## Without Docker
In the correct directory
```
dotnet run
```
## With Docker
In the correct directory
```
docker build .
```
look for the image id
```
docker image ls
```
```
docker run --rm -p 8000:80 [image id]
```

http://127.0.0.1:8000/WiskundeServiceImpl.asmx
