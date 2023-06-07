# G1ExtracaoNoticias
### Acessar a página do G1 e Extrair as últimas Notícias
> Status: ready to homolog ⚠️

# Estrutura de pastas:
+ Foi desenvolvida uma estrutura por partes, onde cada parte do sistema virou um serviço com a program.cs na pasta raiz orquestrando tudo.
+ A pasta Application contém services, contracts (interfaces), Model e Utils assim como suas respectivas lógicas.
+ A pasta Services contém todas as ações que a automação deve executar.
+ A pasta Model contém a classe com as varíaveis que serão  manipulados pela automação
+ A pasta Utils contém as funções auxiliares  como gerar csv, tratativa de elementos etc.

# Como executar:

## Passo 1: - Inserir o caminho de output para o Csv e Nome.
+ Acessar o caminho .\Application\Services\G1\G1ObterInfoService.cs  
+ Na linha 16, inserir na variável o caminho e nome do arquivo de saída, exemplo: "C:\temp\output.csv"

##  Passo 2: Executar a solution program.cs ⚠️⚠️⚠️⚠️⚠️⚠️
+ Aguardar extração das notícias e geração do CSV.


### Technologies Used:
<table>
  <tr>
  <td>C# Dot 4.8</td>
  <td> Selenium do nugde</td>
  </tr>
  <tr>
  </tr> 
</table>
