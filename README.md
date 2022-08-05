# seq-logging-examples

## Seq with Docker
```
mkdir -p seqdata

docker run --name seq -d -e ACCEPT_EULA=Y -v ~/seqdata:/data -p 80:80 -p 5341:5341 datalust/seq

http://localhost:80
```
