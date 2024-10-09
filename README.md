
# MultiVideoConverter

MultiVideoConverter é um aplicativo Windows Forms que permite aos usuários baixar e converter vídeos e músicas do YouTube. Ele suporta processamento em lote, convertendo vídeos para o formato MKV e extraindo áudio para MP3.

## Funcionalidades

- Baixar vídeos do YouTube
- Converter vídeos para MKV com fluxos de áudio e vídeo
- Baixar e converter músicas do YouTube para MP3
- Suporte para download em lote de múltiplos vídeos e músicas
- Interface amigável com indicadores de progresso

## Tecnologias Utilizadas

- **[YoutubeExplode](https://github.com/Tyrrrz/YoutubeExplode)**: Uma biblioteca para baixar vídeos e metadados do YouTube.
- **[Xabe.FFmpeg](https://github.com/tomaszzmuda/Xabe.FFmpeg)**: Uma biblioteca para conversão de vídeos, utilizando FFmpeg.
- **FFmpeg**: Dependência externa para processamento de mídia, baixada automaticamente pelo Xabe.FFmpeg.

## Pré-requisitos

- .NET Framework 4.7.2 ou superior
- Windows 7 ou posterior

## Como Usar

1. Clone o repositório:
    ```bash
    git clone https://github.com/seuusuario/MultiVideoConverter.git
    ```

2. Abra a solução no Visual Studio.

3. Compile o projeto.

4. Execute o aplicativo e siga os passos:

### Download de Vídeos

- Cole o URL do vídeo do YouTube na caixa de texto **Video Link** e clique em **Add**.
- Selecione a pasta para salvar os arquivos baixados clicando em **Location**.
- Pressione **Download** para baixar e converter o vídeo.

### Download de Músicas

- Cole o URL do vídeo do YouTube na caixa de texto **Music Link** e clique em **Add**.
- Selecione a pasta para salvar os arquivos MP3 clicando em **Location**.
- Pressione **Download** para baixar e converter o áudio.

## Bibliotecas Externas

O projeto utiliza duas bibliotecas principais:

- [YoutubeExplode](https://github.com/Tyrrrz/YoutubeExplode): Lida com o parsing e downloads de URLs do YouTube.
- [Xabe.FFmpeg](https://github.com/tomaszzmuda/Xabe.FFmpeg): Envolve as funcionalidades do FFmpeg, permitindo manipulação e conversão de vídeo/áudio.

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
