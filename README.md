Sistema Listando Usuarios.

Build Image
  - Na maquina virtual fazer o clone da branch master do repositorio -> https://github.com/lucasfarias7/DockerPos
  - Na branch master após o clone, acessar -> cd ProjetoPosDocker/
  - Executar um ls e verificar se esta o dockerfile, e estando o dockerfile, Executar -> docker build -t lucasfarias123/projetodockerpos:1.0.0 .

Run a Container
  - após executar o build, executar -> docker run -d -p 8080:80 --rm --name app lucasfarias123/projetodockerpos:1.0.0

Acessar http://DOCKER_HOST_IP:8080

Push to Docker Hub:
  - docker login -u lucasfarias123
  - docker push lucasfarias123/projetodockerpos:1.0.0


  
